#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>
#include <time.h>

typedef int ItemType;
typedef ItemType *MaTran;


typedef struct 
{
	char Ma_thuoc[6];
	char Ten_thuoc[21];
	char Nha_SX[21];
	char Dang_thuoc[11];
	float Don_Gia;
	char Cong_Dung[51];		

}TT_Thuoc;

//--------------------------------------------

void int_Input(int& n);
void Nhap_TT_Thuoc(TT_Thuoc &thuoc);
void Xuat_TT_Thuoc(TT_Thuoc thuoc);
void Nhap_DS_Thuoc(TT_Thuoc ds[], int n);
void Xuat_DS_Thuoc(TT_Thuoc ds[], int n);

void Int_Input2DArray(MaTran*& a, int& n, int& m);
void Int_Output2DArray(MaTran*& a, int& n, int& m);
void init_Array(MaTran*& a, int& n, int& m);
void delete_Array(MaTran*& a, int& n, int& m);
void intput_2DArray_random(MaTran*& a, int& n, int& m);



//========================================================

void showmenu()
{
	printf("\n*************************************************");
	printf("\n*                      Menu                     *");
	printf("\n*************************************************");
	printf("\n*                                               *");
	printf("\n*                                               *");
	printf("\n*                                               *");
	printf("\n* Bai 4                                         *");
	printf("\n*                                               *");
	printf("\n*************************************************");
}

//========================================================

void process()
{
	int n, m, luachon;
	MaTran *a = NULL;
	TT_Thuoc x[10];

	do
	{
		showmenu();
		printf("\nNhap lua chon: ");
		int_Input(luachon);
		switch (luachon)
		{
		case 1:
		{
			Int_Input2DArray(a, n, m);
			printf("\nNoi dung cua mang: \n");
			Int_Output2DArray(a, n, m);
			
		}
		break;
		case 2:
		{
			intput_2DArray_random(a, n, m);
			Int_Output2DArray(a, n, m);
		}
		break;
		case 3:
		{

		}
		break;
		case 4:
		{
			printf("\nNhap so nha thuoc: ");
			int_Input(n);
			getchar();
			Nhap_DS_Thuoc(x, n);
			Xuat_DS_Thuoc(x, n);
		}
		break;
		}
	} while (luachon != 0);
	delete_Array(a, n, m);
}

//========================================================

int main()
{
	process();
}

//--------------------------------------------

void int_Input(int& n)
{
	do
	{
		scanf_s("%d", &n);
	} while (n < 0);
}

//========================================================

void Nhap_TT_Thuoc(TT_Thuoc& thuoc)
{
	printf("\nNhap ma thuoc: ");
	gets_s(thuoc.Ma_thuoc);
	printf("\nNhap ten thuoc: ");
	gets_s(thuoc.Ten_thuoc);
	printf("\nNha san xuat: ");
	gets_s(thuoc.Nha_SX);
	printf("\nDang thuoc: ");
	gets_s(thuoc.Dang_thuoc);
	printf("\nDon gia: ");
	scanf_s("%f", &thuoc.Don_Gia);
	printf("\nCong dung: ");
	getchar();
	gets_s(thuoc.Cong_Dung);

}

void Xuat_TT_Thuoc(TT_Thuoc thuoc)
{
	printf("\n%4s | %10s | %10s | %10s | %.2f | %20s", thuoc.Ma_thuoc, thuoc.Ten_thuoc, thuoc.Nha_SX, thuoc.Dang_thuoc, thuoc.Don_Gia, thuoc.Cong_Dung);
}

//========================================================

void Nhap_DS_Thuoc(TT_Thuoc ds[], int n)
{
	for (int i = 0; i < n; i++)
	{
		printf("\nNhap thong tin thuoc thu %d", i + 1);
		Nhap_TT_Thuoc(ds[i]);
	}
}

//========================================================

void Xuat_DS_Thuoc(TT_Thuoc ds[], int n)
{
	for (int i = 0; i < n; i++)
	{
		Xuat_TT_Thuoc(ds[i]);
	}
}

//========================================================

void init_Array(MaTran*& a, int& n, int& m)
{
	a = new MaTran[m * sizeof(ItemType)];
	for (int i = 0; i < n; i++)
	{
		a[i] = new ItemType[n * sizeof(ItemType)];
	}
}

void delete_Array(MaTran*& a, int& n, int& m)
{
	for (int i = 0; i < n; i++)
	{
		delete a[i];
	}
}
//========================================================
void Int_Input2DArray(MaTran*& a, int& n, int& m)
{
	printf("\nNhap so hang cua ma tran: ");
	int_Input(n);
	printf("\nNhap so cot cua ma tran: ");
	int_Input(m);
	init_Array(a, n, m);
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			printf("Nhap a[%d][%d]", i , j );
			scanf("%d", &a[i][j]);
		}
	}
}

void Int_Output2DArray(MaTran*& a, int& n, int& m)
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			printf(" %4d ", a[i][j]);
		}
		printf("\n");
	}
}

//========================================================

void intput_2DArray_random(MaTran*& a, int& n, int& m)
{
	printf("\nNhap so hang cua ma tran: ");
	int_Input(n);
	printf("\nNhap so cot cua ma tran: ");
	int_Input(m);
	init_Array(a, n, m);
	srand((unsigned)time(NULL));
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			ItemType tmp;
			int x = -50, y = 50;
			tmp = rand() % (y - x + 1) + x;
			a[i][j] = tmp;

		}
	}
}

//========================================================


//========================================================
