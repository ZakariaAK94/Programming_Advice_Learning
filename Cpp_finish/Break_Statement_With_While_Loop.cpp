#include <iostream>
using namespace std;

int main()
{
	int sum = 0, i=1;
	int Number;
	while (i<=5)
	{
		cout << "Please enter the number " << i << endl;
		cin >> Number;
		i++;
		if (Number > 50)
		{
			continue;
		}
		sum += Number;
		
	}
	cout << "The sum is " << sum << endl;

	return 0;
}