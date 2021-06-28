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
		BUS_Point _busPoint = new BUS_Point();
		private int idStudent { get; set; }
		private int semester { get; set; }
		private int idSubject { get; set; }
		public WindowInputMarkForStudent(int idStudentInput, int semeterInput, int idSubjectInput)
		{
			idStudent = idStudentInput;
			semester = semeterInput;
			idSubject = idSubjectInput;
			InitializeComponent();
		}

		private void buttonInputMark_Click(object sender, RoutedEventArgs e)
		{
			string mark15Input = textBoxMark15.Text;
			string mark45Input = textBoxMark45.Text;
			string markCkInput = textBoxMarkCk.Text;
			double mark15 = double.Parse(mark15Input);
			double mark45 = double.Parse(mark45Input);
			double markCk = double.Parse(markCkInput);
			
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
