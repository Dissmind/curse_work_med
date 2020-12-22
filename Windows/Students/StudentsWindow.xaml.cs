using cusrse_work_forth.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

namespace cusrse_work_forth.Windows.Students
{
    /// <summary>
    /// Логика взаимодействия для StudentsWindow.xaml
    /// </summary>
    public partial class StudentsWindow : Window
    {
        private void UpdateTable()
        {
            studentsGrid.ItemsSource = StudentRepository.GetAll();
        }

        public StudentsWindow()
        {
            InitializeComponent();

            UpdateTable();
        }


        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            new DeleteStudentWindow().ShowDialog();

            UpdateTable();
        }


        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            new AddStudentWindow().ShowDialog();

            UpdateTable();
        }
    }
}
