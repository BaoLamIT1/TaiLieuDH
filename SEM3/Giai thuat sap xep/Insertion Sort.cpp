#include<stdio.h>
#include<math.h>
void nhap( int a[], int n)
{
	printf("Nhap n=");
	scanf("%d",&n);
	for( int i=0;i<n;i++)
	{
		printf("\nNhap phan tu thu a[%d]",i);
		scanf("%d",&a[i]);
	}
}	

void Insertion_Sort(int a[], int n)
{
	int pos,i;
	int x;
	for( i=1;i<n;i++)
	{
		x=a[i];
		pos=i-1;
		while((pos >=0 && (a[pos]>x))) 
		{
			a[pos+1]=a[pos];
			pos=pos-1;
		}
		a[pos+1]=x;
	}
}
void xuat(int a[], int n)
{
	for(int i = 0 ; i<n ; i++)
	printf("%5d", a[i]);
	printf("\n");
}
int main()
{
	int a[10];
	int n ;
	nhap(a,n);
	Insertion_Sort(a,n);
    xuat(a,n);
    return 0;
}
