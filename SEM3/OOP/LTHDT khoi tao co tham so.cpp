#include <iostream>

using namespace std;

class Student {
    private:
    string name;
    int age;
    public:
     Student(string n , int a)    
	 {  
        name = n;
        age = a;
     }
    /*Student(string name, int age) {
        this-> name = name;
       this-> age = age;} */
    void display(){
        cout<<"Name: " << name<< endl;
        cout<<"Age: " << age<< endl;
        
    }
};

int main() {
    Student s1("Long", 24);
    Student s2("Kien", 29);
    s1.display();
    s2.display();
    return 0;
}
