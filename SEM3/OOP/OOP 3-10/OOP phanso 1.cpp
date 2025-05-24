
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
	   class PhanSo {
    private: int tu, mau;
    PhanSo(){
        tu=0;mau =1;
    }
    PhanSo(int t, int m){
        tu =t; mau =m;
    }
 
    public: int getTu() {
        return tu;
    }
    public: int getMau() {
        return mau;
    }
      public: 
	String (){
        return tu + "/" +mau;
    }
    public: int uCLN(int a, int b){
        while(a!=b)
            if(a>b) a = a-b;
            else b=b-a;
        return a;
    }
    private: void rutGon(){
        if(tu*mau!=0){
            int t = uCLN(Math.abs(tu),Math.abs(mau));
            tu = tu/t; mau =mau/t;
        }
    }
    public: PhanSo cong(PhanSo b){
           PhanSo c = new PhanSo();
           c.tu = tu*b.mau + mau*b.tu;
           c.mau = mau*b.mau;
           c.rutGon();
           return c;
    }
    public: PhanSo tru(PhanSo b){
           PhanSo c = new PhanSo();
           c.tu = tu*b.mau - mau*b.tu;
           c.mau = mau*b.mau;
           c.rutGon();
           return c;
    }   
    public: PhanSo nhan(PhanSo b){
           PhanSo c = new PhanSo();
           c.tu = tu*b.tu;
           c.mau = mau*b.mau;
           c.rutGon();
           return c;
    }
    public: PhanSo chia(PhanSo b){
           PhanSo c = new PhanSo();
           c.tu = tu*b.mau ;
           c.mau = mau*b.tu;
           c.rutGon();
           return c;
    }
};
