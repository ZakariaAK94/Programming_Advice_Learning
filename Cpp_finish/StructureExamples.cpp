#include <iostream>
using namespace std;

struct PersInformations
{
	char name[50];
	int CitNo;
	float Salary;
};

enum Color {Red=100, Green=200, Blue=300, Grey=400};
enum Post{Operator, Saler,HR,Manager, Engineer, Director};
enum Status{Married, Single, Divorced};
enum ChildrenSt{Yes, No};

int main()
{
	PersInformations User01;
	Color test01;
	Post test02;
	Status test03;
	ChildrenSt test04;

	test01 = Color::Red;
	test02 = Post::Engineer;
	test03 = Status::Married;
	test04 = ChildrenSt::No;


	cout << "Please enter your name:" << endl;
	cin >> User01.name;
	cout << "Please enter your citizenship number:" << endl;
	cin >> User01.CitNo;
	cout << "Please enter your salary :" << endl;
	cin >> User01.Salary;
	cout << "these are your informations :" << endl;
	cout << " Your name is :" << User01.name << endl;
	cout << " Your citizenship number is :" << User01.CitNo << endl;
	cout << " Your salary is :" << User01.Salary << endl;
	cout << test01 << endl;
	cout << test02 << endl;
	cout << test03 << endl;
	cout << test04 << endl;

	return 0;
}