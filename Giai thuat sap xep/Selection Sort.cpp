#include<stdio.h>
#include<math.h>

void nhap(int a[], int &n)
{
	printf("Nhap n =");
	scanf("%d",&n) ;
	for( int i=0; i<n ; i++) 
	{
		printf("\nNhap phan tu thu a[%d]=",i);
		scanf("%d", &a[i]);
	}
}

void swap(int &x,int&y)
{
	int trunggian=x;
	x=y;
	y=trunggian;
}
void Seletion_Sort(int a[], int n)
{
	int min;
	for(int i = 0; i<n-1;i++)
	{
		min = i;
		for(int j=i+1;j<n;j++)
		{
			if( a[j]< a[min])
			{
				min=j;
			}
			}
			swap(a[min], a[i]);
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
	Seletion_Sort(a,n);
    xuat(a,n);
}
	
 
