
#include <iostream>
  using namespace std;
int search(int a[], int n , int x){
    for(int i=0;i<n;i++){
        if(a[i]==x)
        return i;
    }
    return -1; // ko ton tai tra ve -1
}
int a[100001];
int main(){
    int n,x;  
    cout<<"Nhap so nguyen duong n: ";
	cin>>n;
    for(int i=0;i<n;i++){
    	cout<<"n so nguyen duong lan luot la: "<<"a["<<i<<"]= ";
        cin>>a[i];
    }
    cin>>x;
    cout<<search(a,n,x);
int count =0; for(int i=0;i<n;i++)
{
	if(a[i]==x){
		count++;
	}
}
 cout <<"\nSo phan tu co gia tri bang x la: "<<count;
return 0;
}
