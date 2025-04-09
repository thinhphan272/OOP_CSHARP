#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>
#include <string.h>
#include <ctype.h>
#include <stdlib.h>

#define MAXROW 10
#define MAXCOL 10

using namespace std;

void NhapSo_NgDuong(int &n);

void showmenu()
{
	printf("\n************************************************************");
	printf("\n*                          Menu                            *");
	printf("\n************************************************************");
	printf("\n* 0. Thoat chuong trinh                                    *");
	printf("\n* 1. Xoa khoang trang dau cuoi                             *");
	printf("\n* 2. Xoa khoang trang thua                                 *");
	printf("\n* 3.                             *");
	printf("\n* 4. Tong so le trong ma tran                              *");
	printf("\n************************************************************");
}

void process()
{
	char str[100];
	
	int luachon;


	do
	{
		showmenu();
		printf("\nNhap lua chon: ");
		NhapSo_NgDuong(luachon);
	
		switch (luachon)
		{
		case 1:
		{
			getchar();
			printf("Nhap chuoi: ");
			
			gets_s(str);

			
			
			
			printf("%s", str);

		}

		break;
		case 2:
		{
			
		}
		break;
		case 3:
		{
			


		}
		break;
		case 4:
		{
			

		}
		break;
		}
	} while (luachon != 0);
}

int main()
{
	process();
}

void NhapSo_NgDuong(int &n)
{
	do
	{
		scanf("%d", &n);
	} while (n < 0);
	
}

