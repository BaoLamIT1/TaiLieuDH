
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;

    class Dathuc{
    	private:
    		int bac;
    		float *hs;
    		public:
    			Dathuc(){
				}
				Dathuc(int bac, float *hs){
					this->bac=bac;
					this->hs=hs;
				}
				~Dathuc()
				{
					bac=0;
					delete hs;
				}
				friend istream&operator>>(istream&input,Dathuc&dt)
				{
					cout<<"\nNhap vao bac cua dathuc:";input>>dt.bac;
					dt.hs=new float[dt.bac+1];
					cout<<"\nNhap vao he so cua dathuc:";
					for(int i=0;i<=dt.bac;i++)
					{
						cout<<"a["<<i<<"]";input>>dt.hs[i];
					}
					return input;
				}
				friend ostream&operator<<(ostream&output,Dathuc&dt)
				{
					for(int i=0;i<=dt.bac;i++)
					cout<<Dt.hs[i];
					return output;
				}
				friend float giaithua(const Dathuc&dt, const int&x)
				{
					float sum=0;
					for(int i=dt.bac;i>=0;i--)
					{
						sum+=dt.hs[i]*pow(x,i);
					}
					return sum;
				}
				Dathuc operator+(Dathuc&);
	};  
int main() {


}
