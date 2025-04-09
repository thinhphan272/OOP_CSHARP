#include <iostream>

#define MAXCOL 10
#define MAXROW 10

using namespace std;

void nhap(int n, int a[]);
void xuat(int n, int a[]);
void Bubble_Sort(int n, int a[]);
void Ktra_2Ptu_TongBang_K(int n, int k, int a[]);
void NhapSo_NgDuong(int& n);

void nhap_mang2C(int& n, int& m, int a[][MAXCOL]);
void xuat_mang2C(int n, int m, int a[][MAXCOL]);

void tong_2Matran(int& n, int& m, int mt1[][MAXCOL], int mt2[][MAXCOL]);
int Tong_SoLe_MTran(int& n, int& m, int a[][MAXCOL]);

void showmenu()
{
	printf("\n************************************************************");
	printf("\n*                          Menu                            *");
	printf("\n************************************************************");
	printf("\n* 0. Thoat chuong trinh                                    *");
	printf("\n* 1. Sap xep mang 1 chieu giam dan                         *");
	printf("\n* 2. Kiem tra 2 phan tu tong = k                           *");
	printf("\n* 3. Tong hai ma tran                                      *");
	printf("\n* 4. Tong so le trong ma tran                              *");
	printf("\n************************************************************");
}

void process()
{
	int luachon, k, m, n;
	int a[100], mt1[MAXROW][MAXCOL], mt2[MAXROW][MAXCOL];


	do
	{
		showmenu();
		cout << "\nNhap lua chon: ";
		NhapSo_NgDuong(luachon);
		switch (luachon)
		{
		case 1:
		{
			cout << "n = ";
			cin >> n;
			cout << "Nhap mang: \n";
			nhap(n, a);
			cout << "\nMang sau khi sap xep: ";
			Bubble_Sort(n, a);
			xuat(n, a);

		}

		break;
		case 2:
		{
			cout << "n = ";
			NhapSo_NgDuong(n);
			cout << "Nhap mang: \n";
			nhap(n, a);
			cout << "k = ";
			NhapSo_NgDuong(k);
			cout << "Ket qua = ";
			Ktra_2Ptu_TongBang_K(n, k, a);
		}
		break;
		case 3:
		{
			cout << "n = ";
			NhapSo_NgDuong(n);
			cout << "m = ";
			NhapSo_NgDuong(m);

			cout << "Nhap ma tran 1: \n";
			nhap_mang2C(n, m, mt1);
			cout << "Nhap ma tran 2: \n";
			nhap_mang2C(n, m, mt2);
			cout << "Tong 2 ma tran: \n";
			tong_2Matran(n, m, mt1, mt2);


		}
		break;
		case 4:
		{
			cout << "n = ";
			NhapSo_NgDuong(n);
			cout << "m = ";
			NhapSo_NgDuong(m);
			cout << "Nhap ma tran: \n";
			nhap_mang2C(n, m, mt1);
			xuat_mang2C(n, m, mt1);
			cout << "Tong cac so le la: " << Tong_SoLe_MTran(n, m, mt1);
			
		}
		break;
		}
	} while (luachon != 0);
}

int main()
{
	process();
}

void NhapSo_NgDuong(int& n)
{
	do
	{
		cin >> n;
	} while (n < 0);
}


//-----------------------------------------------------------
void nhap(int n, int a[])
{
	for (int i = 0; i < n; i++)
	{
		;
		cout << "Nhap phan tu thu a[" << i << "] = ";
		cin >> a[i];
	}
}
void xuat(int n, int a[])
{
	cout << "\nNoi dung cua mang la: ";
	for (int i = 0; i < n; i++)
	{
		cout << a[i] << " ";
	}
}
//-----------------------------------------------------------
void Bubble_Sort(int n, int a[])
{
	for (int i = n - 1; i > 0; i--)
	{
		for (int j = 0; j < i; j++)
		{
			if (a[j] < a[j + 1])
			{
				int tmp = a[j];
				a[j] = a[j + 1];
				a[j + 1] = tmp;
			}
		}
	}
}
//-----------------------------------------------------------
void Ktra_2Ptu_TongBang_K(int n, int k, int a[])
{
	int x = -1, y = -1;
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			if (i != j && (a[i] + a[j]) == k)
			{
				x = i;
				y = j;
				break;
			}
		}
		if (x != -1 && y != -1)
			break;
	}
	if (x != -1 && y != -1)
		cout << "Ket qua: " << x << " " << y;
	else
		cout << "Khong co 2 phan tu nao trong mang co tong = " << k;
}
//-----------------------------------------------------------
void nhap_mang2C(int& n, int& m, int a[][MAXCOL])
{
	std::cout << "\nNhap mang: \n";
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			std::cout << "a[" << i << "]" << "[" << j << "] = ";
			std::cin >> a[i][j];
		}
	}
}
void xuat_mang2C(int n, int m, int a[][MAXCOL])
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			std::cout << a[i][j] << "  ";
		}
		printf("\n");
	}
}

void tong_2Matran(int& n, int& m, int mt1[][MAXCOL], int mt2[][MAXCOL])
{

	for (int i = 0; i < n; i++)
	{	
		for (int j = 0; j < m; j++)
		{
			cout << mt1[i][j] + mt2[i][j] << " ";

		}
		cout << endl;
	}
}

int Tong_SoLe_MTran(int& n, int& m, int a[][MAXCOL])
{
	int tong = 0;
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			if (a[i][j] % 2 != 0)
				tong += a[i][j];
		}
	}
	return tong;
}