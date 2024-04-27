﻿using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VovaPractics.Pages;
using VovaPractics.BD;

namespace VovaPractics
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model1 context;
        Window window;
        public MainWindow()
        {
            InitializeComponent();
            context = new Model1();
            MyFrame.Navigate(new Pages.MenuPage(context,window));
        }
    }
}
