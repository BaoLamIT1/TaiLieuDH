#include<stdio.h>
#include<math.h>
int nhap(int a[], int &n)
{
	printf("\nNhap n =");
	scanf("%d",&n);
	int i ;
	for( i =0 ; i<n; i++)
	{
		printf("\nNhap phan tu thu a[%d]=",i);
		scanf("%d", &a[i]);
	}
}
void Bubble_Sort( int a[], int n)
{
	int i,j;
	for( i =0; i< n -1 ; i++)
	{
		for (j=n-1; j>i ; j--)
		{
			if( a[j] < a[j-1])
			{ 
			int trunggian= a[j];
			   a[j] = a[j-1];
			   a[j-1]= trunggian;
			}
		}
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
	xuat(a,n);
	Bubble_Sort(a,n);
    xuat(a,n);
}

