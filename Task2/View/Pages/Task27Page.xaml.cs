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
    /// Логика взаимодействия для Task27Page.xaml
    /// </summary>
    public partial class Task27Page : Page
    {
        public Task27Page()
        {
            InitializeComponent();
        }
        private void BtnTask27_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbY.Text) && string.IsNullOrEmpty(TbC.Text) && string.IsNullOrEmpty(TbX.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //double G = Math.Exp(2 * Convert.ToDouble(TbD.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
                MyTask27Class myTask27Class = new MyTask27Class(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbY.Text), Convert.ToDouble(TbC.Text), Convert.ToDouble(TbX.Text));

                MessageBox.Show($"P = {myTask27Class.P()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbY.Text = string.Empty;
                TbC.Text = string.Empty;
                TbX.Text = string.Empty;
            }
        }
    }
}
