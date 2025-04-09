#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>
#include <conio.h>
#include <time.h>
#include <cctype>
#include <stdlib.h>

#define MAXCOL 100
#define MAXROW 100

typedef int ItemType;

int a[MAXROW][MAXCOL];
int b[MAXROW][MAXCOL];

void input_interger(int& n);
void showmenu(); void process();
void input_2D_Array(ItemType a[][MAXCOL], int &n, int &m);
void input_2D_Array_Random(ItemType a[][MAXCOL], int& n, int& m);
void output_2D_Array(ItemType a[][MAXCOL], int& n, int& m);

void sum_2D_Array(ItemType a[][MAXCOL], ItemType b[][MAXCOL], int& n, int& m);


void process()
{
	int choice, n, m;
	do
	{
		showmenu();
		printf("\nNhap lua chon: ");
		input_interger(choice);
		
		switch (choice)
		{
		case 1:
		{
			printf("INPUT LOAD RANDOM MATRIX: ");
			input_2D_Array_Random(a, n, m);
			printf("OUTPUT RANDOM MATRIX: \n");
			output_2D_Array(a, n, m);

		}
		break;
		case 2:
		{
			printf("INPUT MATRIX: \n");
			input_2D_Array(a, n, m);
			printf("\nOUTPUT MATRIX: \n");
			output_2D_Array(a, n, m);
		}
		break;
		case 3:
		{
			printf("INPUT MATRIX A: \n");
			input_2D_Array(a, n, m);
			printf("INPUT MATRIX B: \n");
			input_2D_Array(b, n, m);
			printf("OUTPUT SUM OF MATRIX A AND MATRIX B: \n");
			sum_2D_Array(a, b, n, m);
			
		}
		break;
		}

	} while (choice != 0);
}


int main()
{

	process();
}

void showmenu()
{
	printf("\n=======================================================");
	printf("\n=                                                     =");
	printf("\n=======================================================");
	printf("\n= 1. RANDOM MATRIX                                    =");
	printf("\n= 2. INPUT AND OUTPUT OF THE MATRIX                   =");
	printf("\n= 3. SUM OF 2 MATRIX                                  =");
	printf("\n=======================================================");
	
}

void input_interger(int& n)
{
	do
	{
		scanf("%d", &n);
	} while (n < 0);
}

void input_2D_Array(ItemType a[][MAXCOL], int& n, int& m)
{
	printf("INPUT MATRIX ROW: ");
	input_interger(n);
	printf("INPUT MATRIX COLUMN: ");
	input_interger(m);
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			scanf("%d", &a[i][j]);
		}
	}
}

void input_2D_Array_Random(ItemType a[][MAXCOL], int& n, int& m)
{
	printf("INPUT MATRIX ROW: ");
	input_interger(n);
	printf("INPUT MATRIX COLUMN: ");
	input_interger(m);
	int x = 99, y = -99;
	srand(time(NULL));
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			a[i][j] = rand() % (x - y + 1) + y;
		}
	}
}

void output_2D_Array(ItemType a[][MAXCOL], int& n, int& m)
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			printf("%4d", a[i][j]);
		}
		printf("\n");
	}
}

void sum_2D_Array(ItemType a[][MAXCOL], ItemType b[][MAXCOL], int& n, int& m)
{
	int c[MAXROW][MAXCOL];
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			c[i][j] = a[i][j] + b[i][j];
		}
	}

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			printf("%4d", c[i][j]);
		}
		printf("\n");
	}
}



