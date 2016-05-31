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
using Controller.Implementation;
using Model;
using System.IO;

namespace QuanLyDonHang
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWD_Loaded(object sender, RoutedEventArgs e)
        {
            UserGroupImp.CheckAndCreateDefaultUserGroup();
            UserImp.CheckAndCreateDefaultUserGroup();
            tbUsername.Focus();
        }

        private bool Login()
        {
            bool res = false;

            try
            {
                res = UserImp.Login(tbUsername.Text, pbPassword.Password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return res;
        }

        private void ValidateInput()
        {
            if (!String.IsNullOrEmpty(tbUsername.Text))
            {
                btLogin.IsEnabled = true;
            }
            else
            {
                btLogin.IsEnabled = false;
            }
        }

        private void tbUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidateInput();
        }

        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            if (Login())
            {
                ManagerWD _managerWD = new ManagerWD();
                _managerWD.Show();
                LoginWD.Close();
            }
            else
            {
                MessageBox.Show("Không thể đăng nhập.\nVui lòng kiểm tra thông tin.");
            }
        }

        private void pbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                btLogin_Click(sender, e);
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                btLogin_Click(sender, e);
        }
    }
}
