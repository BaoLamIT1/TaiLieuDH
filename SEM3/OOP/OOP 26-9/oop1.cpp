
#include<iostream>

      using namespace std;
      class Laptop{
      	string model, hsx;
      	long gia;
      	int tgbh;
      	// ham tao
      	friend istream & operator>>(istream&, Laptop&);
      	friend ostream &operator<<(ostream&, const Laptop&);
      	public:
      		long getgia()
      		{
      			return gia;
			  }
			string gethsx(){
				return hsx;
			}
	  };
istream &operator>>(istream&Cin, Laptop&lap){
	cout<<"nhap model ";Cin>>lap.model;
	cout<<"nhap hsx ";Cin.ignore(1);getline(Cin,lap.hsx);
	cout<<"nhap gia " ; Cin>>lap.gia;
	cout<<"nhap thoi gian bao hanh " ; Cin>>lap.tgbh;
	return Cin;
}
ostream &operator<<(ostream&Cout, const Laptop&lap){
	Cout<<lap.model<<" "<<lap.hsx<<" "<<lap.gia<<" "<<lap.tgbh;
	return Cout;
}
class Ungdung{
	int n;
	Laptop *ds;
	friend istream & operator>>(istream&,Ungdung&);
	friend ostream &operator<<(ostream&,const Ungdung&);
	public:
		void sapxep();
		void timkiem(const long&, const string &);
};
istream & operator>>(istream&Cin, Ungdung&lap){
	cout<<"nhap so luong laptop "; Cin>>lap.n;
	lap.ds=new Laptop[lap.n];
	for(int i=0;i<lap.n;i++)
	{
		cout<<"nhap lap top thu "<<i+1<<endl;
		Cin>>lap.ds[i];
	}
	return Cin;
}
ostream &operator<<(ostream&Cout, const Ungdung&lap){
	for(int i=0;i<lap.n;i++) Cout<<lap.ds[i]<<endl;
	return Cout;
}
void Ungdung ::sapxep(){
	for(int i=0;i<n-1;i++)
	for(int j=i+1;j<n;j++)
	 if(ds[i].getgia()>ds[j].getgia())
	 {
	 	Laptop tem=ds[i]; 
	 	ds[i]=ds[j];ds[j]=tem;
	 }
}
//void timkiem(Ungdung &x, const long &gia, const string&hang){
void Ungdung::timkiem(const long&gia, const string&hang){
	bool kq=false;
	for(int i=0;i<n;i++)
	//if(x.ds[i].getgia()<=gia && x.ds[i].gethsx()==hang){
	 if(ds[i].getgia()<gia &&ds[i].gethsx()==hang)
	 {
	 	kq=true;
	 	cout<<ds[i];  // cout<<x.ds[i]
	 }
	 if(!kq) cout<<"\nk tim thay ket qua";
}
int main() {
Ungdung x;
cin>>x;
x.sapxep(); // sapxep(x)
cout<<x;
long giatim; string hangtim;
cout<<"nhap hang san xuat tim " ;cin.ignore(1);getline(cin,hangtim);
cout<<"Nhap gia tim " ; cin>>giatim;
x.timkiem(giatim,hangtim); // timkiem(x,giatim,hangtim);
}
