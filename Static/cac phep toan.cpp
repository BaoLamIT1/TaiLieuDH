/*abs(x: int) là hàm trả về giá trị tuyệt đối của số x.
add(x: int, y: int) là hàm trả về tổng 2 số x và y.
subtract(x: int, y: int) là hàm trả về hiệu 2 số x và y.
min(x: int, y: int) là hàm trả về số nhỏ nhất trong 2 số.
max(x: int, y: int) là hàm trả về số lớn nhất trong 2 số.
pow(x: int, y: int) là hàm trả về xy.
*/
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
class Math{
	public:
		static int abs(int x){
		 return x <0 ? -x:x;
		}
		static int add(int x,int y){
			return x+y;
		}
		static int subtract(int x,int y){
			return x-y;
		}
		static int max(int x,int y){
			return x>y ?x:y;
		}
		static int min(int x, int y){
			return x<y ? x:y;
		}
		static int pow(int x, int y){
			int pow =1;
			for(int i=0;i<y;i++){
				pow *=x;
			}
			return pow;
		}
};
int main(){
	cout<< Math :: abs(-2) <<endl;
	cout<< Math :: add(5,4) <<endl;
	cout<< Math :: subtract(6,3)<<endl;
	cout<< Math :: max(1,6)<<endl;
	cout<< Math :: min(6,10)<<endl;
	cout<< Math :: pow(3,5)<<endl;
	return 0;
	
}


