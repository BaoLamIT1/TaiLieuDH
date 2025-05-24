/*
Xây dựng lớp cơ sở NhanVien(mã, ht; và các phương thức cần thiết); 
Xây dựng lớp dẫn xuất BienChe của lớp NhanVien bổ sung them thuộc tính: 
Số năm công tác, hệ số lương; phương thức tính lương và các phương thức cần thiết.
Viết chương trình nhập thông tin cho n nhân viên trong biên chế. 
Tính lương bình quân của nhân viên; Tìm nhân viên có số năm công tác nhiều nhất. Tìm nhân viên có tên cho trước.
Biết rằng lương=HSL*LCB+ phụ cấp; phụ cấp là 10 nếu snct>10 năm; 7: <5snct<=10; còn lại thì phụ cấp là 3 triệu
*/
#include<iostream>
#include<bits/stdc++.h>
using namespace std;
const long LCB = 1490;
class NhanVien {
    int ma;
    string hoten;
    public:
        void nhap() {
            cout << "nhap ma nhan vien "; cin.ignore(1);cin>>ma;
            cout << "nhap ho ten nhan vien "; cin.ignore(1);getline(cin,hoten);
        }
        void xuat() {
            cout << ma << " " << hoten;
        }
        string getHT() {
            return hoten;
        }
        NhanVien(){
		}
        NhanVien(int ma, string hoten){
        	this->hoten=hoten;
        	this->ma=ma;
		}
};
class BienChe : public NhanVien {
    float hesoluong;
    int sonct;
public:
	BienChe():NhanVien(){
		sonct=hesoluong=0;
	}
	BienChe(float hesoluong, int sonct, int ma, string hoten):NhanVien(ma,hoten){
		this->hesoluong=hesoluong;
		this->sonct=sonct;
	}
    void nhap() {
        NhanVien::nhap();
        cout << "nhap he so luong ";;cin >> hesoluong;
        cout << "nhap so nam cong tac ";;cin >> sonct;
    }
    void xuat() {
        NhanVien::xuat();
        cout << " " << hesoluong << " " << sonct;
    }
    float tinhluong() {
        float  phucap;
        if (sonct > 10) phucap = 10000;
        else if (sonct > 5) phucap = 7000;
        else
        {
            phucap = 3000;
        }
        return phucap+hesoluong*LCB;
    }
    int getsnct() {
        return sonct;
    }
    float getHSL(){
    	return hesoluong;
	}
    
};


class Ungdung {
    int n;
    BienChe* ds;
    friend istream& operator>>(istream&, Ungdung&);
    friend ostream& operator<<(ostream&, const Ungdung&);
public:
    float luongtb();
    void MaxSonct();
    void TimNhanVien(const string&);
    void Minhesoluong();
    void sapxep();
    
	
};
istream& operator>>(istream& CIN, Ungdung& x) {
    cout << "nhap so nhan vien "; CIN >> x.n;cin.ignore(1);
    x.ds = new BienChe[x.n];
    for (int i = 0;i < x.n;i++)
    {
        cout << "nhap nhan vien thu " << i + 1 << endl;
        x.ds[i].nhap();
    }
    return CIN;
}
float Ungdung::luongtb() {
    float s = 0;
    for (int i = 0;i < n;i++)
    {
        s+=ds[i].tinhluong();
    }
    return s / n;
}
void Ungdung::MaxSonct() {
    int max = 0;
    for (int i = 0;i < n;i++)
    if(ds[i].getsnct()>max){
        max= ds[i].getsnct();
    }
    cout << "\nDanh sach nv co so nam cong tac nhieu nhat\n";
    for (int i = 0;i < n;i++)
        if (ds[i].getsnct() == max) {
            ds[i].xuat();
        }
}

void Ungdung::TimNhanVien(const string&ten) {
    int k = 0;
    for (int i = 0;i < n;i++)
        if (ds[i].getHT() ==ten) {
             ds[i].xuat();
             k = 1;
        }
    if (k == 0) cout << "\nk tim thay";
}
void Ungdung::Minhesoluong(){
	int min=ds[0].getHSL();
	for(int i=0;i<n;i++)
	{
		if(ds[i].getHSL()<min){
			min=ds[i].getHSL();
		}
	
	}
	cout<<"\nNhan vien co he so luong thap nhat la:"<<endl;
	for(int i =0;i<n;i++)
	{
	
	  if(ds[i].getHSL()==min){
	  	ds[i].xuat();
	  }
}
}
void Ungdung::sapxep()
{    
	for(int i=0;i<n-1;i++){
		for(int j=i+1;j<n;j++)
		 {
		 	if(ds[i].tinhluong()<ds[j].tinhluong())
		 	{
		 		swap(ds[i],ds[j]);		 }
		 }
	}
	cout<<"\nNhan vien sau khi sap xep luong giam dan la: "<<endl;
	for(int i=0;i<n;i++)
	{
		ds[i].xuat();
	}
	
}
int main()
{
    Ungdung x;
    cin>>x;
    cout << "\nLuong binh quan " << x.luongtb();
    x.MaxSonct();
    x.TimNhanVien("ten tim");
    x.Minhesoluong();
    x.sapxep();
}

