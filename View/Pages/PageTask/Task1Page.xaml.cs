using CW.Test.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Controls;

namespace CW.Test.View.Pages.PageTask
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }
        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task1Page());
        }
        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task2Page());
        }
        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task3Page());
        }
        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task4Page());
        }
        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task5Page());
        }
        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task6Page());
        }
        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task7Page());
        }
        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task8Page());
        }
        private void BtnTask9_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task9Page());
        }
        private void BtnTask10_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task10Page());
        }
        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task11Page());
        }
        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?",
                "Системное сообщение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                CoreTest.TestFrame?.Navigate(new MainPage());
            }
        }
        
        private void TbMessiveBtn_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int N = rnd.Next(0,10);
            int M = rnd.Next(0, 10);
            int[,] matrix = new int[N, M]; // N rows, M columns
            HashSet<int> firstRowSet = new HashSet<int>();
            for (int j = 0; j < M; j++)
            {
                firstRowSet.Add(matrix[0, j]);
            }
            int countSimilarRows = 0;
            for (int i = 1; i < N; i++)
            {
                HashSet<int> rowSet = new HashSet<int>();
                for (int j = 0; j < M; j++)
                {
                    rowSet.Add( matrix[i, j]);
                }
                if (rowSet.SetEquals(firstRowSet))
                {
                    countSimilarRows++;
                }
            }
            outputTextBox.Text = countSimilarRows.ToString();
        }

        private void TbMessiveBtnEmpty_Click(object sender, RoutedEventArgs e)
        {
            outputTextBox.Text = string.Empty;
        }
    }
}