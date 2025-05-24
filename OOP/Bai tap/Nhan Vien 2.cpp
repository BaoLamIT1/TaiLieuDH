#include<bits/stdc++.h>
using namespace std;
/*
Xây dựng lớp cơ sở NhanVien(mã, ht; và các phương thức cần thiết); 
Xây dựng lớp dẫn xuất BienChe của lớp NhanVien bổ sung them thuộc tính: 
Số năm công tác, hệ số lương; phương thức tính lương và các phương thức cần thiết.
Viết chương trình nhập thông tin cho n nhân viên trong biên chế. 
Tính lương bình quân của nhân viên; Tìm nhân viên có số năm công tác nhiều nhất. Tìm nhân viên có tên cho trước.
Biết rằng lương=HSL*LCB+ phụ cấp; phụ cấp là 10 nếu snct>10 năm; 7: <5snct<=10; còn lại thì phụ cấp là 3 triệu
*/

const long LTB=1490;
class NhanVien{
	string ht;
	string ma;
	public:
		string getHT(){
			return this->ht;
		}
		
		void setHT(string ht){
			this->ht=ht;
		}
		
		string getMa(){
			return this->ma;
		}
		
		void setMa(string ma){
			this->ma=ma;
		}
};

class BienChe:public NhanVien{
	int soNamCT;
    float heSoLuong;
	public:
		friend istream &operator>>(istream &,BienChe&);
		friend ostream &operator<<(ostream &, BienChe&);
		float tinhLuong(){
			float phuCap;
			if(soNamCT>10){
				phuCap=10000;
			}else if(soNamCT<=10 && soNamCT>5){
				phuCap=7000;;
			}else{
				phuCap=3000;
			}
			return heSoLuong*LTB+phuCap;
		}
		
		float getHSL(){
			return heSoLuong;
		}
		
		int getNamCT(){
			return soNamCT;
		}
};


istream&operator>>(istream &Cin,BienChe &bc){
	string ht;
	string ma;
	fflush(stdin);
	cout<<"nhap ho ten :";getline(Cin,ht);
	bc.setHT(ht);
	fflush(stdin);
	cout<<"nhap ma nhan vien :";getline(Cin,ma);
	bc.setMa(ma);
	cout<<"nhap so nam cong tac :";Cin>>bc.soNamCT;
	cout<<"nhap he so luong :";Cin>>bc.heSoLuong;
	
	return Cin;
}

ostream &operator<<(ostream &Cout,BienChe &bc){
	Cout<<bc.getHT()<<" "<<bc.getMa()<<" "<<bc.getNamCT()<<" "<<bc.getHSL()<<endl;
	return Cout;
}


class App{
	int n;
	BienChe *p;
	public:
		friend istream &operator>>(istream &,App &);
		friend ostream &operator<<(ostream &,const App &);
		void timNhanVien(){
			string hoTenCanTim;
			fflush(stdin);
			cout<<"nhap ten nhan vien can tim :";getline(cin,hoTenCanTim);
			bool tk=false;
			for(int i=0;i<n;i++){
				if(p[i].getHT()==hoTenCanTim){
					cout<<p[i];
					tk=true;
				}
			}
			
			if(tk==false){
				cout<<"khong co nhan vien can tim!"<<endl;	
			}
		}
		
		float tinhLuongBinhQuan(){
			float luongTong=0;
			for(int i=0;i<n;i++){
				luongTong+=p[i].tinhLuong();
			}
			
			return luongTong/n;
		}
		
		void NhanVienCTLauNhat(){
			int max=p[0].getNamCT();
			for(int i=1;i<n;i++){
				if(p[i].getNamCT()>max){
					max=p[i].getNamCT();
				}
			}
			cout<<"nhan vien co so nam cong tac lau nhat la :"<<endl;
			for(int i=0;i<n;i++){
				if(p[i].getNamCT()==max){
					cout<<p[i];
				}
			}
		}
		
		void NhanVienHSLThapNhat(){
			int min=p[0].getHSL();
			for(int i=1;i<n;i++){
				if(p[i].getHSL()<min){
					min=p[i].getHSL();
				}
			}
			cout<<"nhan vien co he so luong thap nhat la :"<<endl;
			for(int i=0;i<n;i++){
				if(p[i].getHSL()==min){
					cout<<p[i];
				}
			}
		}
		
		void sapXepTheoLuong(){
			for(int i=0;i<n-1;i++){
				for(int j=i+1;j<n;j++){
					if(p[i].tinhLuong()<p[j].tinhLuong()){
						swap(p[i],p[j]);
					}
				}
			}
			
			cout<<"nhan vien sau khi sap xep theo luong giam dan la :"<<endl;
			for(int i=0;i<n;i++){
					cout<<p[i];
			}
		}
};

istream &operator>>(istream &Cin,App &app){
	cout<<"nhap so nhan vien :";Cin>>app.n;
	app.p=new BienChe[app.n];
	
	for(int i=0;i<app.n;i++){
		cin>>app.p[i];
	}
	
	return Cin;
}

ostream &operator<<(ostream &Cout,const App &app){
	for(int i=0;i<app.n;i++){
		cout<<app.p[i];
	}
	return Cout;
}

int main(){
	
	App a;
	cin>>a;
	cout<<a;
	a.timNhanVien();
	cout<<"luong binh quan la:"<<a.tinhLuongBinhQuan()<<endl;
	a.NhanVienCTLauNhat();
	a.NhanVienHSLThapNhat();
	a.sapXepTheoLuong();

}


