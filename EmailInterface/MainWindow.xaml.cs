using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmailInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student s = new Student();
        List<Student> stu = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            stu.Add(new Student { Name = "Jaffersha", RollNo = 101, Mailid = "jaffersha786@gmail.com", Message = "Hello" });
            stu.Add(new Student { Name = "Harish", RollNo = 102, Mailid = "harish12ser@gmail.com", Message = "Hello" });
           
        }

        private void mybtn_Click_1(object sender, RoutedEventArgs e)
        {
            if (Rahamath.IsChecked==true)
            {
                foreach (Student S in stu)
                {
                    if (S.RollNo == 101)
                    {
                        s.Mail(S.Mailid, S.Message, S.Name, S.RollNo);
                    }
                }
            }

            if (Harish.IsChecked == true)
            {
                foreach (Student S in stu)
                {
                    if (S.RollNo == 102)
                    {
                        s.Mail(S.Mailid, S.Message, S.Name, S.RollNo);
                    }
                }
            }
            MessageBox.Show("Thank You");
        }
    }
}
