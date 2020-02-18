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

namespace Ederson_Cardoso_Ex01
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

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
			try
			{
				string courseList = "";
				string programFormat = "";
				string program = "";

				// set List of courses
				if (JavaProgrammingCheckBox.IsChecked == true)
				{
					courseList += "Java Programming, ";
				}
				if (WebProgrammingCheckBox.IsChecked == true)
				{
					courseList += "Web Programming, ";
				}
				if (DatabaaseProgrammingCheckBox.IsChecked == true)
				{
					courseList += "Database Programming, ";
				}
				if (SoftwareEngineeringCheckBox.IsChecked == true)
				{
					courseList += "Software Engineering, ";
				}

				// Set Program
				if (ProgramComboBox.Text == "Developer")
				{
					program = "Developer";
				}
				else if (ProgramComboBox.Text == "Analyst")
				{
					program = "Analyst";
				}
				else if (ProgramComboBox.Text == "Tester")
				{
					program = "Tester";
				}

				// Set Program Format
				if (FullTimeRadioButton.IsChecked == true)
				{
					programFormat = "Full-time";
				}
				if (PartTimeRadioButton.IsChecked == true)
				{
					programFormat = "Part-time";
				}
				if (EveningRadioButton.IsChecked == true)
				{
					programFormat = "Evening";
				}
				

				// Check is patient's name is informed
				var name = string.IsNullOrEmpty(StudentNameTextBox.Text) ? "[NOT INFORMED]" : StudentNameTextBox.Text;

				// Format string output
				string output = ($"Student Name: {name} \n" +
					$"Program: {program,10:C} \n" +
					$"Format: {programFormat,12:C} \n" +
					$"Courses: {courseList,12:C} \n");

				OutputTextBlock.Text = output;

			}
			catch (Exception ex)
			{
				OutputTextBlock.Text = "Error: " + ex.Message.ToString();
			}
		}
    }
}
