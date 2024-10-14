#include <iostream>
#include <string>

int main()
 {
     // detect repeated words program
     
     
          std::string previous = " ";   
          std::string current;          
// previous word; initialized to “not a word”

 // current word
          while (std::cin>>current) {      
                    if (previous == current) 
// read a stream of words

 // check if the word is the same as last
 
    std::cout << "repeated word: " << current << '\n';
          previous = current;
          }
          return 0; 
 }