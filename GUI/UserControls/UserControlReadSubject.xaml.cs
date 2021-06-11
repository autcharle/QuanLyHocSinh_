using System;
using DTO;
using BUS;
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
    /// Interaction logic for UserControlReadSubject.xaml
    /// </summary>
    /// 



    public partial class UserControlReadSubject : UserControl
    {

        BUS_StudentPointSubject _busStudentPointSubject = new BUS_StudentPointSubject();
        List<StudentPointSubject> studentPointSubjectList = new List<StudentPointSubject>();

        BUS_Subject _busSubject = new BUS_Subject();
        List<Subject> subjectList = new List<Subject>();

        BUS_Class _busClass = new BUS_Class();
        List<Class> classList = new List<Class>();

        public UserControlReadSubject()
        {
            InitializeComponent();
        }

		private int getIdClass(string className)
		{
			foreach (var cl in classList)
			{
				if (cl.Class_Name.CompareTo(className) == 0)
				{
					return cl.Class_ID;
				}
			}
			return 0;
		}

		private int getIdSubject(string subjectName)
		{
			foreach (var subject in subjectList)
			{
				if (subject.Subject_Name.CompareTo(subjectName) == 0)
				{
					return subject.Subject_ID;
				}
			}
			return 0;
		}

		private int count() => studentPointSubjectList.Count();

		private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            studentPointSubjectList = _busStudentPointSubject.getAllStudentPointSubject();
            ListViewPoint.ItemsSource = studentPointSubjectList;
			classList = _busClass.GetAllClass();
			subjectList = _busSubject.getAllSubject();
			comboBoxClass.ItemsSource = classList;
			comboBoxSubject.ItemsSource = subjectList;
		}

		private void buttonSearch_Click(object sender, RoutedEventArgs e)
		{
			int selectClass = comboBoxClass.SelectedIndex;
			int selectSubject = comboBoxSubject.SelectedIndex;
			int semester = comboBoxSemester.SelectedIndex;
			int selectSemester = 0;
			if (semester == -1)
				selectSemester = 0;
			else if (semester == 0)
				selectSemester = 1;
			else if (semester == 1)
				selectSemester = 2;


			if (selectClass == -1)
			{
				if (selectSubject == -1)
				{
					if(selectSemester == 0)
					{
						studentPointSubjectList = _busStudentPointSubject.getAllStudentPointSubject();
						ListViewPoint.ItemsSource = studentPointSubjectList;
					}
					else
					{
						studentPointSubjectList = _busStudentPointSubject.getBySemester(selectSemester);
						ListViewPoint.ItemsSource = studentPointSubjectList;
					}
				}
				else
				{
					int idSu = getIdSubject(subjectList[selectSubject].Subject_Name);
					if (selectSemester == 0)
					{
						studentPointSubjectList = _busStudentPointSubject.getByIdSubject(idSu);
						ListViewPoint.ItemsSource = studentPointSubjectList;
					}
					else
					{
						studentPointSubjectList = _busStudentPointSubject.getBySemesterAndIdSubject(selectSemester,idSu);
						ListViewPoint.ItemsSource = studentPointSubjectList;
					}
				}
			}
			else
			{
				int idCl = getIdClass(classList[selectClass].Class_Name);
				if (selectSubject == -1)
				{
					if (selectSemester == 0)
					{
						studentPointSubjectList = _busStudentPointSubject.getByIdClass(idCl);
						ListViewPoint.ItemsSource = studentPointSubjectList;
					}
					else
					{
						studentPointSubjectList = _busStudentPointSubject.getBySemesterAndIdClass(selectSemester,idCl);
						ListViewPoint.ItemsSource = studentPointSubjectList;
					}
				}
				else
				{
					int idSu = getIdSubject(subjectList[selectSubject].Subject_Name);
					if (selectSemester == 0)
					{
						studentPointSubjectList = _busStudentPointSubject.getByIdClassAndIdSubject(idCl,idSu);
						ListViewPoint.ItemsSource = studentPointSubjectList;
					}
					else
					{
						studentPointSubjectList = _busStudentPointSubject.getStudentPointSubject(selectSemester,idCl,idSu);
						ListViewPoint.ItemsSource = studentPointSubjectList;
					}
				}
			}
		}
	}
}
