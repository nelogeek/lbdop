using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            FileStream file = new FileStream(openFile.FileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            Student student = (Student)bf.Deserialize(file);
            file.Close();

            studentNameInfo.Text = student.StudentInfo.Name;
            studentSurnameInfo.Text = student.StudentInfo.Surname;
            studentMiddleNameInfo.Text = student.StudentInfo.MiddleName;
            studentPhoneInfo.Text = student.StudentInfo.PhoneNumber.ToString();

            birthPlaceInfo.Text = student.BirthPlaceName;
            birthDayInfo.Text = student.Birthday.Day.ToString();
            birthMonthInfo.Text = student.Birthday.Month.ToString();
            birthYearInfo.Text = student.Birthday.Year.ToString();

            parentPhoneInfo.Text = student.ParentsInfo.PhoneNumber.ToString();
            parentMiddleNameInfo.Text = student.ParentsInfo.MiddleName;
            parentSurnameInfo.Text = student.ParentsInfo.Surname;
            parentNameInfo.Text = student.ParentsInfo.Name;

            universityInfo.Text = student.University;
            instituteInfo.Text = student.Institute;
            departmentInfo.Text = student.Department;
            specializationInfo.Text = student.Specialization;
            groupInfo.Text = student.Group;

            physicsInfo.Text = student.PhysicsExamResult.ToString();
            russianInfo.Text = student.RussianExamResult.ToString();
            mathematicsInfo.Text = student.MathematicsExamResult.ToString();
            avgInfo.Text = student.AverageScoreOfTheCertificate.ToString();
        }
    }
}
