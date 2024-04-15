
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class Dathuc{
	//public:
		int bac; 
		int n; float *hs;
		void nhap();
		void xuat();
		Dathuc tong(Dathuc Q);
		float tinhgt(float x);
		friend int main();
		
	
};
   void Dathuc ::nhap()
   {
   	cout<<"bac da thuc: "; cin>>bac;
   	hs=new float[bac+1];
   	for(int i=0; i<=bac; i++){
   		cout<<"Nhap he so: " <<i<<": ";
   		cin>> hs[i];
	   }
	  }
	void Dathuc:: xuat()
	{
		for(int i=0; i<=bac;i++) cout<<hs[i]<<" ";
	   }   
int main() {
   Dathuc P,Q;
   P.nhap(); P.xuat();
   Q.nhap(); cout<<endl; Q.xuat();
    
}
