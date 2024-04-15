/*
Xây dựng lớp thí sinh:
Thuộc tính: sbd, ht, m1,m2,m3, Khu vuc (1,2,3)
Phương thức: tạo, nhập, tính tổng điểm va phuong thuc khac
Viết chương trình nhập thông tin cho n thí sinh (sbd, ht, m1,m2,m3, khu vực dự thi (1,2,3)).
In Nhập điểm chuẩn và in danh sách trúng tuyển. 
Thong ke so sinh vien du thi theo khu vuc
 */
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class Candidate{
	string sbd, ten;
	float m1,m2,m3;
	int khuvuc;
	//ham tao
	friend istream &operator >>(istream&,Candidate&);
	friend ostream &operator <<(ostream&, const Candidate&);
	public:
		string getTen(){
			return ten;
		}
		string getSBD(){
			return sbd;
		}
		float getm1(){
			return m1;
		}
		float getm2(){
			return m2;
		}
		float getm3(){
			return m3;
		}
		int getkhuvuc(){
			return khuvuc;
		}
	float tongdiem();	
		
}; 
istream &operator>>(istream &Cin, Candidate&ts){
	cout<<"Nhap sbd: ";Cin>>ts.sbd;
	cout<<"Nhap ho ten: ";Cin.ignore();getline(Cin,ts.ten);
	cout<<"Nhap diem mon 1:";Cin>>ts.m1;
	cout<<"Nhap diem mon 2:";Cin>>ts.m2;
	cout<<"Nhap diem mon 3:";Cin>>ts.m3;
	cout<<"Nhap khu vuc (1,2,3):";Cin>>ts.khuvuc;
	return Cin;
}
ostream &operator<<(ostream &Cout, const Candidate&ts){
	Cout<<ts.sbd<<" "<<ts.ten<<" "<<ts.m1<<" "<<ts.m2<<" "<<ts.m3<<" "<<ts.khuvuc;
	return Cout;
} 
float Candidate::tongdiem(){
	return m1+m2+m3;
}
class thongke{
	int n;
	float diemchuan;
	Candidate*ds;
	friend istream & operator>>(istream&,thongke&);
	friend ostream &operator<<(ostream&,const thongke&);
	public:
	void thongkeCandidate();
	void trungtuyen();
};
istream & operator>>(istream&Cin,thongke&tk){
	cout<<"Nhap so thi sinh ";Cin>>tk.n;
	tk.ds=new Candidate[tk.n];
	for(int i=0;i<tk.n;i++)
	{
		cout<<"nhap thi sinh thu "<<i+1<<endl;
		Cin>>tk.ds[i];
	}
	return Cin;
}
ostream & operator<<(ostream&Cout,const thongke&tk){
	for(int i=0;i<tk.n;i++) 
	Cout<<tk.ds[i]<<endl;
	return Cout;
}
void thongke::thongkeCandidate(){
	int sum1=0,sum2=0,sum3=0;
	for(int i=0;i<n;i++)
	{
		if(ds[i].getkhuvuc()==1) sum1++;
		if(ds[i].getkhuvuc()==2) sum2++;
		if(ds[i].getkhuvuc()==3) sum3++;
	}
	cout<<"So luong thi sinh khu vuc 1 du thi la:"<<sum1<<endl;
	cout<<"So luong thi sinh khu vuc 2 du thi la:"<<sum2<<endl;
	cout<<"So luong thi sinh khu vuc 3 du thi la:"<<sum3<<endl;
}
void thongke::trungtuyen()	{
	
	cout<<"Nhap diem chuan: "; cin>>diemchuan;
	bool kq=false;
	cout<<"Danh sach trung tuyen:\n";
	 for(int i=0;i<n;i++)
	 {
	 	if(ds[i].tongdiem() >= diemchuan)
	 	{
	 		kq=true;
	 		cout<<"Thi sinh "<< ds[i]<<" da trung tuyen";
		 }
	 }
	 if(!kq)
	 cout<<"Ko trung tuyen";
}




int main() {
thongke x; cin>>x;
x.thongkeCandidate();
x.trungtuyen();
}
