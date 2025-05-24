
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
      
class MTV{
	int **tp;
	int n; 
	friend istream & operator >>(istream &, MTV&);
	friend ostream & operator <<(ostream &, const MTV&);
	public : MTV operator *(const MTV&);
};
istream & operator >>(istream & cin, MTV& A){
      	cout<<"Nhap co ma tran ";
      	 cin>> A.n;
      	 A.tp= (int **) new int [A.n*A.n];
      	 for (int i =0; i<A.n;i++){
      	 	 A.tp[i] = new int [A.n]; for (int j=0;j<A.n;j++)
      	 	 {
      	 	 	cout<<"Nhap tp "<<i<<j<<": "; cin >>A.tp[i][j];
				}
		   }
		   return cin;
	  }
ostream & operator <<(ostream & cout, const MTV&A){
	  for(int i =0; i<A.n;i++)
	  {
	  	for(int j=0;j<A.n;j++)
	  	 cout<<A.tp[i][j] <<"\t";
	  	 cout<<endl;
	  }
	  return cout ;
}
 MTV MTV :: operator *(const MTV &B){
 	MTV A,C;
 	int min; A.this;
 	C.n=(A.n >B.n)? A.n:B.n;
 	min=(A.n >B.n)? A.n:B.n;
 	C.tp=(int **) new int [C.n*min];
 	if(min ==A.n)
 	{
 		for(int i=0; i<C.n;i++)
 		{
 			C.tp[i] = new int [C.n];
 			for( int j=0;j<C.n;j++)
 			{
 				C.tp[i][j] =0;
 				  for ( int k; k<min;k++)
 				    C.tp[i][j] +=A.tp[i][k]; *B.tp[k][j];
			 }
		 }
	 }
 }
int main() {
 MTV A,B;
 cout<<"Nhap ma tran A \n" ; cin>> A;
 cout<<"Nhap ma tran B\n" ; cin>>B;
 cout<<"\nMa tran thu nhat : \n";
cout<<A;
cout<<"\nMa tran thu hai : \n";
cout<<B;

}
