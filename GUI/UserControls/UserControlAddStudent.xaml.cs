using BUS;
using DTO;
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

namespace GUI.UserControls
{
    /// <summary>
    /// Interaction logic for UserControlAddStudent.xaml
    /// </summary>
    public partial class UserControlAddStudent : UserControl
    {
        List<Student> _students = new List<Student>();
        BUS_Student _busStudent = new BUS_Student();
        public UserControlAddStudent()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _students = _busStudent.GetAllStudent();
            ListBox.ItemsSource = _students; 
        }
    }
}
