using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        void AddGrade(int grade);
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(char grade);
        void AddGrade(string grade);
        Statistics GetStatistics();
        event GradeAddedDelegate GradeAdded;
    }
}
