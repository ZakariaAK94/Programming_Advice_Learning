#pragma once
#include<iostream>
using namespace std;

class clsUniversity
{
    class clsStudent
    {
        private:
            string _FirstName;
            string _LastName;

            struct stModules
            {
                float Math;
                float Physic;
                float French;
            };

        public:

            stModules Modules;

            clsStudent(string FirstName, string LastName, float Math, float Physic, float French)
            {
                _FirstName = FirstName;
                _LastName = LastName;
                Modules.Math = Math;
                Modules.Physic = Physic;
                Modules.French = French;
            }
            void SetFirsName(string FirstName)
            {
                _FirstName = FirstName;
            }
            string GetFirstName()
            {
                return _FirstName;
            }
            void SetLastName(string LastName)
            {
                _LastName = LastName;
            }
            string GetLastName()
            {
                return _LastName;
            }
            void SetMath(float Math)
            {
                Modules.Math = Math;
            }
            float GetMath()
            {
                return Modules.Math;
            }
            void SetPhysic(float Physic)
            {
                Modules.Physic = Physic;
            }
            float GetPhysic()
            {
                return Modules.Physic;
            }
            void SetFrench(float French)
            {
                Modules.French = French;
            }
            float GetFrench()
            {
                return Modules.French;
            }
            float CalculAverage()
            {
                return (Modules.Math + Modules.Physic + Modules.French) / 3;
            }
            void printResult()
            {
                cout << "Finale result for  " << GetFirstName() + " " + GetLastName() << " is : " << CalculAverage() << endl;
            }
    };
    string _Season;
public:

    clsStudent Student = clsStudent("", "", 0, 0, 0);

    clsUniversity(string FirstName, string LastName, float Math, float Physic, float French, string Season)
    {
        _Season = Season;
        Student = clsStudent(FirstName, LastName, Math, Physic, French);
    }

    void SetModul(string field)
    {
        _Season = field;
    }
    string GetModul()
    {
        return _Season;
    }

};

