//ham trung ten. 
/* C++ cho phep nhieu ham cung ten nhg so luong doi va kieu cua doi phai khac nhau
*/
#include<stdio.h>
#include<math.h>
#include<stdlib.h>
#include<conio.h>
#include<string.h>
#include<iostream>
#include<bits/stdc++.h>
            using namespace std;

float Shinh(const float r){
	return 3.14*r*r;
}
float Shinh(const float &a, const float &b){
	return a*b;
}
float Shinh(const &a, const float &b, const float&c)
{
	return sqrt((a+b+c)* (a+b+c-a)*(a+b+c-b)*(a+b+c-c));
}
int main(){
	cout<< Shinh(15)<<endl;
	cout<< Shinh(20,25)<<endl;
	cout<< Shinh(15,20,25)<<endl;
}