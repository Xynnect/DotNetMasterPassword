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
using WpfMasterPassword.ViewModel;

namespace WpfMasterPassword
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class MainWindow_DesignTimeData : DocumendViewModel
    {
        public MainWindow_DesignTimeData()
        {
            Config.UserName.Value = "John Doe";

            var site = new ConfigurationSiteViewModel();
            site.SiteName.Value = "ebay.com";
            site.Login.Value = "jdoe@gmail.com";
            site.Counter.Value = 3;
            Config.Sites.Add(site);

            site = new ConfigurationSiteViewModel();
            site.SiteName.Value = "ripeyesteaks.com";
            site.Login.Value = "john@gorgelmail.com";
            Config.Sites.Add(site);

            site = new ConfigurationSiteViewModel();
            site.SiteName.Value = "othersite.com";
            site.Login.Value = "doe@john.org";
            Config.Sites.Add(site);
        }
    }
}
