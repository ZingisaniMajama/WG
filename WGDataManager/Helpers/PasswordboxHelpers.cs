using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;


/*********/
/***CZ Majama*******/
//Tim Correy Training(PasswordHelper)

namespace WGDataManager.Helpers
{
    public class PasswordboxHelper
    {

        public static readonly DependencyProperty BoundPasswordProperty =
            DependencyProperty.RegisterAttached("BoundPassword",
                typeof(string),
                typeof(PasswordboxHelper),
                new FrameworkPropertyMetadata(string.Empty, OnBoundPasswordChanged));



        public static string GetBoundPassword(DependencyObject d)
        {
            var box = d as PasswordBox;
            if (box != null)
            {
                //hooks the Password event once, and only once
                box.PasswordChanged -= PasswordChanged;
                box.PasswordChanged += PasswordChanged;
           }
            return (string)d.GetValue(BoundPasswordProperty);

        }

        public static void SetBoundPassword(DependencyObject d,string value)
        {
            if(string.Equals(value,GetBoundPassword(d)))
            {
                return;//how to prevent infinite recursion
            }
            d.SetValue(BoundPasswordProperty, value);
        }

        private static void OnBoundPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var box = d as PasswordBox;
            if (box == null)
            {
                return;
            }
            box.Password = GetBoundPassword(d);
        }

        private static void PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox password = sender as PasswordBox;
            SetBoundPassword(password, password.Password);

            //set the cursor on the last charater in the passwordBox

            password.GetType().GetMethod("Select", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(password,new object[] {password.MaxLength , 0} );
        } 
    }


}