
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class Tivi{
	int mahang;
	string hangsx, tenTv;
	int gia;
	int solg;
	public:
		//getter &setter
	int getMa(){return mahang;
	}
	void setMa(int ma){
		mahang=ma;
	}
	string getHangsx(){
		return hangsx;
	}
	void setHangsx(string brand){
		hangsx=brand;
	}
	string getTenTv(){
		return tenTv;
	}
	float getGia(){
	return gia;
	}
	int getSolg(){
	return solg;
	}
	//void nhap
	/*
	void nhap()
	{
		cout<<"\nNhap ma Tv: "; cin>>mahang;
		cout<<"\nNhap hang sx:"; cin>>hangsx;
		cout<<"\nNhap ten TV: ";cin>>tenTv;
		cout<<"\nNhap gia tv: ";cin>>gia;
		cout<<"\nNhap so luong tv: ";cin>>solg;
		
	}
	*/
	 friend istream &operator>>(istream & input, Tivi &TV)
	 {
	 	cout<<"\nNhap ma tivi: ";input>>TV.mahang;
	 	cout<<"\nNhap Hang sx: ";input>>TV.hangsx;
	 	cout<<"\nNhap ten tivi: ";input>>TV.tenTv;
	 	cout<<"\nNhap gia tivi: ";input>>TV.gia;
	 	cout<<"\nNhap so luong tivi: "; input>>TV.solg;
	 	return input;
	 }
     friend ostream &operator<<(ostream & output, const Tivi TV)
	 {
	 	output<<"Ma TV: "<<TV.mahang<<"\nHang sx: "<<TV.hangsx<<"\nTenTV: "<<TV.tenTv<<"\nGia tv: "<<TV.gia<<"\nSo luong: "<<TV.solg;
	 	return output;
		 }	
	//void xuat()
	//{
	//	cout<<"Ma Tv: "<<mahang<<"\nHang sx: "<<hangsx<<"\nTenTV: "<<tenTv<<"\nGia tv: "<<gia<<"\nSo luong: "<<solg;
	//}
	// 
};
class Vector{
	  public:
	  vector<Tivi> v;
	  void Them1TV()
	  {
	  	Tivi x;
	  	cout<<"Nhap thong tin tivi can them: "; cin>>x;
	  	this->v.push_back(x);
	  }
	  
	  void Xoa1TV()
	  {
	  	if(v.size()==0)
	  	{
	  		cout<<"Khong co ti vi nao!";
		  }
		  else 
		  {
		  	int code; float kt=0;
		  	cout<<"Nhap ma ti vi can xoa: "; cin>>code;
		  	for(int i=0; i<=v.size();i++)
		  	{
		  		if(v[i].getMa()==code)
		  		{
		  			v.erase(v.begin()+i);
		  			kt++;
				  }
			  }
			  if(kt!=0) cout<<"Xoa thanh cong"; else cout<<"Xoa ko thanh cong";
		  }
	  }
	  void Tong()
	  {
	  	int sum=0;
	  	string brand;
	  	if(this->v.size()==0)
	  	{
	  		cout<<"k co ti vi nao !";
		  }
		  else
		  {
		  	for(int i=0;i<=v.size();i++)
		  	{
		  		if(v[i].getHangsx()==brand)
		  		{
		  			sum+=v[i].getGia()*v[i].getSolg();
				  }
			  }
		  }
	  }
	  void Hienthi()
	  {
	  	if(this->v.size()==0){
	  		cout<<"Khong co ti vi nao !";
		  }
		  else
		  {
		  	for(int i=0;i< this->v.size();i++)
		  	{
			  cout<<" "<<this->v[i].getMa()<<endl;
		  }
	  }
}
int BinarySearch(int maTV)
{
	int n=v.size();
	int Found =0; int mid;
	int i=0; int j=n-1;
	while(i<=j && Found !=1)
	{
		mid=(i+j)/2;
		if(maTV ==v[mid].getMa()) Found=1;
		else if(maTV <v[mid].getMa())
		j=mid-1;
		else i=mid+1;
	}
	return Found;
}
}; 



  
int main() {
Vector Tv; 
Tv.Them1TV();Tv.Them1TV();Tv.Them1TV();
Tv.Xoa1TV();
cout<<"Ti vi hien co trong vector la: ";Tv.Hienthi();
Tv.Tong();
cout<<"NHap ma TV can tim: "; int maTVcantim; cin>>maTVcantim;
if(Tv.BinarySearch(maTVcantim)==1) cout<<"Found";
else cout<<"Not Found";
}
