
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
void sapxep(int *a, int n, bool cmp(int,int)){
      	for(int i =0; i<n;i++)
      	for(int j =i+1; j<n;j++)
      	if (a[i] >a[j]) { a[i]^=a[j];a[j]^=a[i];a[i]^=a[j];}
	  }
bool ss(int a, int b){
	if (a%2==b%2) return a<b;
	return a%2<b%2;
}   
int main() {
int n=1e5;
int a[n]={ 4,7,8,2,1,62,19,35,50}, n=sizeof(a) /sizeof(a[0]);
sapxep(a,n,ss);
cout<<"Day sau sap xep: "; for(int x:a) cout <<x<<" ";
}
  