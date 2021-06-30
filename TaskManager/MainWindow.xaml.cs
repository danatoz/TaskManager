using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using TaskManager.Mock;
using TaskManager.Model;

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Model.Task> CollectionTasks;
        public MainWindow()
        {
            InitializeComponent();
            CollectionTasks = new ObservableCollection<Model.Task>();
            lbAllTask.ItemsSource = CollectionTasks;
            CollectionTasks.Add(
                new Model.Task() { HeaderTask = "Hello world!", TaskDone = false, RepeatTask = true}
            );
        }

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
