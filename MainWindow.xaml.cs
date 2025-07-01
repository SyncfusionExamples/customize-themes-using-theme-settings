#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.SfSkinManager;
using Syncfusion.Themes.Windows11Light.WPF;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGrid_Themes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Windows11LightThemeSettings windows11LightThemeSettings = new Windows11LightThemeSettings();
            windows11LightThemeSettings.PrimaryBackground = new SolidColorBrush(Colors.Red);
            windows11LightThemeSettings.PrimaryForeground = new SolidColorBrush(Colors.AntiqueWhite);
            windows11LightThemeSettings.BodyFontSize = 15;
            windows11LightThemeSettings.HeaderFontSize = 18;
            windows11LightThemeSettings.SubHeaderFontSize = 17;
            windows11LightThemeSettings.TitleFontSize = 17;
            windows11LightThemeSettings.SubTitleFontSize = 16;
            windows11LightThemeSettings.BodyAltFontSize = 15;
            windows11LightThemeSettings.FontFamily = new FontFamily("Callibri");
            SfSkinManager.RegisterThemeSettings("Windows11Light", windows11LightThemeSettings);
            SfSkinManager.ApplyThemeAsDefaultStyle = true;
            SfSkinManager.SetTheme(this, new Theme("Windows11Light"));
            InitializeComponent();
            
        }        
    }
}
