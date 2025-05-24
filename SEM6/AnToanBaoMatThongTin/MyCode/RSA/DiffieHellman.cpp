#include<bits/stdc++.h>
#define ll long long
#define MAX 1e9+7
#define MIN -1e9+7
#define f first
#define s second
using namespace std;
int haBac(int a,int m,int n){ //a^m mod n
	if(m == 1) return a%n;
	int c = m/2;
	int d = m%2;
	int v = int(pow(haBac(a,c,n),2) * int(pow(a,d))) % n;
	return v;
}
int main(){
	int q = 6947,a = 5;
	
	int xa = 395, xb = 338 ,ya,yb,ka,kb;
	
	ya = haBac(a,xa,q);
	yb = haBac(a,xb,q);
	
	ka = haBac(yb,xa,q);
	kb = haBac(ya,xb,q);
	
	cout<<"Gia tri YA(khoa cong khai cua A): "<<ya<<'\n';
	cout<<"Gia tri YB(khoa cong khai cua B): "<<yb<<'\n';
	cout<<"Gia tri KA - Khoa bi mat chung: "<<ka<<'\n';
	cout<<"Gia tri KB - Khoa bi mat chung: "<<kb<<'\n';
}

