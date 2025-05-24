//Phuong thuc tinh
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class Math{
	public:
		static int max(int a, int b){
			return a>b ? a:b;
		}
		static int min(int a, int b){
			return a<b ? a:b;
		}
};
      
int main() {
 cout << Math :: max(2,3) <<endl;
 cout<< Math :: min(3,2) <<endl;
 return 0;

}

/*class Math{
	public:
	   double PI =3.14;
		static double getPI(){
			return PI;
		}
};
     
int main(){
	cout<< Math::getPI();
	return 0;
}
// ==> Loi bien dich do getPI la phuong thuc static ma bien PI khong phai la bien static 
*/
