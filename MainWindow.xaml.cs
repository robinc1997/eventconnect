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

namespace Event_Connect
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataBase db = new DataBase();
        public MainWindow()
        {
            InitializeComponent();
            db.Open();
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Close();
        }

        private void btn_Search_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Create_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow cw = new CreateWindow();
            cw.Show();
        }
    }
}
