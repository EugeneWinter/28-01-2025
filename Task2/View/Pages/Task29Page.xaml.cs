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
    /// Логика взаимодействия для Task29Page.xaml
    /// </summary>
    public partial class Task29Page : Page
    {
        public Task29Page()
        {
            InitializeComponent();
        }
        private void BtnTask29_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbD.Text) && string.IsNullOrEmpty(TbY.Text) && string.IsNullOrEmpty(TbX.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbD.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask29Class myTask29Class = new MyTask29Class(Convert.ToDouble(TbD.Text), Convert.ToDouble(TbY.Text), Convert.ToDouble(TbX.Text));

                MessageBox.Show($"R = {myTask29Class.R()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbD.Text = string.Empty;
                TbY.Text = string.Empty;
                TbX.Text = string.Empty;
            }
        }
    }
}
