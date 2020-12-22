using cusrse_work_forth.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace cusrse_work_forth.Windows.Edu
{
    /// <summary>
    /// Логика взаимодействия для EduWindow.xaml
    /// </summary>
    public partial class EduWindow : Window
    {
        private void UpdateTable()
        {
            eduGrid.ItemsSource = EduRepository.GetAll();
        }

        public EduWindow()
        {
            InitializeComponent();

            UpdateTable();
        }


        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            new DeleteEduWindow().ShowDialog();
            UpdateTable();
        }


        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            new AddEduWindow().ShowDialog();
            UpdateTable();
        }
    }
}
