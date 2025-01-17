using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student student = new Student();
            student.FirstName = "Firat";
            student.Age = 1;
            student.Mail = "asd@gmail.com";

            Student student1 = new Student();
            student.FirstName = "Boran";
            student.Age = 1;
            student.Mail = "asd@gmail.com";

            Student student2 = new Student();
            student.FirstName = "Ali";
            student.Age = 1;
            student.Mail = "asd@gmail.com";

            List<Student> students = new List<Student>() {student, student1, student2 };

            foreach (var student in students)
            {
                MessageBox.Show(student.FirstName());
            }
        }
    }
}
