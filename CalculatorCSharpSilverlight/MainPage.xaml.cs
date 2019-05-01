/*****************************************************************
**  Program Name:   Calculator C# Silverlight      				**
**  Version Number: V1.0                                        **
**  Copyright (C):  May 13, 2010 Richard W. Allen               **
**  Date Started:   May 13, 2010                                **
**  Date Ended:     May 13, 2010                                **
**  Author:         Richardn W. Allen                           **
**  Webpage:        http://richard-allen.homelinux.com/         **
**  IDE:            Visual Studio 2010                          **
**  Compiler:       C# 2010                                     **
**  Langage:        C# 2010                   				    **
**  License:        GNU GENERAL PUBLIC LICENSE Version 2    	**
**		            see license.txt for for details	            **
******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace CalculatorCSharpSilverlight
{
    public partial class MainPage : UserControl
    {
        enum Type
        {
            None = 0,
            Equals,
            Add,
            Subtract,
            Multiply,
            Divide
        }

        private double cal = 0.0d;
        private Type sign = Type.None;

        private void Operator(Type type)
        {
            if (sign != Type.Equals)
            {
                if (sign == Type.None)
                    cal = double.Parse(Block.Text);
                else
                {
                    switch (type)
                    {
                        case Type.Add:
                            cal += double.Parse(Block.Text);
                            break;
                        case Type.Subtract:
                            cal -= double.Parse(Block.Text);
                            break;
                        case Type.Multiply:
                            cal *= double.Parse(Block.Text);
                            break;
                        case Type.Divide:
                            cal /= double.Parse(Block.Text);
                            break;
                    }
                }
            }

            Block.Text = string.Empty;
            sign = type;
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Block.Text += '9';
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Block.Text += '8';
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            Block.Text += '7';
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Block.Text += '6';
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Block.Text += '5';
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Block.Text += '4';
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Block.Text += '3';
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Block.Text += '2';
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Block.Text += '1';
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            Block.Text += '0';
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            Operator(Type.Divide);
        }

        private void Multipy_Click(object sender, RoutedEventArgs e)
        {
            Operator(Type.Multiply);
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            Operator(Type.Subtract);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Operator(Type.Add);
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            Operator(sign);

            Block.Text = cal.ToString();
            sign = Type.Equals;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            cal = 0.0d;
            sign = Type.None;
            Block.Text = string.Empty;
        }

        private void Period_Click(object sender, RoutedEventArgs e)
        {
            if (Block.Text.IndexOf('.') < 0)
                Block.Text += '.';
        }

        private void PlusMinus_Click(object sender, RoutedEventArgs e)
        {
            double temp = double.Parse(Block.Text);
            temp = -temp;
            Block.Text = temp.ToString();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            AboutChildWindow about = new AboutChildWindow();
            about.Show();
        }
    }
}
