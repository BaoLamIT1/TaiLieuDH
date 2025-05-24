
#include<iostream>
using namespace std;
class laptop{
	string model, brand;
		long cost;
		int insurance;
	//ham tao
	friend istream & operator >>(istream&,laptop&);
	friend ostream & operator <<(ostream&, const laptop&);
public: long getcost()
	{
		return cost;
	}
	string getbrand()
	{
		return brand;
	}
};
istream & operator >>(istream & Cin , laptop&lap)
{
		cout<<"nhap model ";Cin>>lap.model;
	cout<<"nhap hang san xuat: "; Cin.ignore(1); getline(Cin,lap.brand);//nhap chuot co dau cach
	cout<<"nhap gia: ";Cin>>lap.cost;
	cout<<"nhap thoi gian bao hanh: "; Cin>>lap.insurance;
	return Cin;
}
ostream &operator<<(ostream&Cout, const laptop&lap)
{
	Cout<<lap.model<<" "<<lap.brand<<" "<<lap.cost<<" "<<lap.insurance;
	return Cout;
}
class ungdung{

    friend istream &operator >>(istream&,ungdung&);
	friend ostream &operator <<(ostream&, const ungdung&);
	public:
		int n;
		laptop *ds;
		void sapxep();
		void timkiem(const long&, const string &);
};  
istream & operator>>(istream&Cin , ungdung&lap)
{
	cout<<"nhap so laptop "; cin>>lap.n;
	lap.ds= new laptop[lap.n];
	for (int i=0;i<lap.n;i++)
	{
		cout<<"nhap laptop thu " <<i+1<<endl;
		Cin>>lap.ds[i];
	}
	return cin;
}
ostream & operator <<(ostream &Cout, const ungdung&lap){
	for(int i=0;i<lap.n;i++) Cout<<lap.ds[i]<<endl;
	return Cout;
}
void ungdung::sapxep(){
	for(int i=0;i<n-1;i++)
	for(int j=i+1;j<n;j++)
	 if(ds[i].getcost()>ds[j].getcost())
	 {
	 	laptop tem=ds[i];ds[i] =ds[j]=tem;
	 }
}
void ungdung::timkiem(const long&cost, const string &brand){
	bool kq=false;
	for(int i=0;i<n;i++)
	 if(ds[i].getcost()<cost && ds[i].getbrand()==brand)
	  {
	  	kq=true;
		cout<<ds[i];
	  }
	  if(!kq) cout<<"\n k tim thay hang";
}
int main() {
ungdung ud;
cin>> ud;
ud.sapxep();
cout<<ud;
long findcost; string findbrand;
cout<<"nhap hang san xuat tim "; cin.ignore(1); getline(cin,findbrand);
cout<<"nhap gia tim " ; cin>>findcost;
ud.timkiem(findcost,findbrand);


}
