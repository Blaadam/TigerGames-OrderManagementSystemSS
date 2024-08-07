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

using TigerGames_OrderManagementSystemSS.MainViews;

namespace TigerGames_OrderManagementSystemSS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadHomepage();
        }

        private void LoadHomepage()
        {
            HomeView page = new HomeView();
            var Content = page.Content;

            page.Content = null;

            MainContentFrame.Children.Clear();
            MainContentFrame.Children.Add(Content as UIElement);
        }

        private void LoadPage(string TableName)
        {
            DatagridView page = new DatagridView(TableName);

            var Content = page.Content;
            page.Content = null;

            MainContentFrame.Children.Clear();
            MainContentFrame.Children.Add(Content as UIElement);
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Would you like to leave the application?", "Tiger Games v1.0 - Logout", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                LoginScreen window = new LoginScreen();
                window.Show();
            }
            this.Close();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadHomepage();
        }

        private void CategoriesBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadPage("Category");
        }

        private void ProductsBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadPage("Product");

        }

        private void OrdersBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadPage("Order");
        }

        private void CustomersBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadPage("Customer");
        }
        
    }
}
