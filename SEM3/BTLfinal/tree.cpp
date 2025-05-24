#include<bits/stdc++.h>

using namespace std;

template <class T>
struct node{
	T elem;
	node *left, *right;
	node<T> (T e){
		elem = e;
		left = right = 0;
	}
};
template <class T>
void update(node<T> *&H, T x){
	bool check = 1;
	if(!H){
		H = new node<T>(x);
	} 
	else if(x!=H->elem){
		update(x.getMSV()<H->elem.getMSV()?H->left:H->right, x);
	}
	else{
		check = 0;
	}
	if(!check){
		cout<<"Da ton tai MSV "<<x.getMSV()<<endl;
	}
	return;
}
template <class T>
void inorder(node<T> *H, string p="\n"){
	if(H){
		inorder(H->left, p+"\t");
		cout<<p;
		cout<<H->elem;
		inorder(H->right, p+"\t");
	}
}
template <class T>
T Max(node<T> *H){
	return H->right?Max(H->right):H->elem;
}
template <class T>
void remove(node<T> *&H, int x){
	if(!H){
		cout<<"Khong tim thay SV\n";
		return;
	} 
	if(H->elem.getMSV()!=x) return remove(x<H->elem.getMSV()?H->left:H->right,x);
	if(!H->left) H=H->right;
	else if(!H->right) H=H->left;
	else
	{
		H->elem=Max(H->left);
		remove(H->left,H->elem.getMSV());
	}
}
template <class T>
node<T> *search(node<T> *H, int x){
	if(!H||H->elem.getMSV()==x) return H;
	return H->elem.getMSV()>x?search(H->left, x):search(H->right, x);
}
template <class T>
void print(node<T> *H, int x){
	node<T> *temp = search(H, x);
	if(temp==NULL){
		cout<<"Khong tim thay SV\n";
	}
	else{
		H = temp;
		cout<<H->elem;
	}
}
template <class T>
void changeE(node<T> *&H, int x, string a, string b, int c){
	node<T> *temp = search(H, x);
	if(temp == NULL){
		cout<<"Khong tim thay SV\n";
	}
	else{
		H = temp;
		H->elem.setName(a);
		H->elem.setLop(b);
		H->elem.setTuoi(c);
	}
}
