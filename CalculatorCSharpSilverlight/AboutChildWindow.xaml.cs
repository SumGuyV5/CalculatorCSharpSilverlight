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
    public partial class AboutChildWindow : ChildWindow
    {
        public AboutChildWindow()
        {
            InitializeComponent();
            this.Title = String.Format("About {0}", "Calculator C# Silverlight");
            this.ProductName.Text = "Calculator C# Silverlight";
            this.Version.Text = String.Format("Version {0}", "1.0.0.0");
            this.Copyright.Text = "Copyright © Richard W. Allen 2010";
            this.CompanyName.Text = "N\\A";
            this.BoxDescription.Text = "A calculator coded in C# Silverlight 4";
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}

