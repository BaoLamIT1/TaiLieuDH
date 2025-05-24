/* Xây dựng lớp spham gồm: mã sp, tên sp, hãng sx, số lg, đơn giá
tg bảo hành và các phg thức cần thiết.
Xây dựng lớp Xe máy: thừa kế từ lớp sp thêm thuộc tính: màu, dung tích
xi lanh(50,70,110,150) và các phgthuc cần thiết
Xây dựng lớp quản lí xe bao gồm danh sách xe máy
Vt chg trình nhập inf của n xe máy của cửa hàng.
Thống kê số lượng xe theo dung tích xe lanh.
Tìm xe có màu và hãng sx cho trc.
*/
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class product{
		string masp,tensp,hangsx;
		int soluong,tgbaohanh;
		float gia;
		public:
	void nhap()
	{
		cout<<"Nhap ma sp: ";cin.ignore(1);cin>>masp;
		cout<<"Nhap ten sp: ";cin.ignore(1);getline(cin,tensp);
		cout<<"Nhap hang sx: ";cin.ignore(1);getline(cin,hangsx);
		cout<<"Nhap so luong: ";cin>>soluong;
		cout<<"Nhap tgbaohanh: ";cin>>tgbaohanh;
		cout<<"Nhap gia: ";cin>>gia;
	}
	string getMasp(){ return masp;}
	string getTensp(){ return tensp;}
	string getHangsx(){ return hangsx;}
	int getSoluong(){ return soluong;}
	int getTgbaohanh(){ return tgbaohanh;}
	float getGia(){ return gia;}
	
	void xuat()
	{
		cout<<masp<<" "<<tensp<<" "<<hangsx<<" "<<soluong<<" "<<tgbaohanh<<" "<<endl;
	}
};
class motor : public product{
	string color;
	int capacity;
	public:
		motor(){
		}
		motor(string color, int capacity)
		{
			this->color=color;
			this->capacity=capacity;
		}
		string getColor(){ return color;}
		int getCapacity(){ return capacity;}
		void nhap()
		{ 
		     product::nhap();
			 cout<<"Nhap mau: ";cin.ignore(1);cin>>color;
			 cout<<"\nNhap dung tich xi lanh (50,70,110,150): ";cin>>capacity;	
		}
		void xuat()
		{
			product::xuat();
			cout<<color<<" "<<capacity<<endl;
		}
		
};
class Quanly{
	int n;
	motor*ds;
	public:		
		friend istream &operator>>(istream&,Quanly&);
		void thongke();
		void find(const string&, const string&);
};
istream &operator>>(istream& Cin, Quanly& Qly)
{
	cout<<"Nhap vao n xe may: "; Cin>>Qly.n;
	Qly.ds=new motor[Qly.n];
	for(int i=0;i<Qly.n;i++)
	{
		cout<<"Nhap xe thu "<<i+1<<endl;
		Qly.ds[i].nhap();
	}
	return Cin;
}
void Quanly::thongke()
{
	int sum1=0, sum2=0,sum3=0,sum4=0;
	for(int i=0;i<n;i++)
	{
		if(ds[i].getCapacity()==50)  sum1+=ds[i].getSoluong();
		if(ds[i].getCapacity()==70)  sum2+=ds[i].getSoluong();
		if(ds[i].getCapacity()==110) sum3+=ds[i].getSoluong();
		if(ds[i].getCapacity()==150) sum4+=ds[i].getSoluong();
	}
	cout<<"\nTong so luong xe 50 la: "<<sum1;
	cout<<"\nTong so luong xe 70 la: "<<sum2;
	cout<<"\nTong so luong xe 110 la: "<<sum3;
	cout<<"\nTong so luong xe 150 la: "<<sum4;
}
void Quanly::find(const string&mau, const string&brand)
{
	bool kq=false;
	for(int i=0;i<n;i++)
{
	if(ds[i].getColor()==mau && ds[i].getHangsx()==brand)
	{
		ds[i].xuat();
		kq=true;
	}
	if(kq!=true)
	cout<<"K co xe can tim !";
}	
}
int main() {
Quanly x; cin>>x;
x.thongke();
string mau; cout<<"\nNhap mau can tim: ";cin>>mau;
string brand; cout<<"\nNhap hang sx can tim: ";cin>>brand;
x.find(mau,brand);
}
