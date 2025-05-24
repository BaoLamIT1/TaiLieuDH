#include<iostream>
  using namespace std;
long long exponent(int a, int b){
       if(b==0) return 1;
       return a*exponent(a,b-1);
}
int main()
{
    int a,b;
    cin>>a>>b;
    cout<<exponent(a,b);
    return 0;
}
