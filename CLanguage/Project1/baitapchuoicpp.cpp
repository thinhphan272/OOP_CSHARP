#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <time.h>
#include <string.h>

#define MAXSIZE 100
//Khai bao kieu du lieu cua bien
typedef char ItemType;
//Khai bao cac ham
void nhapSoNguyenDuong(int &n);
void nhapChuoiKyTu(ItemType strIn[]);
void loadChuoiKyTu(ItemType strIn[], char tenFile[]);
void xuatChuoiKyTu(ItemType strIn[]);
void hoanVi(ItemType &x, ItemType &y);
void SapXep_Chuoi_TangDan(ItemType strIn[]);

void toUpper(ItemType &ch);
void toLower(ItemType &ch);
void MyProper(ItemType strIn[]);
int checkString_AllNum(ItemType strIn[]);


//==========================================================
//Ham menu
void showMenu()
{
	printf("\n================================================");
	printf("\n=                     MENU                     =");
	printf("\n================================================");
	printf("\n= 0. Thoat chuong trinh                        =");
	printf("\n= 1. Nhap chuoi                                =");
	printf("\n= 2. Nhap chuoi tu File                        =");
	printf("\n= 3. Xuat chuoi                                =");
	printf("\n= 4. Sap xep chuoi tang dan                    =");
	printf("\n= 5. Doi ki tu dau thanh chu IN HOA            =");
	printf("\n= 6. Check chuoi toan so                       =");
	printf("\n= 7. Chuan hoa chuoi                           =");
	printf("\n================================================");
}
//==========================================================
//Ham thuc hien cac chuc nang
void process()
{
	char f[] = "dulieu_Chuoi.txt";
	ItemType strIn[MAXSIZE];

	int luachon;
	do
	{
		showMenu();
		printf("\nBan hay chon mot chuc nang: ");
		nhapSoNguyenDuong(luachon);
		switch (luachon)
		{
		case 1:
		{
				  nhapChuoiKyTu(strIn);
				  printf("\nNOI DUNG CUA CHUOI VUA NHAP LA: \n");
				  xuatChuoiKyTu(strIn);
		}
			break;
		case 2:
		{
				  loadChuoiKyTu(strIn, f);
				  printf("\nNOI DUNG CUA CHUOI VUA NHAP TU FILE LA: \n");
				  xuatChuoiKyTu(strIn);
		}
			break;
		case 3:
		{
				  printf("\nNOI DUNG CUA CHUOI: \n");
				  xuatChuoiKyTu(strIn);
		}
			break;
		case 4:
		{
				  SapXep_Chuoi_TangDan(strIn);
				  printf("\nNOI DUNG CUA CHUOI VUA SAP XEP TANG DAN: \n");
				  xuatChuoiKyTu(strIn);
		}
			break;
		case 5:
		{
				  MyProper(strIn);
				  printf("\nNOI DUNG CUA CHUOI VUA IN HOA CHU CAI DAU: \n");
				  xuatChuoiKyTu(strIn);
		}
		case 6:
		{
				  if (checkString_AllNum(strIn) == 1)
				  {
					  xuatChuoiKyTu(strIn);
					  printf(" la chuoi toan so.");
				  }
				  else
				  {
					  xuatChuoiKyTu(strIn);
					  printf(" khong la chuoi toan so");
				  }
			break;
		}
		case 7:
		{

		}
		}
	} while (luachon != 0);
}
//==========================================================
//Ham main
int main()
{
	process();
}

//==========================================================
//Ham nhap so nguyen duong
void nhapSoNguyenDuong(int &n)
{
	do
	{
		scanf_s("%d", &n);
		if (n < 0)
		{
			printf("Ban hay nhap mot so nguyen duong!");
		}
	} while (n < 0);

}

//==========================================================
//Ham nhap CHUOI
void nhapChuoiKyTu(ItemType strIn[])
{
	printf("Nhap chuoi ky tu bat ki: ");
	fflush(stdin);
	fgets(strIn, sizeof(MAXSIZE), stdin);
}

//==========================================================
//Ham nhap CHUOI tu file
void loadChuoiKyTu(ItemType strIn[], char tenFile[])
{
	FILE *fi = fopen_s(tenFile, "rt");
	if (!fi)
	{
		printf("Loi mo file %s", tenFile);
		_getch();
		return;
	}
	fgets(strIn, sizeof(strIn)* MAXSIZE, fi);
	fclose(fi);

}

//==========================================================
//Ham xuat CHUOI
void xuatChuoiKyTu(ItemType strIn[])
{
	printf("%s", strIn);
}

//==========================================================
//Ham hoan vi
void hoanVi(ItemType &x, ItemType &y)
{
	ItemType tmp;
	tmp = x;
	x = y;
	y = tmp;

}

//==========================================================
//Ham sap xep tang dan (Interchange Sort)
void SapXep_Chuoi_TangDan(ItemType strIn[])
{
	for (int i = 0; strIn[i] != '\0'; i++)
	{
		for (int j = i + 1; strIn[j] != '\0'; j++)
		{
			if (strIn[i] > strIn[j])
			{
				hoanVi(strIn[i], strIn[j]);
			}
		}
	}
}

//==========================================================

void toUpper(ItemType &ch)
{
	if (ch >= 'a' && ch <= 'z') ch -= 32;
}

//==========================================================
//
void toLower(ItemType &ch)
{
	if (ch >= 'A' && ch <= 'Z') ch += 32;
}

//==========================================================
void MyProper(ItemType strIn[])
{
	toUpper(strIn[0]);
	for (int i = 1; strIn[i] != '\0'; i++)
	{
		if (strIn[i] == ' ')
			toUpper(strIn[i + 1]);
		else
			toLower(strIn[i + 1]);
	}
}

//==========================================================

int checkString_AllNum(ItemType strIn[])
{
	for (int i = 1; strIn[i] != '\0'; i++)
	{
		if (strIn[i] < '0' || strIn[i] > '9')
			return 0;
	}
	return 1;
}

//==========================================================
