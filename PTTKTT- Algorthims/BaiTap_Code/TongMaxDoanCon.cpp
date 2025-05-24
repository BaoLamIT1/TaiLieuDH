#include<bits/stdc++.h>
using namespace std;
long Max(long *a, int L, int R){
	if(L==R) return a[L];
	int M=(L+R)/2;
	long ML=Max(a,L,M);
	long MR=Max(a,M+1,R);
	long TL= a[M], s=a[M];
	for(int i=M-1;i>=L;i--){
		s+=a[i];
		if(TL<s)	TL=s;
	}
	long TR = a[M+1], p=a[M+1];
	for(int i=M+2;i<=R;i++){
		p+=a[i];
		if(TR<p)	TR=p;
	}
	long MM = TR + TL;
	return MM>ML && MM>MR ? MM : (ML>MR ? ML : MR);
}

int main()
{
	int n;
	long *A;
	cin>>n;
	A = new long[n+5];
	for(int i=1;i<=n;i++){
		cin>>A[i];
	}
	cout<<"Day con lien tuc co tong max la: "<<Max(A, 1, n);
 	return 0;
}
