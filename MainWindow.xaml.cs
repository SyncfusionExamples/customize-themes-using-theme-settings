#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.SfSkinManager;
using Syncfusion.Themes.MaterialDark.WPF;
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
    public partial class MainWindow : ChromelessWindow
    {
        public MainWindow()
        {
            MaterialDarkThemeSettings materialDarkThemeSettings = new MaterialDarkThemeSettings();
            materialDarkThemeSettings.PrimaryBackground = new SolidColorBrush(Colors.Red);
            materialDarkThemeSettings.PrimaryForeground = new SolidColorBrush(Colors.AntiqueWhite);
            materialDarkThemeSettings.BodyFontSize = 15;
            materialDarkThemeSettings.HeaderFontSize = 18;
            materialDarkThemeSettings.SubHeaderFontSize = 17;
            materialDarkThemeSettings.TitleFontSize = 17;
            materialDarkThemeSettings.SubTitleFontSize = 16;
            materialDarkThemeSettings.FontFamily = new FontFamily("Callibri");
            SfSkinManager.RegisterThemeSettings("MaterialDark", materialDarkThemeSettings);
            SfSkinManager.SetTheme(this, new Theme("MaterialDark"));
            InitializeComponent();            
        }        
    }
}
