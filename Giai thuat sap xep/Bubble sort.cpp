
#include<iostream>
#include<bits/stdc++.h>
      using namespace std;
void printArray(int a[], int n){
	for (int i = 0; i < n; i++){
		cout << a[i] << " ";
	}
}
void bubbleSort(int arr[], int n)
{
    int i, j;
    for (i = 0; i < n - 1; i++)
        for (j = 0; j < n - i - 1; j++)
            if (arr[j] > arr[j + 1])
                swap(arr[j], arr[j + 1]);
}
int a[100001];
int main(){
	int n; cout<<"Nhap vao so phan tu cua day: ";
	cin >> n;
	for (int i = 0; i < n; i++){
		cout<<"a["<<i<<"]= ";
		cin >> a[i];
	}
	bubbleSort(a, n);
	printArray(a, n);
	
	return 0;
}
