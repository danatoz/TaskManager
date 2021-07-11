<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
using TaskManager.Model;
using TaskManager.ViewModel;
using Task = TaskManager.Model.Task;

namespace TaskManager
=======
﻿using System.Windows;

namespace TaskManager.View
>>>>>>> branchname
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
<<<<<<< HEAD
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ApplicationViewModel();

        }

        private void MiExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
=======
        public MainWindow() => InitializeComponent();
>>>>>>> branchname
    }
}
