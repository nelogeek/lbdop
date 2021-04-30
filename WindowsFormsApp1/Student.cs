using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    struct PersonInfo
    {
        public string Name;
        public string Surname;
        public string MiddleName;
        public uint PhoneNumber;

        public PersonInfo(string name = "",string surname = "", string middleName = "", uint phoneNumber = 0)
        {
            this.Name = name;
            this.Surname = surname;
            this.MiddleName = middleName;
            this.PhoneNumber = phoneNumber;
        }
    }

    [Serializable]
    struct Data
    {
        public byte Day;
        public byte Month;
        public uint Year;

        public Data(byte day, byte month, uint year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }
    }

    [Serializable]
    class Student
    {
        public PersonInfo StudentInfo;
        public Data Birthday;
        public string BirthPlaceName;

        public PersonInfo ParentsInfo;

        public string University;
        public string Institute;
        public string Department;
        public string Specialization;
        public string Group;

        public byte PhysicsExamResult;
        public byte RussianExamResult;
        public byte MathematicsExamResult;

        public float AverageScoreOfTheCertificate;
        public enum Intrestings {DANCE,SPORT,COMPUTRES};
        public Intrestings Intresting;

        public Student(PersonInfo studentInfo = new PersonInfo(),Data birthday = new Data(),string birthPlace = "",PersonInfo parentsInfo = new PersonInfo(),
            string university = "",string institute="",string department="",string specialization="",string group="",
            byte physicsResult =0,byte russianResult=0,byte mathematicsResult=0,float averageScoreCertificate =0,Intrestings intresting = 0)
        {
            this.StudentInfo = studentInfo;
            this.Birthday = birthday;
            this.BirthPlaceName = birthPlace;
            this.ParentsInfo = parentsInfo;
            this.University = university;
            this.Institute = institute;
            this.Department = department;
            this.Specialization = specialization;
            this.Group = group;
            this.PhysicsExamResult = physicsResult;
            this.RussianExamResult = russianResult;
            this.MathematicsExamResult = mathematicsResult;
            this.AverageScoreOfTheCertificate = averageScoreCertificate;
            this.Intresting = intresting;
        }
    }
}
