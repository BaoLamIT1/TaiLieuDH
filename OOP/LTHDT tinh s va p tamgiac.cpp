#include <iostream>

using namespace std;

class Rectangle {
public:
    double length, width;
    void getInformation(){
        cin >> width;
        cin >>length;
    }
    /*double getArea(){
        return width*length;
    }
    double getPerimeter(){
        return ( width + length)*2;
    } 
    void display() {
        cout << "Area: " << getArea() << endl;
        cout << "Perimeter: " << getPerimeter() << endl;
    */
    void display(){
        cout <<"Area: " << width*length << endl;
        cout<<"Perimeter: "<< (width+length)*2 <<endl;
    }
};

int main() {
    Rectangle r1;
    r1.getInformation();
    r1.display();
    return 0;
}
