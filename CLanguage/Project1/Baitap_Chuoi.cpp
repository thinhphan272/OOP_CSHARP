#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	int n;
	cout << "n = ";
	cin >> n;

	
	for (int i = 1	; i <= n; i++)
	{
		if (i % 5 == 0)
			cout << i << " ";
	}
		
	return 0;
}