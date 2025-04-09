#define _CRT_SECURE_NO_WARNINGS

#define MAXROW 100
#define MAXCOL 100
typedef int ItemType;



void Nhap(ItemType a[][MAXCOL], int& n, int& m);


int main()
{

	
}

void Nhap(ItemType a[][MAXCOL], int& n, int& m)
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			scanf("%d", &a[i][j]);
		}
	}
}