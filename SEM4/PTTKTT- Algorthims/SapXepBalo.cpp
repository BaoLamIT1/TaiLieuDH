//Sap xep ba lo
#include<bits/stdc++.h>
using namespace std;
struct dovat{int id;double kt,gt;};
bool ss(dovat u,dovat v)
{
	double x=u.gt/u.kt,y=v.gt/v.kt;
	if(x==y) return u.gt>v.gt;
	return x>y;
}
class Balo
{
	int n,M;
	dovat A[1000];
	public:
		void nhap()
		{
			cout<<"Nhap so do vat : "; cin>>n;
			for(int i=1;i<=n;i++)
			{
				A[i].id=i;
				cout<<"Do vat "<<i<<" : ";
				cin>>A[i].kt>>A[i].gt;
			}
			cout<<"Kich thuoc ba lo :"; cin>>M;
			sort(A+1,A+n+1,ss);
		}
		void sapxepbalo()
		{
			int K=0,G=0;
			for(int i=1;i<=n;i++)
			if(K+A[i].kt<=M)
			{
				cout<<"\nLay vat "<<A[i].id<<" kich thuoc "<<A[i].kt<<" gia tri "<<A[i].gt;
				K+=A[i].kt;
				G+=A[i].gt;
			}
			cout<<"\nTong kich thuoc "<<K<<"\nTong gia tri "<<G;
		}
};
int main(){Balo B; B.nhap();B.sapxepbalo();}



