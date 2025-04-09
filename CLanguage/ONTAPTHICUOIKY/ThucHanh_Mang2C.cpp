//#include <iostream>
//
//#define MAXCOL 10
//#define MAXROW 10
//
//void nhap(int &n, int &m, int a[][MAXCOL]);
//void xuat(int n, int m, int a[][MAXCOL]);
//
//int main()
//{
//	int n, m, a[MAXROW][MAXCOL];
//	int tong = 0;
//	std::cout << "n = ";
//	std::cin >> n;
//	std::cout << "m = ";
//	std::cin >> m;
//	
//	nhap(n, m, a);
//	xuat(n, m, a);
//
//	/*for (int i = 0; i < n; i++)
//	{
//		for (int j = 0; j < m; j++)
//		{
//			tong += a[i][j];
//		}
//	}
//	
//	std::cout << "\nTong = " << tong;
//
//	
//	std::cout << "\nPhan tu lon nhat cac hang: ";
//	for (int i = 0; i < n; i++)
//	{
//		int max = a[i][0];
//		for (int j = 0; j < m; j++)
//		{
//			if (a[i][j] > max)
//			{
//				max = a[i][j];
//			}
//		}
//		std::cout << max << " ";
//	}*/
//
//
//	for (int i = 0; i < n; i++)
//	{
//		for (int j = 0; j < m; j++)
//		{
//			// (i == 0 || j == 0 || i == n - 1 || j == m - 1)
//			if ((a[i][j] == a[0][j]) || (a[i][j] == a[i][0]) || (a[i][j] == a[i][m - 1]) || (a[i][j] == a[n - 1][j]))
//			{
//				tong += a[i][j];
//			}
//		}
//	}
//
//	std::cout << "Tong la bien: " << tong;
//
//
//	
//
//	return 0;
//}
//
//void nhap(int& n, int &m, int a[][MAXCOL])
//{
//	std::cout << "\nNhap mang: \n";
//	for (int i = 0; i < n; i++)
//	{
//		for (int j = 0; j < m; j++)
//		{
//			std::cout << "a[" << i << "]" << "[" << j << "] = ";
//			std::cin >> a[i][j];
//		}
//	}
//}
//void xuat(int n, int m, int a[][MAXCOL])
//{
//	for (int i = 0; i < n; i++)
//	{
//		for (int j = 0; j < m; j++)
//		{
//			std::cout << a[i][j] << "  ";
//		}
//		printf("\n");
//	}
//}