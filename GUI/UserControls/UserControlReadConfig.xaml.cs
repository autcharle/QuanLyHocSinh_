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
    /// Interaction logic for UserControlReadConfig.xaml
    /// </summary>
    public partial class UserControlReadConfig : UserControl
    {
        BUS_Config busConfig = new BUS_Config();
        Config dtoConfig = new Config();
        public UserControlReadConfig()
        {
            InitializeComponent();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtoConfig = busConfig.GetConfig();
            this.MaxAge.Text = dtoConfig.Max_Age.ToString();
            this.MinAge.Text = dtoConfig.Min_Age.ToString();
            this.MaxClass.Text = dtoConfig.Max_Class.ToString();
            this.MaxSubject.Text = dtoConfig.Max_Subject.ToString();
            this.SubjectPointStandards.Text = dtoConfig.Subject_Point_Standards.ToString();
            this.MaxStudentClass.Text = dtoConfig.Max_Student_Class.ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            dtoConfig.Max_Age = Int32.Parse(this.MaxAge.Text.ToString());
            dtoConfig.Min_Age = Int32.Parse(this.MinAge.Text.ToString());
            dtoConfig.Max_Class = Int32.Parse(this.MaxClass.Text.ToString());
            dtoConfig.Max_Subject = Int32.Parse(this.MaxSubject.Text.ToString());
            dtoConfig.Subject_Point_Standards = Double.Parse(this.SubjectPointStandards.Text.ToString());
            dtoConfig.Max_Student_Class = Int32.Parse(this.MaxStudentClass.Text.ToString());
            var result = busConfig.updateConfig(dtoConfig);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}
