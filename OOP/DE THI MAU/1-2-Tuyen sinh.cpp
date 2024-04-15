
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;

      class Tuyensinh{
    
    public:
    	int sbd;
    string hoten;
    int diem;
    	int getsbd()
    	{
    		return this->sbd;
		}
		string getTen()
		{
			return this->hoten;
		}
		int getDiem()
		{
			return this->diem;
		}
		void setSBD(int sbd){
			this->sbd=sbd;
		}
		void setDiem(int diem)
		{
			this->diem=diem;
		}
		void setHoten(string hoten){
			this->hoten=hoten;
		}
	  };
	  class Olympic:public Tuyensinh{
	  	string truong;
	  	public:
	  		string getTruong(){
	  			return truong;
			  }
	  		friend istream&operator>>(istream&input, Olympic&ol)
	  		{
	  			//int sbd;
	  			//string hoten;
	  			//int diem;
				//fflush(stdin);
	  			cout<<"Nhap sbd:";input>>ol.sbd;
	  			//ol.setSBD(sbd);
	  			cout<<"Nhap hoten:";input>>ol.hoten;
	  			//ol.setHoten(hoten);
	  			cout<<"Nhap diem:";input>>ol.diem;
				  //ol.setDiem(diem);
	  			cout<<"Nhap truong(A,B,C): ";input>>ol.truong;
	  			return input;
			  }
	  	    friend ostream&operator<<(ostream&output,const Olympic&ol)
	  	    {
	  	    	output<<ol.sbd<<" "<<ol.hoten<<" "<<ol.diem<<" "<<ol.truong<<endl;
	  	    	return output;
			  }
	  };
	  class App{
	  	int n;
	  	Olympic *ds;
	  	public:
	  		friend istream&operator>>(istream&Cin,App&app)
	  		{
	  			cout<<"Nhap so thi sinh: ";cin>>app.n;
	  			app.ds=new Olympic[app.n];
	  			for(int i=0;i<app.n;i++){
	  				cout<<"Nhap thi sinh thu"<<i+1<<endl;
	  				cin>>app.ds[i];
				  }
				  return Cin;
			}
			friend ostream &operator<<(ostream &Cout,const App &app)
			{
	            for(int i=0;i<app.n;i++){
		         cout<<app.ds[i];
	             }   
	            return Cout;
            }
	void tongdiem()
	{
		int sum1=0,sum2=0,sum3=0;
		for(int i=0;i<n;i++)
		{
			if(ds[i].getTruong()=="A")
			{
				sum1+=ds[i].getDiem();
			}
			if(ds[i].getTruong()=="B")
			{
				sum2+=ds[i].getDiem();
			}
			if(ds[i].getTruong()=="C")
			{
				sum3+=ds[i].getDiem();
			}
		}
	cout<<"\nTong diem truong A la: "<<sum1;
	cout<<"\nTong diem truong B la: "<<sum2;
	cout<<"\nTong diem truong C la: "<<sum3;
	
	if(sum1>sum2 ) 
	{
		if(sum1>sum3)
	cout<<"\nTruong A co tong diem lon nhat";
	else 
	cout<<"\nTruong C co tong diem lon nhat";
	}
	else{
		if(sum2>sum3) cout<<"\nTruong B co tong diem lon nhat";
		else 
		cout<<"\nTruong C co tong diem lon nhat";
				
		}	
	  }
	
	void DiemMax()
	{
		int tong=0;
		int max=ds[0].getDiem();
		for(int i=1;i<n;i++)
		if(ds[i].getDiem()>max)
		{
			max=ds[i].getDiem();
		}
		cout<<"\nDiem so cao nhat la:"<<endl;
		for(int i=0;i<n;i++)
		if(ds[i].getDiem()==max)
		{
			cout<<max;
			tong++;
			cout<<"\nSo thi sinh co diem"<<max<<"la:"<<tong;
		}
	}
	  
	  
	  
};
int main() {
App a;
cin>>a;
cout<<a;
a.tongdiem();
a.DiemMax();
}
