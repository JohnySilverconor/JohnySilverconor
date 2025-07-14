#include <iostream>
#include <queue>
#include <vector>
#include <cmath>
#include <unordered_set>
#include <algorithm>

struct Node {
    int x, y;
    int g, h, f;
    Node* parent;

    Node(int x, int y) : x(x), y(y), g(0), h(0), f(0), parent(nullptr) {}

    bool operator>(const Node& other) const {
        return f > other.f; // Used by priority queue
    }
};

int calculateHeuristic(int x1, int y1, int x2, int y2) {
    return std::abs(x1 - x2) + std::abs(y1 - y2);
}

std::vector<std::pair<int, int>> findPath(int startX, int startY, int goalX, int goalY, const std::vector<std::vector<int>>& grid) {
    std::priority_queue<Node, std::vector<Node>, std::greater<Node>> openSet;
    std::unordered_set<Node*> closedSet;

    Node* startNode = new Node(startX, startY);
    Node* goalNode = new Node(goalX, goalY);
    openSet.push(*startNode);

    while (!openSet.empty()) {
        Node current = openSet.top();
        openSet.pop();

        if (current.x == goalX && current.y == goalY) {
            std::vector<std::pair<int, int>> path;
            Node* temp = &current;
            while (temp != nullptr) {
                path.push_back({temp->x, temp->y});
                temp = temp->parent;
            }
            std::reverse(path.begin(), path.end());
            return path;
        }

        closedSet.insert(new Node(current.x, current.y));

        int dx[] = {0, 0, 1, -1};
        int dy[] = {1, -1, 0, 0};

        for (int i = 0; i < 4; ++i) {
            int nx = current.x + dx[i];
            int ny = current.y + dy[i];

            if (nx >= 0 && nx < grid.size() && ny >= 0 && ny < grid[0].size() && grid[nx][ny] == 0) {
                bool skip = false;
                for(const auto node : closedSet){
                    if(node->x == nx && node->y == ny){
                        skip = true;
                        break;
                    }
                }
                if(skip) continue;

                Node neighbor(nx, ny);
                int newG = current.g + 1;
                neighbor.g = newG;
                neighbor.h = calculateHeuristic(nx, ny, goalX, goalY);
                neighbor.f = neighbor.g + neighbor.h;
                neighbor.parent = new Node(current.x, current.y);

                bool foundInOpen = false;
                std::priority_queue<Node, std::vector<Node>, std::greater<Node>> tempOpen = openSet;
                while (!tempOpen.empty()) {
                    Node openNode = tempOpen.top();
                    tempOpen.pop();
                    if (openNode.x == nx && openNode.y == ny) {
                        foundInOpen = true;
                        if (newG < openNode.g) {
                            openSet = std::priority_queue<Node, std::vector<Node>, std::greater<Node>>();
                            while(!tempOpen.empty()){
                                if(tempOpen.top().x != nx || tempOpen.top().y != ny)
                                    openSet.push(tempOpen.top());
                                tempOpen.pop();
                            }
                            openSet.push(neighbor);
                        }
                        break;
                    }
                }

                if (!foundInOpen) {
                    openSet.push(neighbor);
                }
            }
        }
    }
    return {};
}

int main() {
    std::vector<std::vector<int>> grid = {
        {0, 0, 0, 0, 0},
        {0, 1, 1, 1, 0},
        {0, 0, 0, 0, 0},
        {0, 1, 1, 1, 0},
        {0, 0, 0, 0, 0}
    };

    std::vector<std::pair<int, int>> path = findPath(0, 0, 4, 4, grid);

    if (!path.empty()) {
        std::cout << "Path found: ";
        for (const auto& point : path) {
            std::cout << "(" << point.first << ", " << point.second << ") ";
        }
        std::cout << std::endl;
    } else {
        std::cout << "No path found." << std::endl;
    }

    return 0;
}