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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Task9Page.xaml
    /// </summary>
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
        }
        private void BtnTask9_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbX.Text) && string.IsNullOrEmpty(TbY.Text) && string.IsNullOrEmpty(TbD.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbD.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask9Class myTask9Class = new MyTask9Class(Convert.ToDouble(TbX.Text), Convert.ToDouble(TbY.Text), Convert.ToDouble(TbD.Text));

                MessageBox.Show($"V = {myTask9Class.R()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbX.Text = string.Empty;
                TbY.Text = string.Empty;
                TbD.Text = string.Empty;
            }
        }
    }
}
