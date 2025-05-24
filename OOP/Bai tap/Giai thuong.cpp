#include<bits/stdc++.h>
#include<iostream>
// TKe so tien thuong theo tung AP ( 1 2 3 4 5)
//TIm tac gia co tien thuong cao nhat
using namespace std;
class NGUOI{
	string hoten;
	int tuoi;
	public:
		
		void nhap()
		{
			cout<<"\nNhap vao ten nguoi: "; cin>>hoten;
			cout<<"\nNHap so tuoi: "; cin>>tuoi;
		}
		string getHoten(){
			return hoten;
		}
		int getTuoi(){
			return tuoi;
		}
		void xuat(){
			cout<<hoten<<" "<<tuoi<<endl;
		}		
};
class TACGIA : public NGUOI{
string tenTP;
string masoTP;
int loaiAP;
int THUONG;
     public:
     	TACGIA()
     	{
		 }
		TACGIA(string tenTP, string masoTP, int loaiAP, string THUONG){
			tenTP=tenTP;
			masoTP=masoTP;
			loaiAP=loaiAP;
			THUONG=THUONG;
		}
		string getTenTP(){
			return tenTP;
		}
		string getMasoTP(){
			return masoTP;
		}
		int getLoaiAP()
		 {
		 	return loaiAP;
		 }
		int getThuong()
		{
			return THUONG;
		}
		void nhap(){
			NGUOI :: nhap();
			cout<<"\nNhap ten tac pham: "; getline(cin,tenTP);
			cout<<"\nNhap ma so tac pham: "; getline(cin,masoTP);
			cout<<"\nNhap loai an pham(1,2,3,4,5): "; cin>>loaiAP;
			cout<<"Nhap giai thuong(VND): ";cin>>THUONG;
		}
		void xuat(){
			NGUOI::xuat();
			cout<<tenTP<<" "<<masoTP<<" "<<loaiAP<<" "<<THUONG<<endl;
		}
};
class Ungdung{
	int n;
	TACGIA *tg;
	public:
		friend istream &operator >>(istream&, Ungdung&);
		void thongkeTienThuong();
		void giaithuongMax();
	 
};
istream &operator >>(istream& Cin, Ungdung&Ud){
	cout<<"Nhap vao so nguoi thi: "; Cin>>Ud.n;
	Ud.tg=new TACGIA[Ud.n];
	for(int i=0;i<Ud.n;i++)
	{
	cout<<"Nhap thi sinh thu "<< i+1<<endl;
	Ud.tg[i].nhap();
}
	return Cin;
}

void Ungdung::thongkeTienThuong()
{
	
			int sum1=0, sum2=0,sum3=0,sum4=0,sum5=0;
			for(int i=0;i<n;i++)
			{
				if(tg[i].getLoaiAP()==1)
				sum1+=tg[i].getThuong();
				if(tg[i].getLoaiAP()==2)
				sum2+=tg[i].getThuong();
				if(tg[i].getLoaiAP()==3)
				sum3+=tg[i].getThuong();
				if(tg[i].getLoaiAP()==4)
				sum4+=tg[i].getThuong();
				if(tg[i].getLoaiAP()==5)
				sum5+=tg[i].getThuong();
			}
	cout<<"\nTong tien thuong AP1 la: "<<sum1;
	cout<<"\nTong tien thuong AP2 la: "<<sum2;
	cout<<"\nTong tien thuong AP3 la: "<<sum3;
	cout<<"\nTong tien thuong AP4 la: "<<sum4;
	cout<<"\nTong tien thuong AP5 la: "<<sum5;
	
}
void Ungdung::giaithuongMax(){
	string name;
	float max=tg[0].getThuong();
	for(int i=0;i<n;i++)
	if(max<tg[i].getThuong())
	{
		max=tg[i].getThuong();
		name=tg[i].getHoten();
	}
	cout<<"\nTac gia co giai thuong max la:"<<name<<endl;	
}
int main()
{
Ungdung ud;
cin>>ud;
ud.thongkeTienThuong();
ud.giaithuongMax();	
}
