#include <iostream>
using namespace std;
 
class PhanSo
{
private:
    int tu, mau;
public:
    void set(int t, int m)
    {
        tu = t;
        mau = m;
    }
 
    void nhap()
    {
        cout << "Nhap lan luot tu va mau cua phan so : ";
        cin >> tu >> mau;
    }
    void xuat()
    {
        cout << tu << "/" << mau << endl;
    }
    void cong(PhanSo a)
    {
        tu = tu*a.mau + mau*a.tu;
        mau = mau*a.mau;
    }
    void tru(PhanSo a)
    {
        tu = tu*a.mau - mau*a.tu;
        mau = mau*a.mau;
    }
    void nhan(PhanSo a)
    {
        tu = tu*a.tu;
        mau = mau*a.mau;
    }
    void chia(PhanSo a)
    {
        tu = tu*a.mau;
        mau = mau*a.tu;
    }
};
 
int main()
{
    PhanSo a, b, c;
    a.nhap();
    b.nhap();
    //////////////////
    cout << "Cong = ";
    c = a;
    c.cong(b);
    c.xuat();
    //////////////////
    cout << "Tru = ";
    c = a;
    c.tru(b);
    c.xuat();
    //////////////////
    cout << "Nhan = ";
    c = a;
    c.nhan(b);
    c.xuat();
    //////////////////
    cout << "chia = ";
    c = a;
    c.chia(b);
    c.xuat();
 
    system("pause");
    return 0;
}