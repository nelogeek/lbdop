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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            if (studentNameBox.Text.Trim().Length == 0)
                return;

            student.StudentInfo.Name        = studentNameBox.Text;

            if (studentSurnameBox.Text.Trim().Length == 0)
                return;
            student.StudentInfo.Surname     = studentSurnameBox.Text;

            if (studentMiddleNameBox.Text.Trim().Length == 0)
                return;
            student.StudentInfo.MiddleName  = studentMiddleNameBox.Text;

            if (!uint.TryParse(studentPhoneBox.Text,out student.StudentInfo.PhoneNumber))
                return;


            if (birthPlaceBox.Text.Trim().Length == 0)
                return;
            student.BirthPlaceName = birthPlaceBox.Text;

            if (!byte.TryParse(birthDayBox.Text, out student.Birthday.Day))
                return;

            if (!byte.TryParse(birthMonthBox.Text, out student.Birthday.Month))
                return;

            if (!uint.TryParse(birthYearBox.Text, out student.Birthday.Year))
                return;


            if (parentNameBox.Text.Trim().Length == 0)
                return;
            student.ParentsInfo.Name        = parentNameBox.Text;

            if (parentSurnameBox.Text.Trim().Length == 0)
                return;
            student.ParentsInfo.Surname     = parentSurnameBox.Text;

            if (parentMiddleNameBox.Text.Trim().Length == 0)
                return;
            student.ParentsInfo.MiddleName  = parentMiddleNameBox.Text;

            if (!uint.TryParse(parentPhoneBox.Text, out student.ParentsInfo.PhoneNumber))
                return;


            if (universityBox.Text.Trim().Length == 0)
                return;
            student.University     = universityBox.Text;

            if (instituteBox.Text.Trim().Length == 0)
                return;
            student.Institute      = instituteBox.Text;

            if (departmentBox.Text.Trim().Length == 0)
                return;
            student.Department     = departmentBox.Text;

            if (specializationBox.Text.Trim().Length == 0)
                return;
            student.Specialization = specializationBox.Text;

            if (groupBox.Text.Trim().Length == 0)
                return;
            student.Group          = groupBox.Text;


            if (!byte.TryParse(physicsBox.Text, out student.PhysicsExamResult))
                return;

            if (!byte.TryParse(russianBox.Text, out student.RussianExamResult))
                return;

            if (!byte.TryParse(mathematicsBox.Text, out student.MathematicsExamResult))
                return;

            if (!float.TryParse(avgBox.Text, out student.AverageScoreOfTheCertificate))
                return;

            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(saveFile.FileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(file, student);
                file.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            FileStream file    = new FileStream(openFile.FileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            Student student = (Student)bf.Deserialize(file);
            file.Close();

            studentNameBox.Text       = student.StudentInfo.Name;
            studentSurnameBox.Text    = student.StudentInfo.Surname;
            studentMiddleNameBox.Text = student.StudentInfo.MiddleName;
            studentPhoneBox.Text      = student.StudentInfo.PhoneNumber.ToString();

            birthPlaceBox.Text = student.BirthPlaceName;
            birthDayBox.Text   = student.Birthday.Day.ToString();
            birthMonthBox.Text = student.Birthday.Month.ToString();
            birthYearBox.Text  = student.Birthday.Year.ToString();

            parentPhoneBox.Text      = student.ParentsInfo.PhoneNumber.ToString();
            parentMiddleNameBox.Text = student.ParentsInfo.MiddleName;
            parentSurnameBox.Text    = student.ParentsInfo.Surname;
            parentNameBox.Text       = student.ParentsInfo.Name;

            universityBox.Text     = student.University;
            instituteBox.Text      = student.Institute;
            departmentBox.Text     = student.Department;
            specializationBox.Text = student.Specialization;
            groupBox.Text          = student.Group;

            physicsBox.Text     = student.PhysicsExamResult.ToString();
            russianBox.Text     = student.RussianExamResult.ToString();
            mathematicsBox.Text = student.MathematicsExamResult.ToString();
            avgBox.Text         = student.AverageScoreOfTheCertificate.ToString();
        }
    }
}
