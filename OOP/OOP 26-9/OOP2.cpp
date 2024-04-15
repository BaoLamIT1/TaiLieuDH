/*Để quản lý thi olympic người ta xây dựng một lớp thisinh gồm: sô báo danh, ho tên, điểm, trường
(giả sử có trường A1, A2, A3 tham gia thi).Các hàm của lớp: nhập, xuất và các phương thức khác. 
Nhập thông tin cho n thí sinh. Thống kê tổng điểm của mỗi trường. Cho biết trường nào có tổng điểm cao nhất.*/
#include<iostream>

      using namespace std;
class thisinh{
	string sbd,hoten,truong;
	float diem;
	
	//ham tao
	friend istream &operator>>(istream&,thisinh&);
	friend ostream&operator<<(ostream&,const thisinh&);
	public:
		long getdiem(){
			return diem;
		}
		string gettruong(){
			return truong;
		}
};
istream & operator>>(istream&Cin,thisinh&ts){
	cout<<"Nhap ho ten " ; Cin>>ts.hoten;
	cout<<"Nhap sbd ";Cin>>ts.sbd;
	cout<<"Nhap diem ";Cin>>ts.diem;
	cout<<"Nhap ten truong ";Cin>>ts.truong;
	return Cin;
}
ostream &operator <<(ostream&Cout, const thisinh&ts){
	Cout<<ts.hoten<<" "<<ts.sbd<<" "<<ts.diem<<" "<<ts.truong;
	return Cout;
}
class thongke{
	int n;
	thisinh*ds;
	friend istream & operator>>(istream&,thongke&);
	friend ostream &operator<<(ostream&,const thongke&);
	public:
		void tongdiem();
		void sapxep();
};
istream & operator>>(istream&Cin,thongke&tk){
	cout<<"Nhap so thi sinh ";Cin>>tk.n;
	tk.ds=new thisinh[tk.n];
	for(int i=0;i<tk.n;i++)
	{
		cout<<"nhap thi sinh thu "<<i+1<<endl;
		Cin>>tk.ds[i];
	}
	return Cin;
	
}
ostream & operator<<(ostream&Cout,const thongke&tk){
	for(int i=0;i<tk.n;i++) Cout<<tk.ds[i]<<endl;
	return Cout;
}
void thongke ::sapxep(){
	for(int i=0;i<n-1;i++)
	for(int j=i+1;j<n;j++)
	 if(ds[i].getdiem()>ds[j].getdiem())
	 {
	 	thisinh tem=ds[i]; 
	 	ds[i]=ds[j];ds[j]=tem;
	 }
}
void thongke::tongdiem()
{
	int sum1=0, sum2=0,sum3=0;
	for(int i=0;i<n;i++)
	{
		if(ds[i].gettruong()=="A1")
		   sum1+=ds[i].getdiem();
		if(ds[i].gettruong()=="A2")
		   sum2+=ds[i].getdiem();
		if(ds[i].gettruong()=="A3")
		   sum3+=ds[i].getdiem();   
	}
	cout<<"\nTong diem truong A1 la "<<sum1;
	cout<<"\nTong diem truong A2 la "<<sum2;
	cout<<"\nTong diem truong A3 la "<<sum3;
	if(sum1>sum2 ) 
	{
		if(sum1>sum3)
	cout<<"\nTruong A1 co tong diem lon nhat";
	else 
	cout<<"\nTruong A3 co tong diem lon nhat";
	}
	else{
		if(sum2>sum3) cout<<"\nTruong A2 co tong diem lon nhat";
		else 
		cout<<"\nTruong A3 co tong diem lon nhat";
	}
	
}
int main() {
thongke x;
cin>>x;
x.sapxep(); cout<<x;
x.tongdiem();
}
