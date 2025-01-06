#include <iostream>
#include<math.h>
#include<string>
using namespace std;

enum enFormula { ByDepthAndWidth = 1, ByLengthAndHeigth=2 , ByDepthAndDiagonal=3, ByCircleRadious =4, ByCircleDiameter=5, ByCirclecircumference=6 };
struct stRectangle
{
	float Length;
	float Width;
};
enFormula ChoiceTheFormula()
{
	int choice;
	cout << "Which formula do you like to use to caluculate the Area :" << endl;
	cout << "(1) Area of the rectangle By Using Depth and Width." << endl;
	cout << "(2) Area of the triangle By Using length and heigth." << endl;
	cout << "(3) Area of the rectangle By Using Depth and Diagonal." << endl;
	cout << "(4) Area of the cercle By Using CircleRadious." << endl;
	cout << "(5) Area of the cercle By Using CircleDiameter." << endl;
	cout << "(6) Area of the cercle By Using CircleCircumference." << endl;
	cout << "----------------------------------------" << endl;
	cin >> choice;
	return (enFormula)choice;
}

/* the formula 1 is calculate the area of rectangle ByDepthAndWidth */
stRectangle ReadRectangleParameters()
{
	stRectangle Rectangle;
	cout << "Please enter the length of your rectangle :" << endl;
	cin >> Rectangle.Length;
	cout << "Please enter the length of your rectangle :" << endl;
	cin >> Rectangle.Width;
	cout << "**********************************************" << endl;
	return Rectangle;

}
float CalculateAreaOfRectangle(stRectangle Rectangle)
{
	return (float) Rectangle.Length * Rectangle.Width;
}
/* the formula 2 is calculate the area of rectangle BylengthAndHeigth */
void ReadInformationsTriangle(float& length, float& heigth)
{
	cout << "Please enter the length of your triangle :" << endl;
	cin >> length;
	cout << "Please enter the heigth of your triangle :" << endl;
	cin >> heigth;
	cout << "*********************************************" << endl;
}
float CalculateTheAreaOfTriangle(float length, float heigth)
{
	ReadInformationsTriangle(length, heigth);
	return (float)(length * heigth) / 2;
}
/* the formula 3 is calculate the area of rectangle ByDepthAndDiagonal */
void ReadInformationsRectangle(float& depth, float& diagonal)
{
	cout << "Please enter the depth of your rectangle :" << endl;
	cin >> depth;
	cout << "Please enter the diagonal of your rectangle :" << endl;
	cin >> diagonal;
	cout << "*********************************************" << endl;
}
float CalculateTheAreaOfRectangle(float depth, float diagonal)
{
	ReadInformationsRectangle(depth, diagonal);
	return (float)(depth * sqrt(pow(diagonal, 2) - pow(depth, 2)));
}
/* the formula 4 is calculate the area of cercle ByRadious */
void ReadInformationsCercleByRadious(float& Radious)
{
	cout << "Please enter the radious of your cercle :" << endl;
	cin >> Radious;
	cout << "*********************************************" << endl;
}
float CalculateTheAreaOfCercleByRadious(float Radious)
{
	const float PI = 3.14159;
	ReadInformationsCercleByRadious(Radious);
	return (float)(PI * pow(Radious, 2));
}
/*  the formula 5 is calculate the area of cercle ByDiameter */
void ReadInformationsCercleByDiameter(float& Diameter)
{
	cout << "Please enter the diameter of your cercle :" << endl;
	cin >> Diameter;
	cout << "*********************************************" << endl;
}
float CalculateTheAreaOfCercleByDiameter(float Diameter)
{
	const float PI = 3.14159;
	ReadInformationsCercleByDiameter(Diameter);
	return (float)(PI * pow(Diameter/2, 2));
}
/* the formula 6 is calculate the area of cercle Bycircumference */
void ReadInformationsCercleByCircumference(float& Circumference)
{
	cout << "Please enter the circumference of your cercle :" << endl;
	cin >> Circumference;
	cout << "*********************************************" << endl;
}
float CalculateTheAreaOfCercleByCircumference(float Circumference)
{
	const float PI = 3.14159;
	ReadInformationsCercleByCircumference(Circumference);
	return (float)(pow(Circumference, 2) / (4*PI));
}
/* formula to be choisen */
float ApplyOfFormula(enFormula Choice)
{
	float depth=0, diagonal=0, length=0, heigth=0, Radious=0, PI, Diameter=0, Circumference=0;            /*why I have to initialize these variables*/
	if (Choice == enFormula::ByDepthAndWidth)
	{
		return  CalculateAreaOfRectangle(ReadRectangleParameters());
	}
	else if (Choice == enFormula::ByLengthAndHeigth)
	{
		return CalculateTheAreaOfTriangle(length,heigth);
	}
	else if (Choice == enFormula::ByDepthAndDiagonal)
	{
		return CalculateTheAreaOfRectangle(depth, diagonal);
	}
	else if (Choice == enFormula::ByCircleRadious)
	{
		return CalculateTheAreaOfCercleByRadious(Radious);
	}
	else if (Choice == enFormula::ByCircleDiameter)
	{
		return CalculateTheAreaOfCercleByDiameter(Diameter);
	}
	else
	{
		return CalculateTheAreaOfCercleByCircumference(Circumference);
	}

}
void PrintResult(float Result)
{
    cout << "The area is : " << Result << endl;
}
/*Main function*/
int main()
{
	float depth=0, diagonal=0, length=0, heigth=0;
     PrintResult(ApplyOfFormula(ChoiceTheFormula()));
   return 0;
}

