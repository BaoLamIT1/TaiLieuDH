/* Lớp cơ sở trừu tượng
Là lớp chứa phương thức thuần ảo và làm cơ sở cho các lớp khác(lớp cơ sở trừu tượng ko baoh có obj)
Virtual Kiểu_hàm tên_hàm(ds_Đối)=0
         Hàm mẫu-Lớp mẫu
Ex: Hãy vt chương trình thực hiện tìm GTLN của 1 dãy n số thức, tìm điểm thi max của n thisinh
  (sbd, hoten,diemthi), tìm khoảng cách xa gốc toạ độ nhất của n điểm cho trc (x,y)

*/
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
      
template <class Type> 
Type TemplateFunctionMax(int n, Type *ds)
//float TemplateFunctionMax(int n, float*ds)
{
	int i;
	Type max=ds[0];
	for(i=0;i<n;i++)
	  if(ds[i]>max) max=ds[i];
	  return max;
}
      
int main() {
int k=4;
int daynguyen[4]={1,3,5,9};
//int max =TemplateFunctionMax(k,daynguyen);
cout<<"\nMax day nguyen: "<<TemplateFunctionMax(k,daynguyen);
float daythuc[4]={1.4,2.5,6.7,12.6};
cout<<"\nMax day thuc: "<<TemplateFunctionMax(k,daythuc);
}
