#include<bits/stdc++.h>
using namespace std;
class matran
{
	public:
		int **a;
		int n;
		friend matran operator+(matran b,matran d)
		{
			matran c;
			c.n=b.n;
			c.a=new int *[c.n+1];
			for(int i=1;i<=c.n;i++)
			c.a[i]=new int [c.n+1];
			for(int i=1;i<=c.n;i++)
			for(int j=1;j<=c.n;j++)
			{
				c.a[i][j]=b.a[i][j]+d.a[i][j];
			}
			return c;
		}
		friend istream &operator>>(istream &is,matran &p)
		{
			cout<<"Nhap co ma tran:";cin>>p.n;
			p.a=new int *[p.n+1];
			for(int i=1;i<=p.n;i++)
			p.a[i]=new int [p.n+1];
			for(int i=1;i<=p.n;i++)
			for(int j=1;j<=p.n;j++)
			{
				cout<<"["<<i<<"]["<<j<<"]=";
				cin>>p.a[i][j];
			}
			return is;
		}
		friend ostream &operator<<(ostream &os,matran p)
		{
			for(int i=1;i<=p.n;i++)
			{
				for(int j=1;j<=p.n;j++)
				os<<setw(10)<<p.a[i][j];
				os<<endl;
			}
			return os;
		}	
};
int main()
{
	matran a,b,c,d;
	cout<<"Nhap ma tran thu nhat:"<<endl;
	cin>>a;
	cout<<"Nhap ma tran thu hai:"<<endl;
	cin>>b;
	cout<<"\nMa tran thu nhat : \n";
	cout<<a;
	cout<<"\nMa tran thu hai : \n";
	cout<<b;
//	c=a+b;
	if(a.n==b.n)
	cout<<"\nTong 2 ma tran : \n"<<a+b;
	else cout<<"\nKhong tinh duoc";


}
