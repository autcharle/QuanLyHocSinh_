using System;
using BUS;
using DTO;
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
using System.Windows.Shapes;
using Point = DTO.Point;

namespace GUI
{
	/// <summary>
	/// Interaction logic for WindowInputMarkForStudent.xaml
	/// </summary>
	public partial class WindowInputMarkForStudent : Window
	{
		BUS_Subject _busSubject = new BUS_Subject();
		List<Subject> subjectList = new List<Subject>();

		BUS_Point _busPoint = new BUS_Point();
		private int idStudent { get; set; }
		public WindowInputMarkForStudent(int idSt)
		{
			idStudent = idSt;
			InitializeComponent();
		}

		private void Loaded_Window(object sender, RoutedEventArgs e)
		{
			subjectList = _busSubject.getAllSubject();
			foreach(var sub in subjectList)
			{
				comboBoxSubject.Items.Add(sub.Subject_Name);
			}
			comboBoxSemester.Items.Add("1");
			comboBoxSemester.Items.Add("2");
		}

		private void buttonInputMark_Click(object sender, RoutedEventArgs e)
		{
			string mark15Input = textBoxMark15.Text;
			string mark45Input = textBoxMark45.Text;
			string markCkInput = textBoxMarkCk.Text;
			double mark15 = double.Parse(mark15Input);
			double mark45 = double.Parse(mark45Input);
			double markCk = double.Parse(markCkInput);
			int idSubject = subjectList[comboBoxSubject.SelectedIndex].Subject_ID;
			int semester = 0;
			if (comboBoxSemester.SelectedIndex == -1)
				semester = 0;
			else if (comboBoxSemester.SelectedIndex == 0)
				semester = 1;
			else if (comboBoxSemester.SelectedIndex == 1)
				semester = 2;
			if (mark15<0 || mark15 > 10)
			{
				MessageBox.Show("Điểm không được <0 và > 10", "Notice");
			}
			else if(mark45 < 0 || mark45 > 10)
			{
				MessageBox.Show("Điểm không được <0 và > 10", "Notice");
			}	
			else if(markCk < 0 || markCk > 10)
			{
				MessageBox.Show("Điểm không được <0 và > 10", "Notice");
			}
			else
			{
				Point _point = new Point(idSubject, idStudent, semester, mark15, mark45, markCk);

				bool add = _busPoint.InsertPointForStudent(_point);
				if (add == true)
				{
					MessageBox.Show("Done!","Notice");
				}
			}
		}
	}
}
