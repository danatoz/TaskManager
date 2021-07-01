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
using Task = TaskManager.Model.Task;

namespace TaskManager
{
    public class Phone
    {
        public int Id { get; set; }
        public string Title { get; set; } // модель телефона
        public string Company { get; set; } // производитель
        public string ImagePath { get; set; } // путь к изображению
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Model.Task> CollectionTasks { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            CollectionTasks = new ObservableCollection<Model.Task>(){
                new Model.Task() {Id = 1, HeaderTask = "Hello world!", TaskDone = false, RepeatTask = true},
                new Model.Task() {Id = 2, HeaderTask = "Two task", TaskDone = false, RepeatTask = true},
                new Model.Task() {Id = 3, HeaderTask = "Next task", TaskDone = true, RepeatTask = false}
            };
            lbAllTask.ItemsSource = CollectionTasks;
        }

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lbAllTask_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Task t = (Task)lbAllTask.SelectedItem;
            MessageBox.Show(t.HeaderTask);
        }

        private void btnRemoveTask_Click(object sender, RoutedEventArgs e)
        {
            Task t = (Task)lbAllTask.SelectedItem;
            if (CollectionTasks != null)
            {
                CollectionTasks.RemoveAt(t.Id);
            }
            else
            {
                MessageBox.Show("Список пуст!");
            }
        }
    }
}
