﻿using System;
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
using DateTimeLib;

namespace DateTimeProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Запуск приложения
        /// </summary>
        private void ResultButtonClick(object sender, RoutedEventArgs e)
        {
            if (ResultDatePicker.Text == "") 
            {
                ResultDatePicker.BorderThickness = new Thickness(1);
                ResultDatePicker.BorderBrush = Brushes.Red;
            }
            else
            {
                ResultDatePicker.BorderBrush = Brushes.Gray; 
                string prevDateString = DateTimeClass.PrevDate(ResultDatePicker.SelectedDate.Value).ToShortDateString();
                string nextDateString = DateTimeClass.NextDate(ResultDatePicker.SelectedDate.Value).ToShortDateString();
                string daysInMonthDateString = DateTimeClass.DaysUntilEndMonth(ResultDatePicker.SelectedDate.Value).ToString();
                ResultTextBlock.Text = prevDateString + "\n" + nextDateString + "\n" + daysInMonthDateString + " дней до конца месяца"+"\n" ;
            }
        }
    }
}
