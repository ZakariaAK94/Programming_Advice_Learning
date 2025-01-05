#include <iostream>
#include <cstdlib>

using namespace std;

enum enLevelOfQst { Easy = 1, Med = 2, Hard = 3, Mix1 = 4 };
enum enTypeOfOpert { Add = 1, Sub = 2, Mult = 3, Divi=4, Mix2=5 };

struct stQuestions {
	short Number1 = 0;
	short Number2 = 0;
	char Operation=' ';
	short UserQuestion=0;
	short NOfQuestion = 0;
};
struct stQuestionsInfo {
	short NbrOfQuestions = 0;
	enTypeOfOpert OperationType = enTypeOfOpert::Add;
	enLevelOfQst Level= enLevelOfQst::Easy;
	string OperationName = "";
	string LevelName = "";
	short RightQuestions = 0;
	short WrongQuestion = 0;
};

int ReadHowManyQuestions()
{
	int NumOfQst = 1;
	do {
		cout << "How Many Question do you want to answer 1 to 10 ?" << endl;
		cin >> NumOfQst;
	} while (NumOfQst < 1 || NumOfQst >10);
	return NumOfQst;
}

enLevelOfQst ReadLevelTheQst()
{
	short ChoiceLevel = 1;
	do
	{
		cout << "\nEnter Question level :  [1]:Easy, [2]:Med, [3]:Hard, [4]:Mix ?";
		cin >> ChoiceLevel;

	} while (ChoiceLevel < 1 || ChoiceLevel>4);

	return (enLevelOfQst)ChoiceLevel;
}

enTypeOfOpert ReadTypeOfOpert()
{
	short ChoiceOperat = 1;
	do
	{
		cout << "\nEnter Operation type :  [1]:Add, [2]:Sub, [3]:Mult, [4]:Divis, [5]:Mix ?";
		cin >> ChoiceOperat;

	} while (ChoiceOperat < 1 || ChoiceOperat>5);

	return (enTypeOfOpert)ChoiceOperat;
}

stQuestionsInfo FillQuestionInfo()
{
	stQuestionsInfo QuestionsInfo;
	QuestionsInfo.NbrOfQuestions = ReadHowManyQuestions();
	QuestionsInfo.Level = ReadLevelTheQst();
	QuestionsInfo.OperationType = ReadTypeOfOpert();
	return QuestionsInfo;
}

int RandomNumber(int From, int To)
{
	int randNumber = rand() % (To - From + 1) + From;
	return randNumber;
}

short GetRandomNumber(enLevelOfQst Level)
{
	switch (Level)
	{
	case enLevelOfQst::Easy:
		return RandomNumber(1, 10);
		break;
	case enLevelOfQst::Med:
		return RandomNumber(10, 50);
		break;
	case enLevelOfQst::Hard:
		return RandomNumber(50, 100);
		break;
	case enLevelOfQst::Mix1:
		return RandomNumber(1, 100);
		break;
	}
}

char GetOperation(enTypeOfOpert Operation)
{
	switch (Operation)
	{
	case Add:
		return '+';
		break;
	case Sub:
		return '-';
		break;
	case Mult:
		return '*';
		break;
	case Divi:
		return '/';
		break;
	case Mix2:
		return GetOperation((enTypeOfOpert)RandomNumber(1, 4));
		break;
	}
}

short GetResult(char Operation, short A, short B)
{
	switch (Operation)
	{
	case '+':
		return A + B;
		break;
	case '-':
		return A - B;
		break;
	case '*':
		return A * B;
		break;
	case '/':
		return A / B;
		break;
	}

}

stQuestions FillQuestions(stQuestionsInfo QuestionsInfo,stQuestions Questions, int i)
{
	Questions.NOfQuestion = i;
	Questions.Number1 = GetRandomNumber(QuestionsInfo.Level);
	Questions.Number2 = GetRandomNumber(QuestionsInfo.Level);
	Questions.Operation = GetOperation(QuestionsInfo.OperationType);
	return Questions;
}

string OperationChoice(enTypeOfOpert Choice)
{
	string arrOperationChoice[5] = { "Add","Sub","Multip","Divis","Mix"};
	return arrOperationChoice[Choice - 1];
}
string LevelChoice(enLevelOfQst Choice)
{
	string arrLevelChoice[5] = { "Easy","Med","Hard","Mix" };
	return arrLevelChoice[Choice - 1];
}

bool CheckAnswer(short A, short B)
{
	return A == B;
}

void SetAnswerScreenColor(bool IsRight,short Result,  short& CountRightAnswer)
{
	if (!IsRight)
	{
		system("color 4F");
		cout << "\a";
		cout << "the right Answer is :" << Result << endl;
	}
	else
	{
		system("color 2F");
		cout << "the answer is right." << endl;
		CountRightAnswer++ ;
	}

}


void PrintResult(stQuestionsInfo QuestionsInfo, stQuestions Questions, short& count)
{
	short A=0, B=0, Answer=0, Result=0;
	char Operation;
	A = Questions.Number1;
	B = Questions.Number2;
	Operation = Questions.Operation;
	cout << "\n------------Question [" << Questions.NOfQuestion << "/"<< QuestionsInfo.NbrOfQuestions << "]------------------\n\n";
	cout <<"\t"<< A << Operation << B << " =";
	cin >> Answer;
	cout << "\n -----------------------------------------------" <<endl;
	Questions.UserQuestion = Answer;
	Result = GetResult(Operation, A, B);
	SetAnswerScreenColor(CheckAnswer(Answer,Result),Result , count);

}

string PassOrFail(short NbrOfQst, short RightAnswer, short WrongAnswer)
{
	if (RightAnswer >= WrongAnswer)
		return "Pass :-)";
	else
		return "Fail :-(";
}

void SetScreenColor(string Result)
{
	if(Result == "Fail")
	{
		system("color 4F");
		cout << "\a";
	}
	else
	{
		system("color 2F");
	}
	
}

void ShowFinalResults(stQuestionsInfo QuestionsInfo)
{
	string Result = PassOrFail(QuestionsInfo.NbrOfQuestions,QuestionsInfo.RightQuestions, QuestionsInfo.WrongQuestion);
	cout << "__________________________________________\n\n";
	cout << " Final Result is " << Result << endl;;
	cout << "__________________________________________\n\n";
	cout << "Number of Questions    : " << QuestionsInfo.NbrOfQuestions << endl;
	cout << "Questions Level        : " << QuestionsInfo.LevelName << endl;
	cout << "OpType                 : " << QuestionsInfo.OperationName << endl;
	cout << "Number of Right Answer : " << QuestionsInfo.RightQuestions << endl;
	cout << "Number of Wrong Answer : " << QuestionsInfo.WrongQuestion << endl;
	cout << "___________________________________________\n";
	SetScreenColor(Result);
}

void ResetScreen()
{
	/* ResetScreen */
	system("cls");
	system("color 0F");
}

void ShowQuestions(stQuestionsInfo QuestionsInfo, stQuestions Questions)
{
	char PlayAgain = 'Y';
	do {
		ResetScreen();
		short count = 0;
		QuestionsInfo = FillQuestionInfo();
		for (int i = 1; i <= QuestionsInfo.NbrOfQuestions; i++)
		{
			Questions = FillQuestions(QuestionsInfo, Questions, i);
			PrintResult(QuestionsInfo,Questions, count);
		}
		QuestionsInfo.OperationName = OperationChoice(QuestionsInfo.OperationType);
		QuestionsInfo.LevelName = LevelChoice(QuestionsInfo.Level);
		QuestionsInfo.RightQuestions = count;
		QuestionsInfo.WrongQuestion = QuestionsInfo.NbrOfQuestions - QuestionsInfo.RightQuestions;
		ShowFinalResults(QuestionsInfo);
		
		cout << endl << "Do you want to play again ? Y/N ?";
		cin >> PlayAgain;

	} while (PlayAgain == 'Y' || PlayAgain == 'y');
}



int main()
{
	srand((unsigned)time(NULL));

	stQuestionsInfo QuestionsInfo;
	stQuestions Questions;
	ShowQuestions(QuestionsInfo, Questions);
	

	return 0;
}
