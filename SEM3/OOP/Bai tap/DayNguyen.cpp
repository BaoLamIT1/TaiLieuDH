
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class DayNguyen{
	int n;
	int *tp;
	public:
		void nhap();
		void in();
		int max();
		int demle();
		void cong2day();
		void tongpt();
		void sxgiamdan();
};
void DayNguyen::nhap(){
    cout<<"So phan tu cua day: ";cin>>n;
    tp=new int[n];
    for(int i=0;i<n;i++)
    {
    	cout<<"Nhap thanh phan thu "<<i<<":";
    	cin>>tp[i];
	}
	}
void DayNguyen::in(){
	for(int i=0;i<n;i++) cout<<tp[i]<<"\t";
}
int DayNguyen::max(){
	int m=tp[0];
	for(int i=1;i<n;i++)
	 if(tp[i]>m) m=tp[i];
	 cout<<"\nPhan tu max cua day la: "<<m<<endl;
	 return m;
}
int DayNguyen::demle(){
	int dem=0;
	for(int i=0;i<n;i++)
	if(tp[i]%2)
	dem++;
	cout<<"\nSo phan tu le day la: "<<dem<<endl;
	return dem;
}
void DayNguyen::tongpt(){
	int sum=tp[0];
	for(int i=1;i<n;i++)
	sum+=tp[i];
	cout<<"Tong cac phan tu cua day la: "<<sum<<endl;
}
void DayNguyen::sxgiamdan(){
     int tg;
     for(int i=0;i<n-1;i++){
     	for (int j=i+1;j<n;j++){
     		if(tp[i]<tp[j]){
     			tg=tp[i];
     			tp[i]=tp[j];
     			tp[j]=tg;
			 }
		 }
	 }
	 cout<<"Day sx giam dan: ";
	 for(int i=0;i<n;i++)
	 cout<<tp[i]<<" ";
}
int main() {
DayNguyen a,b;
a.nhap();
a.in();
a.max(); 
a.demle();
a.tongpt();
a.sxgiamdan();
}
