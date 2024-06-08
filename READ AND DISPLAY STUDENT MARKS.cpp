//READ AND DISPLAY STUDENT MARKS Throught INHERITANCE
#include<iostream>
#include<conio.h>
using namespace std;
class student
{
  protected:
  int entryno;
  char name[20];
  public:
  void getdata()
  {
    cout<<"enter name of the student"<<endl;
    cin>>name;
  }
  void display()
  {
    cout<<"Name of the student is"<<name<<endl;
  }
};
class science:public student
{
  int pcm[3];
  public:
  void getdata()
  {
    student::getdata();
    cout<<"Enter marks for Physics,Chemistry and Mathematics\n";
    for(int j=0;j<3;j++)
    {
      cin>>pcm[j];
    }
  }
  void display()
  {
    entryno=1;
    cout<<"entry no for Science student is"<<entryno<<endl;
    student::display();
    cout<<"Marks in Physics,Chemistry and Mathematics are"<<endl;
    for(int j=0;j<3;j++)
    {
      cout<<pcm[j]<<endl;;
    }
  }
};
class arts:public student
{
  int ehe[3];
  public:
  void getdata()
  {
    student::getdata();
    cout<<"Enter marks for English,History and Economics"<<endl;
    for(int j=0;j<3;j++)
    {
      cin>>ehe[j];
    }
  }
  void display()
  {
    entryno=2;
    cout<<"entry no for Arts student is "<<entryno<<endl;;
    student::display();
    cout<<"Marks in English,History and Economics are"<<endl;
    for(int j=0;j<3;j++)
    {
      cout<<ehe[j]<<endl;;
    }
  }
};
int main()
{
  //clrscr();
  science s1[3];
  arts a1[3];
  int i,j,k,l;
  cout<<"Entry for Science students"<<endl;
  for(i=0;i<3;i++)
  {
    s1[i].getdata();
  }
  cout<<"Details of three Science students are"<<endl;
  for(j=0;j<3;j++)
  {
    s1[j].display();
  }
  cout<<"Entry for Arts students"<<endl;
  for(k=0;k<3;k++)
  {
    a1[k].getdata();
  }
  cout<<"Details of three Arts students are"<<endl;
  for(l=0;l<3;l++)
  {
    a1[l].display();
  }
  getch();
  return 0;
}