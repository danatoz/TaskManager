using System;
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
using TaskManager.Mock;
using TaskManager.Model;
using Task = TaskManager.Model.Task;

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Model.Task> CollectionTasks { get; set; }
        public ObservableCollection<Model.Task> CollectionTasksDone { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            CollectionTasksDone = new ObservableCollection<Task>();
            CollectionTasks = new ObservableCollection<Model.Task>(){
                new Model.Task()
                {
                    Id = 0,
                    HeaderTask = "Hello world!",
                    TaskDone = false,
                    RepeatTask = true,
                    DeadLine = "20.07.2021",
                    DateOfCreation = DateTime.Now.ToString(CultureInfo.InvariantCulture)
                },
                new Model.Task()
                {
                    Id = 1,
                    HeaderTask = "Two task",
                    TaskDone = false,
                    RepeatTask = true,
                    DeadLine = "20.07.2021",
                    DateOfCreation = DateTime.Now.ToString(CultureInfo.InvariantCulture)
                },
                new Model.Task()
                {
                    Id = 2,
                    HeaderTask = "Next task",
                    TaskDone = true,
                    RepeatTask = false,
                    DeadLine = "20.07.2021",
                    DateOfCreation = DateTime.Now.ToString(CultureInfo.InvariantCulture)
                }
            };
            lbAllTask.ItemsSource = CollectionTasks;
        }

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lbAllTask_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Task t = (Task)lbAllTask.SelectedItem;
            //MessageBox.Show(t.HeaderTask);
        }

        private void btnRemoveTask_Click(object sender, RoutedEventArgs e)
        {
            Task t = (Task)lbAllTask.SelectedItem;
            int index = CollectionTasks.IndexOf(t);
            if (lbAllTask.SelectedItem != null && CollectionTasks.Contains(t))
            {
                CollectionTasks.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Список пуст!");
            }
            lbAllTask.ItemsSource = CollectionTasks;
        }

        private void cbDone_Checked(object sender, RoutedEventArgs e)
        {
            Task t = (Task)lbAllTask.SelectedItem;
            int index = CollectionTasks.IndexOf(t);
            if (t != null)
            {
                try
                {
                    
                    CollectionTasksDone.Add(new Model.Task
                    {
                        Id = t.Id,
                        HeaderTask = t.HeaderTask,
                        TaskDone = t.TaskDone,
                        RepeatTask = t.RepeatTask,
                        DeadLine = t.DeadLine,
                        //Completed = t.Completed,
                        DateOfCreation = t.DateOfCreation

                    });
                    //CollectionTasksDone.Add(t);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }

            }

            CollectionTasks.RemoveAt(index);
        }

        private void cbDone_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void btnTaskDone_Click(object sender, RoutedEventArgs e)
        {
            lbAllTask.ItemsSource = null;
            lbAllTask.ItemsSource = CollectionTasksDone;
        }
    }
}
