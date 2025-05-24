/* quản lí cửa hàng giày: mã hàng, loại(1: giày bệt, 2:giày dép 3cm,3:5-7cm,4:giày dép có >=9cm), xuất xứ
giá,.Các hàm của lớp: hàm tạo, nhập xuất và các phương thức khác. Nhập thông tin cho n giày dép.
Tke tổng số lượng của mỗi loại giày dép. Tìm giày có xuất x, loại và dưới giá nhập từ bàn phím */
#include<iostream>
      using namespace std;
class shoe{
	string mahang, xuatxu;
	string loai;
	long gia;
	//ham tao
    friend istream &operator>>(istream&,shoe&);
	friend ostream&operator<<(ostream&,const shoe&);
	public:
		string getxuatxu(){
			return xuatxu;
		}
		long getgia(){
			return gia;
		}
		string getloai(){
			return loai;
		}
};
istream & operator>>(istream&Cin, shoe&ts){    
         cout<<"Nhap ma hang: "; Cin>>ts.mahang;
         cout<<"Nhap xuat xu: "; Cin>>ts.xuatxu;
         cout<<"Nhap loai(1,2,3,4): "; Cin>>ts.loai; 
         cout<<"Nhap gia: ";Cin>>ts.gia;
         return Cin;
     }
ostream & operator <<(ostream&Cout, const shoe&ts) {
	    Cout<<ts.mahang<<" "<<ts.xuatxu<<" "<<ts.loai<<" "<<ts.gia;
	return Cout;
}
class thongke{
	int n;
	shoe*ds;
	friend istream & operator>>(istream&,thongke&);
	friend ostream &operator<<(ostream&,const thongke&);
	public:
	void tong();
	void timkiem(const string&,const string& , const long&);
};
istream & operator>>(istream&Cin,thongke&tk){
	cout<<"Nhap so giay ";Cin>>tk.n;
	tk.ds=new shoe[tk.n];
	for(int i=0;i<tk.n;i++)
	{
		cout<<"nhap giay thu "<<i+1<<endl;
		Cin>>tk.ds[i];
	}
	return Cin;
}
ostream & operator<<(ostream&Cout,const thongke&tk){
	for(int i=0;i<tk.n;i++) Cout<<tk.ds[i]<<endl;
	return Cout;
}
void thongke::tong()
{
	int sum1=0, sum2=0,sum3=0,sum4=0;
	for(int i=0;i<n;i++)
	{
		if(ds[i].getloai()=="1")
		   sum1++;
		if(ds[i].getloai()=="2")
		   sum2++;
		if(ds[i].getloai()=="3")
		   sum3++;
		if(ds[i].getloai()=="4")
		   sum4++;
	}
	cout<<"\nTong so luong giay loai 1 la "<<sum1<<endl;
	cout<<"\nTong so luong giay loai 2 la "<<sum2<<endl;
	cout<<"\nTong so luong giay loai 3 la "<<sum3<<endl;
	cout<<"\nTong so luong giay loai 4 la "<<sum4<<endl;
}
void thongke::timkiem(const string & timgiay, const string&type, const long&giagiay)
{
bool kq=false;
for(int i=0;i<n;i++)
{
	if(ds[i].getxuatxu()==timgiay && ds[i].getloai()==type && ds[i].getgia()==giagiay)
	{
		cout<<ds[i]<<endl;
		kq=true;
	}
	if(kq!=true)
	cout<<"K co giay can tim !";
}	
}
int main()
{
thongke x; cin>>x;
x.tong() ; cout<<x;
string timgiay; cout<<"Nhap giay can tim: ";cin>>timgiay;
string type; cout<<"Nhap loai can tim: ";cin>>type;
long giagiay; cout<<"Nhap gia giay can tim: ";cin>>giagiay;
x.timkiem(timgiay,type,giagiay);
}
