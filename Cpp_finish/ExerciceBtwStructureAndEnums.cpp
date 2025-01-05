#include <iostream>
using namespace std;

enum enGendor { Male, Female};
enum enColor { Red, Green, Yellow, Blue};
enum enMaritalStatus { Single, Married};

struct stAddress
{
	string StreetName;
	string BuildingNo;
	string POBox;
	string ZipCode;
};

struct stContactInfo
{
	string Phone;
	string Email;
	stAddress Address;
};

struct stPerson
{
	string FirstName;
	string LastName;
	stContactInfo ContactInfo;

	enMaritalStatus MaritalStatues;
	enGendor Gendor;
	enColor FavourateColor;
};

int main()
{
	stPerson Person01;
	Person01.FirstName = "Zakaria";
	Person01.LastName = "AKIL";
	Person01.FavourateColor = enColor::Green;
	Person01.Gendor = enGendor::Male;
	Person01.MaritalStatues = enMaritalStatus::Single;
	Person01.ContactInfo.Phone = "0628495742";
	Person01.ContactInfo.Email = "akilzakaria02@gmail.com";
	Person01.ContactInfo.Address.BuildingNo = " Bulding 27 BIS";
	Person01.ContactInfo.Address.StreetName = "HAY NAHDA 2";
	Person01.ContactInfo.Address.ZipCode = "12 000";

	cout << Person01.LastName << endl;

	return 0;
}















