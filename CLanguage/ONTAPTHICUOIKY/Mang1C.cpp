//#include <iostream>
//
//using namespace std;
//
//
//void tinhPTB1(int a, int b);
//int tinhTong_SoTuNhienLE(int n);
//int KTra_SoNgTo(int n);
//
//void showmenu()
//{
//	printf("\n************************************************************");
//	printf("\n*                          Menu                            *");
//	printf("\n************************************************************");
//	printf("\n* 0. Thoat chuong trinh                                    *");
//	printf("\n* 1. Viet phuong trinh bac nhat mot an (y = ax + b)        *");
//	printf("\n* 2. Nhap so nguyen duong n <= 100                         *");
//	printf("\n* 3. Doi Do F thanh Do C                                   *");
//	printf("\n* 4. Kiem tra so nguyen to                                 *");
//	printf("\n* 5. Nhap so n. Tinh tong cac chu so tao nen chu so do     *");
//	printf("\n************************************************************");
//}
//
//
//void process()
//{
//	int n, a, b, lc;
//	do
//	{
//		showmenu();
//		cout << "\nNhap lua chon : ";
//		cin >> lc;
//		switch (lc)
//		{
//		case 1:
//		{
//			cout << "a = ";
//			cin >> a;
//			cout << "b = ";
//			cin >> b;
//			tinhPTB1(a, b);
//
//		}
//		break;
//		case 2:
//		{
//			do
//			{
//				cout << "\nn = ";
//				cin >> n;
//				if (n < 0)
//					cout << "Khong phai so tu nhien";
//
//			} while (n < 0);
//			cout << "Ket qua la " << tinhTong_SoTuNhienLE(n);
//		}
//		break;
//		case 3:
//		{
//			float kq; 
//			cout << "F = ";
//			cin >> a;
//			kq = (float)(a - 32) / 1.8;
//			cout << "C = " << kq;
//		}
//		break;
//		case 4:
//		{
//			cout << "n = ";
//			cin >> n;
//			if (KTra_SoNgTo(n) == 1)
//				cout << n << " la so nguyen to";
//			else
//				cout << n << " khong la so nguyen to";
//		}
//		break;
//		case 5:
//		{
//			cout << "n = ";
//			cin >> n;
//			int sum = 0;
//			while (n != 0)
//			{
//				sum += n % 10;
//				n /= 10;
//			}
//			cout << "Ket qua la " << sum;
//		}
//		break;
//		}
//	} while (lc != 0);
//}
//
//int main()
//{
//	process();
//}
//
////------------------------------------------------------------
//
//void tinhPTB1(int a, int b)
//{
//	float x; 
//	if (a == 0 && b == 0)
//		cout << "Phuong trinh co vo so nghiem";
//	else if (a == 0 && b != 0)
//		cout << "Phuong trinh vo nghiem";
//	else {
//		x = (float)-b / a;
//		cout << "Nghiem cua phuong trình la " << x;
//	}
//
//}
//
////------------------------------------------------------------
//
//int tinhTong_SoTuNhienLE(int n)
//{
//	int tong = 0;
//	for (int i = 0; i < n; i++)
//	{
//		if (i % 2 != 0)
//			tong += i;
//	}
//	return tong;
//}
//
////------------------------------------------------------------
//
//int KTra_SoNgTo(int n)
//{
//	if (n < 2)
//		return 0;
//	else
//	{
//		for (int i = 2; i < n - 1; i++)
//		{
//			if (n % i == 0)
//				return 0;
//		}
//	}
//	return 1;
//}
//
//
//
//
//
//
//
//
//
//
//
