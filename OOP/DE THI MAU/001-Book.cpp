
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class Book{
	int ma;
	string ten, tacgia;
	int namxb;
	string nxb;
	int n;
	public:
		int getMa(){ return ma;
		}
		string getTen(){ return ten;
		}
		string getTacgia(){return tacgia;
		}
		int getNamxb(){return namxb;
	}
	    string getNxb(){return nxb;
		}
		void setTacgia(string tacgia){this->tacgia=tacgia;
		}
		friend istream& operator>>(istream&input,Book&b)
		{
			cout<<"Ma sach:"; input>>b.ma;
			cout<<"\nTen sach: ";input.ignore(1);getline(input,b.ten);
			cout<<"\nTac gia: ";input.ignore(1);getline(input,b.tacgia);
			cout<<"\nNam xuat ban: ";input>>b.namxb;
			cout<<"\nNha xuat ban: ";input.ignore(1);getline(input,b.nxb);
			return input;
		}
		friend ostream&operator<<(ostream&output,const Book&b)
		{
			output<<"Ma sach:"<<b.ma<<" "<<"Ten sach: "<<b.ten<<" "<<"Tac gia: "<<b.tacgia<<" "<<"Nam xuat ban: "<<b.namxb<<" "<<"Nha xuat ban: "<<b.nxb<<endl;
			return output;
		}		
};
class thongke{
	public:
	int n;
	Book *ds;
	friend istream&operator>>(istream&input, thongke&tk)
	{
		cout<<"Nhap so sach:";input>>tk.n;
		tk.ds=new Book[tk.n];
		for(int i=0;i<tk.n;i++)
		{
			cout<<"Nhap sach thu:"<<i+1<<endl;
			input>>tk.ds[i];
		}
		return input;
	}
	friend ostream&operator<<(ostream&output,const thongke&tk)
	{
	for(int i=0;i<tk.n;i++) output<<tk.ds[i]<<endl;
	return output;
	}
	void timkiem(const string&timten)
	{
		bool kq=false;
		for(int i=0;i<n;i++)
		{
			if(ds[i].getTacgia()==timten)
			{
				cout<<ds[i].getTen()<<endl;
				kq=true;
			}
			if(!kq)
			cout<<"K co !";
		}
	}
};    
int main() {
thongke a; cin>>a;
string timten;cout<<"Nhap ten tac gia can tim: ";cin>>timten;
a.timkiem(timten);


}
