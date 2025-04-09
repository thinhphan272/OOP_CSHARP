#include <stdio.h>
#include <conio.h>

struct node
{
	int data;
	node* left;
	node* right;
};

struct btree
{
	node* root;
};

void initBtree(btree& bt);
node* createnode(int x);
void insertBtree(node*& root, node* p);
void createBtree(node*& root, int a[], int n);
void showBtreeLNR(node* root);

int main()
{
	btree bt;
	initBtree(bt);
	int a[] = { 7 , 4, 9, 10, 5, 3, 1, 2, 8, 6 };
	int n = 10;
	createBtree(bt.root, a, n);
	showBtreeLNR(bt.root);

	_getch();
}

void showBtreeLNR(node* root)
{
	if (root != NULL)
	{
		showBtreeLNR(root->left);
		printf("%4d", root->data);
		showBtreeLNR(root->right);
	}
}

void createBtree(node*& root, int a[], int n)
{
	for (int i = 0; i < n; i++)
	{
		node* p = createnode(a[i]);
		insertBtree(root, p);
	}
}

void insertBtree(node*& root, node* p)
{
	if (p == NULL)
		return;
	if (root == NULL)
		root = p;
	else
	{
		if (p->data == root->data)
			return;
		else
			if (p->data < root->data)
				insertBtree(root->left, p);
			else
				insertBtree(root->right, p);
	}
}

void initBtree(btree& bt)
{
	bt.root = NULL;
}

node* createnode(int x)
{
	node* p = new node;
	if (p == NULL)
		return NULL;
	p->data = x;
	p->left = p->right = NULL;
	return p;
}