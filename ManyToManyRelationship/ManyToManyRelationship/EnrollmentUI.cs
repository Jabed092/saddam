using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManyToManyRelationship
{
    public partial class EnrollmentUI : Form
    {

        public EnrollmentUI(List<Student> students, List<Course> courses, List<Enrollment> enrollments )
        {
            InitializeComponent();
            PopulateStudentComboBox(students);
        }

        private void PopulateStudentComboBox(List<Student> students)
        {
            studentComboBox.DisplayMember = "RegNo";
            studentComboBox.DataSource = students;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
