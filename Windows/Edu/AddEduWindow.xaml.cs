using cusrse_work_forth.Models;
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
    /// Логика взаимодействия для AddEduWindow.xaml
    /// </summary>
    public partial class AddEduWindow : Window
    {
        public AddEduWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var data = new EduModel
                (
                    name.Text,
                    type.Text,
                    direction.Text
                );

            try
            {
                EduRepository.Add(data);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ошибка, нет доступа к Базе Данных. \n Сообщение ошибки: ${error.Message}");
                this.Close();
                return;
            }

            MessageBox.Show("Запись успешно добавлена в Базу данных.");
            this.Close();
        }
    }
}
