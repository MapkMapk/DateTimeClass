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
                
                string leapYearCheckDateString = "";
                if (DateTimeClass.LeapYearCheck(ResultDatePicker.SelectedDate.Value)) { leapYearCheckDateString = "Год весокосный"; }
                else { leapYearCheckDateString = "Год невесокосный"; }
                string findDateString = "";
                if (DayCountTextBlock.Text == "" || !int.TryParse(DayCountTextBlock.Text, out int number))
                {
                    DayCountTextBlock.BorderThickness = new Thickness(1);
                    DayCountTextBlock.BorderBrush = Brushes.Red;
                    
                }
                else
                {
                    DayCountTextBlock.BorderBrush = Brushes.LightGray;
                    
                    findDateString = DateTimeClass.FindDate(ResultDatePicker.SelectedDate.Value, Convert.ToInt32(DayCountTextBlock.Text)).ToShortDateString();
                }

                string nextDayOfMonthDateString = "";
                if (DateTimeClass.NextDayOfMonth(ResultDatePicker.SelectedDate.Value)) { nextDayOfMonthDateString = "Это не последний день месяца"; }
                else { nextDayOfMonthDateString = "Это последний день месяца"; }

                string firstDayOfYearDateString = "";
                if (DateTimeClass.FirstDayOfYear(ResultDatePicker.SelectedDate.Value)) { firstDayOfYearDateString = "Это первый день года"; }
                else { firstDayOfYearDateString = "Это не первый день года"; }

                ResultTextBlock.Text = prevDateString + "\n" + nextDateString + "\n" + daysInMonthDateString + " дней до конца месяца"+"\n"+ leapYearCheckDateString + "\n" + findDateString + "\n" + nextDayOfMonthDateString + "\n" + firstDayOfYearDateString;
            }
        }
    }
}
