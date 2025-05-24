
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class Student{
	private: 
	string name;
	int age;
	public:
		static int numberofStudents;
		Student(string name, int age){
			this ->name=name;
			this ->age=age;
			numberofStudents++;
		}
};
      int Student ::numberofStudents =0;
int main() {
Student s1("Lam",19);
Student s2("Manh",18);
Student s3("Thang",17);
Student s4("Ki",18);
cout<<s1.numberofStudents <<""<<s2.numberofStudents;

}
