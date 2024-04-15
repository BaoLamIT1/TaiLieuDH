/* Để cấp 1 thành phần của lớp để thừa kế duy nhất cho các con cháu ta xây dựng lớp cơ sở theo cú pháp:
A->B&C->D 

              class B: public virtual A{};
              class C: public virtual A{ int c; };
              class D: public B, pulic C : public virtual A{};
        Để t phương thức là phương thức ảo thì t thêm virtual ở đầu dòng khai báo
        ex:    class B: public A{
	  	           public:
	  	                virtual	void f(){ cout<<"B\n";} 
	            };
        - Sử dụng phương thức:
                  |          TĨNH                                    |        ẢO
OBJ               |                                              Như nhau
------------------------------------------------------------------------------------------------------------------------------- 
Con trỏ đối tượng |Con trỏ đối tượng của lớp nào thì phthuc của lớp|Con trỏ đt chứa địa chỉ của lớp nào thì phthuc của lớp đó
                           đó sẽ đc gọi                            | sẽ đc gọi 
              
*/
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;

      class A{
    public:
    virtual	void f(){ cout<<"A\n";
		}
	  };
	  class B: public A{
	  	public:
	  		void f(){ cout<<"B\n";
			  }
	  };
	  class C: public virtual B{
	  	public:
	  	    void f(){cout<<"C\n";
		  }
	  };
void dahinh(A *p){
	p->f();
}
int main() {
A *p,a;
B b;
C c;
/*C1:
p=&a; p->f();
p=&b; p->f();
p=&c; p->f();
*/
/*C2:
p=&a;p=&b;p=&c;
a.f(); b.f();c,f();   */
// C3: Đa hình
dahinh(&a);
dahinh(&b);
dahinh(&c);
}



              