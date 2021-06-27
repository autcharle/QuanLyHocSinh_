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
    /// Interaction logic for UserControlAddClass.xaml
    /// </summary>
    public partial class UserControlCreateClass : UserControl
    {
        List<Student> _students = new List<Student>();
        BUS_Class _busClass = new BUS_Class();
        Class _class = new Class();
        public UserControlCreateClass()
        {
            InitializeComponent();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void SaveButton_Click_1(object sender, RoutedEventArgs e)
        {
            _class.Class_Name = ClassNameTextBox.Text;
            string class_group = ClassGroupCombobox.Text;
            _class.Class_Group = int.Parse(class_group.ToString());

            // tesst
            if (_busClass.InsertAClass(_class))
            {
                MessageBox.Show("Thêm lớp học thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại, vui lòng xem lại các trường dữ liệu!");
            }
        }
    }
}



