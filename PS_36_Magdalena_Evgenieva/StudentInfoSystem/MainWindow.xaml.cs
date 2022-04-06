using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();         
        }

        private Student student;

        public Student Stud {
            get
            {
                return student;
            }
            set
            {
                if (value == null || value.isEmpty())
                {
                    student = null;
                    clearText();
                    disableControl();
                }
                else
                {
                    enableControl();
                    StudentInfo(value);
                    student = value;
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clearText();
        }

        private void clearText()
        {
            foreach (var item in MainGrid1.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = String.Empty;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            disableControl();
        }

        private void disableControl()
        {
            foreach (Control item in MainGrid1.Children)
            {
                if (item.Name.Equals(Enabled.Name))
                    item.IsEnabled = true;
                else
                    item.IsEnabled = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            enableControl();
        }

        private void enableControl()
        {
            foreach (Control item in MainGrid1.Children)
            {
                item.IsEnabled = true;
            }
        }

        private void StudentInfo(Student student)
        {
            Name.Text = student.name;
            Surname.Text = student.surname;
            FamilyName.Text = student.familyName;
            Specialty.Text = student.specialty;
            Status.Text = student.status;
            FacultyNumber.Text = student.facultyNumber;
            Status.Text = student.status;
            Course.Text = student.course;
            Stream.Text = student.stream;
            Group.Text = student.group;
        }

      
    }
}
