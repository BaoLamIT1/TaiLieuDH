#include<bits/stdc++.h>
#include"tree.cpp"
using namespace std;
//Tao class SV
class SVs{
	int MSV, tuoi;
	string name, lop;
	public:
		friend istream& operator >> (istream&, SVs&);
		friend ostream& operator << (ostream&, const SVs&);
		friend bool operator != (SVs a, SVs b){
			if(a.getMSV()==b.getMSV()) return 0;
			return 1;
		}
		int getMSV(){
			return this->MSV;
		}
		string getName(){
			return this->name;
		}
		int getTuoi(){
			return this->tuoi;
		}
		string getLop(){
			return this->lop;
		}
		void setName(string name){
			this->name = name;
		}
		void setMSV(int MSV){
			this->MSV = MSV;
		}
		void setLop(string lop){
			this->lop = lop;
		}
		void setTuoi(int tuoi){
			this->tuoi = tuoi;
		}
};
istream& operator >> (istream& is, SVs &a){
	cout<<"\nTen SV: ";
	cin.ignore();
	getline(cin, a.name);
	cout<<"MSV: ";
	cin>>a.MSV;
	cout<<"Lop: ";
	cin.ignore();
	getline(cin, a.lop);
	cout<<"Tuoi: ";
	cin>>a.tuoi;
	return is;
}
ostream& operator << (ostream& os, const SVs& a){
	cout<<"Ten SV: "<<a.name<<"; "<<"MSV: "<<a.MSV<<"; "<<"Lop: "<<a.lop<<"; "<<"Tuoi: "<<a.tuoi<<endl;
}
//Nhap
void INPUT(int &n, int &k, SVs *&ds){
	ifstream input("D:\\BTLfinal\\input.txt");
	string x;
	int a;
	input>>k;
	for(int i=n; i<n+k; i++){
		input.ignore();
		getline(input, x);
		ds[i].setName(x);
		input>>a;
		ds[i].setMSV(a);
		input.ignore();
		getline(input, x);
		ds[i].setLop(x);
		input>>a;
		ds[i].setTuoi(a);
	}	
}
//Xuat
void OUTPUT(int n, SVs *ds){ 
	ofstream output("D:\\BTLfinal\\output.txt"); 
	for(int i=0; i<n; i++){ 
		output<<"SV"<<i+1<<endl; 
		output<<"Ten SV: "<<ds[i].getName()<<endl; 
		output<<"MSV: "<<ds[i].getMSV()<<endl; 
		output<<"Lop: "<<ds[i].getLop()<<endl; 
		output<<"Tuoi: "<<ds[i].getTuoi()<<endl; 
	}
}
//Them SV
void ADD(int &n, int &k, SVs *&ds){
	cin>>k;
	for(int i=n; i<n+k; i++){
		cout<<"Nhap TT SV";
		cin>>ds[i];
	}	
}
//Cap nhat thong tin SV
template <class T>
void UPDATE(node<T> *root){
	string a, b;
	int c, x;
	cin>>x;
	cout<<"Ten SV: ";
	cin.ignore();
	getline(cin, a);
	cout<<"Lop: ";
	getline(cin, b);
	cout<<"Tuoi: ";
	cin>>c;
	changeE(root, x, a, b, c);
}
//Xoa SV
template <class T>
void DELETE(node<T> *root){
	int x;
	cin>>x;
	remove(root, x);
}
//Tim kiem SV
template <class T>
void SEARCH(node<T> *root){
	int x;
	cin>>x;
	print(root, x);
}
//Menu
int Menu(){
	cout<<"=================MENU================";
	cout<<"\nNhap lua chon cua ban";
	cout<<"\n1.Doc danh sach SV tu tep";
	cout<<"\n2.Them SV";
	cout<<"\n3.Xoa SV";
	cout<<"\n4.Cap nhat thong tin SV";
	cout<<"\n5.Tim kiem SV";
	cout<<"\n6.Hien thi danh sach SV";
	cout<<"\n7.Xuat danh sach SV";
	cout<<"\n8.Thoat"<<endl;
	cout<<"=====================================\n";
}
int ChonMenu(){
	int n;
	cout<<"Moi chon menu: ";
	cin>>n;
	if (n>0&&n<9)
		return n;
	else{
		cout<<"Ban da chon sai hay chon lai\n";
		return ChonMenu();
	} 
}
template <class T>
int Process(int n, int k, SVs *ds, node<T> *root){
	while(true){
		int z = ChonMenu();
		switch(z){
			case 1:{
				cout<<"Doc danh sach SV...";
				INPUT(n, k, ds);				
				for(int i=n; i<n+k; i++){
					update(root, ds[i]);
				}	
				n+=k;			
				cout<<"Successful!\n";
				break;
			}
			case 2:{
				cout<<"Them SV";
				cout<<"\nNhap so luong SV: ";
				ADD(n, k, ds);
				for(int i=n; i<n+k; i++){
					update(root, ds[i]);
				}
				n+=k;
				break;
			}
			case 3:{
				cout<<"Xoa SV";
				cout<<"\nNhap MSV: ";
				DELETE(root);
				break;
			}
			case 4:{
				cout<<"Cap nhat TT SV";
				cout<<"\nNhap MSV: ";
				UPDATE(root);
				break;
			}
			case 5:{
				cout<<"Tim kiem SV";
				cout<<"\nNhap MSV: ";
				SEARCH(root);
				break;
			}
			case 6:{
				cout<<"Danh sach SV\n";
				inorder(root);
				cout<<endl;
				break;
			}
			case 7:{
				cout<<"Xuat danh sach SV...";
				OUTPUT(n, ds);
				cout<<"Successful!\n";
				break;
			}
			case 8:{
				cout<<"Da ket thuc chuong trinh!";
				exit(0);
				break;
			}
		}
	}
}
int main(){
	int k, n = 0;
	SVs *ds;
	ds = new SVs[1000000];
	node<SVs> *root = 0;
	Menu();
	Process(n, k, ds, root);
	delete [] ds;
	return 0;
}

