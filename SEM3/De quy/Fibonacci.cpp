#include<iostream>
    using namespace std;
long long fibonacci(int n){
    if(n==1 || n==2) return 1;
    return fibonacci(n-1)+ fibonacci(n-2);
}
int main(){
    int n;
    cin>>n;
    cout<<"Day gom " <<n<<" so Fibonacci la: ";
    for(int i=1;i<=n;i++)
    cout<<0<<" "<<fibonacci(i) <<" ";
    cout<<"\nSo fibonacci thu " <<n<<" la:"<<fibonacci(n);
    return 0;
}