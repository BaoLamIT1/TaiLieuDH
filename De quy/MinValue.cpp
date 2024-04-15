#include<iostream>
#include<bits/stdc++.h>
 using namespace std;
int Min(int A[], int n)
{
	if (n == 0)
		return -1;
	if (n == 1)
		return A[0];
	else
	{
		if (A[n - 1] < Min(A, n - 1))
			return A[n - 1];
		else
			return Min(A, n - 1);
	}
}
int  main()
{ 
    int a[50],n; 
	cout<<"Nhap so luong phan tu cua day: "; cin>>n;
	for(int i=0;i<n;i++) {
		cout<<"a["<<i<<"]= "; cin >>a[i];
	}
	cout<<"Min cua day la: "<<Min(a,n);
	
}