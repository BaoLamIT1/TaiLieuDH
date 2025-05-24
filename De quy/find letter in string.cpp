
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
string name;
int find(char a , char b ){
	int kq, d=0;
	if(string(a) && string(b) !=NULL)
	{
		kq=strlen(a) -strlen(strstr(a,b));
		for(int  i=kq;i>=0;i--)
		if(a[i] == ' ')
		d++;
		return d+1;
	}
	else return -1;
}

      
int main() {
string name;
cin>> name;

}
