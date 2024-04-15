#include<iostream>
 
 using namespace std;
 
class Student {
  private:
  string name;
  int age;
  string gender;
  double gpa;
  public:
  	/* Student(string n, int a, string ge,double g){
  	 name=n;
  	 age=a;
  	 gender=ge;
  	 gpa=g;
}
  	 */
  Student(string name, int age, string gender, double gpa){
      this -> name=name;
      this -> age=age;
      this -> gender=gender;
      this -> gpa=gpa;
  };
  void display(){
      cout <<"Name: "<<name<<endl;
      cout<<"Age: "<<age<<endl;
      cout<<"Gender: "<<gender<<endl;
      cout<<"GPA: "<<gpa<<endl;
  }
};
int main(){
	Student s1("Long",24,"Male",3.42);
	Student s2("Lam",19,"Male",3.65);
	Student s3("Linh",21,"Female",3.72);
	Student s4("Lan",23,"Female",3.22);
	s1.display();s2.display();
	s3.display();s4.display();
}
