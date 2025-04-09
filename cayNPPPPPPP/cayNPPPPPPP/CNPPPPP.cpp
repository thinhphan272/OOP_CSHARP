#include "stdio.h"
#include "conio.h"

struct node
{
	int data;
	node* left;
	node* right;
};

struct cay
{
	node* root;
};

void khoitaocay(cay& t)
{
	t.root = NULL;
}

node* taonut(int x)
{
	node* p = new node;
	if (p == NULL) return NULL;
	p->data = x;
	p->left = p->right = NULL;
	return p;
}

void thenutvaocay(node*& root, node* p)
{
	if (p == NULL) return;
	if (root == NULL)
		root = p;
	else
	{
		if (p->data == root->data) return;
		else
			if (p->data < root->data)
				thenutvaocay(root->left, p);
			else
				thenutvaocay(root->right, p);
	}
}

void taocay(node*& root, int a[], int n) // a la mang so nguyen co n phan tu
{
	for (int i = 0; i < n; i++)
	{
		node* p = taonut(a[i]);
		thenutvaocay(root, p);
	}
}

void duyetcay_LNR(node* root)
{
	if (root == NULL) return;
	duyetcay_LNR(root->left);
	printf("%4d", root->data);
	//getch();
	duyetcay_LNR(root->right);
}

void duyetcay_RNL(node* root)
{
	if (root == NULL) return;
	duyetcay_RNL(root->right);
	printf("%4d", root->data);
	//getch();
	duyetcay_RNL(root->left);
}

void duyetcay_NLR(node* root)
{
	if (root == NULL) return;
	printf("%4d", root->data);
	//getch();
	duyetcay_NLR(root->left);

	duyetcay_NLR(root->right);
}

int tinhchieucaocuacay(node* root)
{
	if (root == NULL || root->left == NULL && root->right == NULL) return 0;
	int nl = 1 + tinhchieucaocuacay(root->left);
	int nr = 1 + tinhchieucaocuacay(root->right);
	return nl > nr ? nl : nr;
}

void xuat_nut_muc_k(node* root, int k)
{
	if (root == NULL) return;
	if (k == 0)
		printf("%4d", root->data);
	else
	{
		xuat_nut_muc_k(root->left, k - 1);
		xuat_nut_muc_k(root->right, k - 1);
	}
}
void xuatcacnut_o_tungmuc(node* root)
{
	int h = tinhchieucaocuacay(root);
	for (int i = 0; i <= h; i++)
	{
		printf("\nCac nut o muc thu %d: ", i);
		xuat_nut_muc_k(root, i);
	}
}

int tinhtonggiatri_cacnuttrongcay(node* root)
{
	if (root == NULL) return 0;
	int sumleft = tinhtonggiatri_cacnuttrongcay(root->left);
	int sumright = tinhtonggiatri_cacnuttrongcay(root->right);
	return root->data + sumleft + sumright;
}

int demsonuttrongcay(node* root)
{
	if (root == NULL) return 0;
	int count_left = demsonuttrongcay(root->left);
	int count_right = demsonuttrongcay(root->right);
	return 1 + count_left + count_right;
}

int demnutla(node* root)
{
	if (root == NULL) return 0;
	if (root->left == NULL && root->right == NULL) return 1;
	int count_left = demnutla(root->left);
	int count_right = demnutla(root->right);
	return count_left + count_right;
}

void timnut_themang(node* p, node*& rf, node*& f) //p la nut can xoa, rf la nut the mang, f la nut cha cua rf
{
	f = p;
	rf = p->left;
	while (rf->right != NULL)
	{
		f = rf;
		rf = rf->right;
	}
}

void timnutcha_cua_nutP(node* root, node* p, node*& fp)
{
	if (p == root)
		return;
	if (p->data < root->data)
	{
		fp = root;
		timnutcha_cua_nutP(root->left, p, fp);
	}
	else
	{
		fp = root;
		timnutcha_cua_nutP(root->right, p, fp);
	}
}

node* tim_x(node* root, int x)
{
	if (root == NULL) return NULL;
	else
		if (x == root->data) return root;
		else
			if (x < root->data)
				return tim_x(root->left, x);
			else
				return tim_x(root->right, x);
}

void xoa_nut_x_trongcay(node*& root, int x)
{
	node* p = tim_x(root, x);
	if (p == NULL)
		printf("\nKhong tim thay nut can xoa");
	else
	{
		node* fp, * f, * rf;
		timnutcha_cua_nutP(root, p, fp);
		if (p->left == NULL && p->right == NULL)
		{
			if (fp->left == p)
				fp->left = NULL;
			else
				fp->right = NULL;
			delete p;
		}
		else
			if (p->left != NULL && p->right == NULL)
			{
				if (fp->left == p)
					fp->left = p->left;
				else
					fp->right = p->left;
				delete p;
			}
			else
				if (p->left == NULL && p->right != NULL)
				{
					if (fp->left == p)
						fp->left = p->right;
					else
						fp->right = p->right;
					delete p;
				}
				else
				{
					timnut_themang(p, rf, f);
					if (f != p)
					{
						f->right = rf->left;
						p->data = rf->data;
					}
					else
					{
						p->left = rf->left;
						p->data = rf->data;
					}
					delete rf;
				}
	}
}

void main()
{
	cay t;
	khoitaocay(t);
	int a[] = { 7, 4, 9, 10, 5, 3, 1, 2, 8, 6 };
	int n = 10;
	taocay(t.root, a, n);

	printf("\nDuyet cay theo thu tu LNR: \n");
	duyetcay_LNR(t.root);
	/*
	printf("\nDuyet cay theo thu tu RNL: \n");
	duyetcay_RNL(t.root);
	printf("\nDuyet cay theo thu tu NLR: \n");
	duyetcay_NLR(t.root);
	printf("\nChieu cao cua cay: %d", tinhchieucaocuacay(t.root));
	xuatcacnut_o_tungmuc(t.root);
	printf("\nTong gia tri cac nut trong cay: %d", tinhtonggiatri_cacnuttrongcay(t.root));
	printf("\nSo nut co trong cay: %d", demsonuttrongcay(t.root));
	printf("\nSo nut la co trong cay: %d", demnutla(t.root));
	*/
	node* f, * rf, * p;
	//timnut_themang(t.root, rf, f);
	//printf("\nrf = %d, f = %d", rf->data, f->data);
	/*
	int x = 5;
	p = tim_x(t.root, x);
	if (p != NULL)
	{
		printf("\nTim thay %d", x);
		node* fp = NULL;
		timnutcha_cua_nutP(t.root, p, fp);
		if (fp == NULL)
		{
			printf("\n===="); return;
		}
		printf("\nfp = %d", fp->data);
	}
	else
		printf("\nKhong tim thay %d", x);
		*/
	int x = 7;
	xoa_nut_x_trongcay(t.root, x);
	printf("\nDu lieu cay sau khi xoa %d: ", x);
	duyetcay_LNR(t.root);
	_getch();
}