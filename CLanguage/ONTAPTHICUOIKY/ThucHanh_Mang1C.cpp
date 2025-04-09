//#include <iostream>
//
//using namespace std;
//
//void nhap(int n, int a[]);
//void xuat(int n, int a[]);
//void Bubble_Sort(int n, int a[]);
//
//
//int main()
//{
//	int n, a[20], x, y;
//	cout << "Nhap so phan tu trong mang: ";
//	cin >> n;
//	nhap(n, a);
//	xuat(n, a);
//
//	/*cout << "\nNhap phan tu muon them vao cuoi mang: ";
//	cin >> x;
//
//	a[n] = x;
//	n++;
//
//	cout << "Mang sau khi them phan tu vao cuoi: ";
//	xuat(n, a);
//
//	cout << "\nNhap vi tri muon xoa phan tu: ";
//	cin >> x;
//
//	for (int i = x; i < n; i++)
//	{
//		a[i] = a[i + 1];
//	}
//	n--;
//
//	cout << "\nMang sau khi xoa phan tu bat ki ";
//	xuat(n, a);*/
//	Bubble_Sort(n, a);
//	cout << "\nMang sap xep tang dan: ";
//	xuat(n, a);
//
//	/*cout << "\nNhap vi tri muon them: ";
//	cin >> x;
//	cout << "\nNhap gia tri muon them: ";
//	cin >> y;
//
//	for (int i = n; i > x; i--)
//	{
//		a[i] = a[i - 1];
//	}
//
//	a[x] = y;
//	n++;
//
//	cout << "\nMang sau khi them " << y << " vao vi tri " << x;
//	xuat(n, a);*/
//
//	return 0;
//
//}
//
//void nhap(int n, int a[])
//{
//	for (int i = 0; i < n; i++)
//	{
//		;
//		cout << "Nhap phan tu thu a[" << i << "] = ";
//		cin >> a[i];
//	}
//}
//void xuat(int n, int a[])
//{
//	cout << "\nNoi dung cua mang la: ";
//	for (int i = 0; i < n; i++)
//	{
//		cout << a[i] << " ";
//	}
//}
//
//void Bubble_Sort(int n, int a[])
//{
//	for (int i = n - 1; i > 0; i--)
//	{
//		for (int j = 0; j < i; j++)
//		{
//			if (a[j] > a[j + 1])
//			{
//				int tmp = a[j];
//				a[j] = a[j + 1];
//				a[j + 1] = tmp;
//			}
//		}
//	}
//}
//
