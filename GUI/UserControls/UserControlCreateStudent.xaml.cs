﻿using BUS;
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
    public partial class UserControlCreateStudent : UserControl
    {
        List<Student> _students = new List<Student>();
        BUS_Student _busStudent = new BUS_Student();
        Student _student = new Student();
        public UserControlCreateStudent()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _student.FullName = FullNameTextBox.Text;
            _student.Gender = GenderCombobox.Text;
            _student.Birthday = (DateTime)BirthdayPicker.SelectedDate;
            _student.Address = AddressTextBox.Text;
            _student.Email = EmailTextBox.Text;
            if (_busStudent.InsertAStudent(_student))
            {
                MessageBox.Show("Thêm thành công, thông tin học sinh đã được tiếp nhận!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại, vui lòng xem lại các trường dữ liệu!");
            }
        }
    }
}
