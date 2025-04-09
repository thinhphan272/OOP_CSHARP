//#include <stdio.h>
//#include <conio.h>
//#define MAXSIZE 100
//#include <queue>
//using namespace std;
//
//struct node
//{
//    int info;
//    node* left;
//    node* right;
//};
//
//
//
//
//
//node* makenode(int x);
//node* findnode(node* root, int x);
//int insertBtree(node*& root, int x);
//void showNLR(node* root);
//void initbtree(node*& root);
//int deleteBtree(node*& root);
//int countBtree(node*& root, int& dem);
//int countNodela(node*& root);
//void duyettheochieurong(node* root);
//int sumofnodeBtree(node* root);
//
//
//int main()
//{
//    node* root;
//    initbtree(root);
//    int x, n, dem = 0;
//    printf("\nNhap so phan tu muon them: ");
//    scanf_s("%d", &n);
//    for (int i = 1; i <= n; i++)
//    {
//        printf("Nhap vao so nguyen x: ");
//        scanf_s("%d", &x);
//        insertBtree(root, x);
//    }
//    printf("\n\tDuyet cay theo chieu rong: \n");
//    duyettheochieurong(root);
//    printf("\nTong so nut tren cay: %d", sumofnodeBtree(root));
//    //        50 
//    //      /    \
//          30      70
//    //   /  \    /  \
//    //  20  40  60  90
//    return 0;
//}
//
//int sumofnodeBtree(node* root)
//{
//    if (root == NULL)
//        return 0;
//    else
//        return (sumofnodeBtree(root->left) + sumofnodeBtree(root->right) + root->info);
//}
//
//void duyettheochieurong(node* root)
//{
//    if (root == NULL)
//        return;
//    queue<node*> a;
//    a.push(root);
//    while (!a.empty())
//    {
//        node* q = a.front();
//        printf("\t%d ", q->info);
//
//        if (q->left != NULL)
//            a.push(q->left);
//        if (q->right != NULL)
//            a.push(q->right);
//        a.pop();
//    }
//}
//
//int countNodela(node*& root)
//{
//    if (root == NULL)
//        return 0;
//    if (root->left == NULL && root->right == NULL)
//        return 1;
//    else
//        return countNodela(root->left) + countNodela(root->right);
//}
//
//int countBtree(node*& root, int& dem)
//{
//    if (root != NULL)
//    {
//        dem++;
//        countBtree(root->left, dem);
//        countBtree(root->right, dem);
//
//    }
//    return dem;
//
//}
//
//int deleteBtree(node*& root)
//{
//    if (root == NULL)
//        return 0;
//    deleteBtree(root->left);
//    deleteBtree(root->right);
//    deleteBtree(root);
//    return 1;
//}
//
//void showNLR(node* root)
//{
//    if (root != NULL)
//    {
//        printf("%4d", root->info);
//        showNLR(root->left);
//        showNLR(root->right);
//    }
//
//}
//
//int insertBtree(node*& root, int x)
//{
//    if (root == NULL)
//    {
//        root = makenode(x);
//        return 0;
//    }
//    if (root->info == x)
//        return 0;
//    if (x < root->info)
//        insertBtree(root->left, x);
//    else
//        insertBtree(root->right, x);
//    return 1;
//}
//
//node* findnode(node* root, int x)
//{
//    if (root == NULL)
//        return NULL;
//    if (root->info == x)
//        return root;
//    else if (root->info > x)
//        return findnode(root->left, x);
//    else
//        return findnode(root->right, x);
//}
//
//node* makenode(int x)
//{
//    node* p = new node;
//    if (p == NULL)
//        return NULL;
//    p->info = x;
//    p->left = NULL;
//    p->right = NULL;
//    return p;
//}
//
//void initbtree(node*& root)
//{
//    root = NULL;
//}