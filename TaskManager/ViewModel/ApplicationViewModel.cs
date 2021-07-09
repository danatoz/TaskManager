using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Input;
using TaskManager.Model;

namespace TaskManager.ViewModel
{
    class ApplicationViewModel : Base.ViewModel
    {
        private Model.Task _selectedTask;
        public ObservableCollection<Model.Task> Tasks { get; set; }
        public ObservableCollection<Model.Task> TasksDone { get; set; }
        public ObservableCollection<Model.Task> TasksMyDay { get; set; }


        private RelayCommand _addCommand;
        private RelayCommand _removeCommand;

        private RelayCommand _taskIsDone;
        //private RelayCommand _taskIsDone;

        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??= new RelayCommand(obj =>
                {
                    Model.Task task = new Task();
                    Tasks.Insert(0, task);
                    SelectedTask = task;
                });
            }
        }


        public RelayCommand RemoveCommand
        {
            get
            {
                return _removeCommand ?? (_removeCommand = new RelayCommand(obj =>
                {
                    Model.Task task = obj as Task;
                    if (task != null)
                    {
                        Tasks.Remove(task);
                    }
                }, (obj) => Tasks.Count > 0));
            }
        }

        public RelayCommand TaskIsDone
        {
            get
            {
                return _taskIsDone ?? (_taskIsDone = new RelayCommand(obj =>
                {
                    Model.Task task = obj as Task;
                    if (task != null)
                    {
                        Tasks.Remove(task);
                    }
                }, (obj) => Tasks.Count > 0));
            }
        }




        public Model.Task SelectedTask
        {
            get => _selectedTask;

            set
            {
                _selectedTask = value;
                OnPropertyChanged("SelectedTask");
            }
        }

        public ApplicationViewModel()
        {
            TasksDone = new ObservableCollection<Model.Task>();
            TasksMyDay = new ObservableCollection<Model.Task>();
            Tasks = new ObservableCollection<Task>
            {
                new Model.Task()
                {
                    Id = 0,
                    HeaderTask = "Hello world!",
                    TaskIsDone = true,
                    RepeatTask = true,
                    DeadLine = "20.07.2021",
                    DateOfCreation = DateTime.Now.ToString(CultureInfo.InvariantCulture)
                },
                new Model.Task()
                {
                    Id = 1,
                    HeaderTask = "Two task",
                    TaskIsDone = false,
                    RepeatTask = true,
                    DeadLine = "20.07.2021",
                    DateOfCreation = DateTime.Now.ToString(CultureInfo.InvariantCulture)
                },
                new Model.Task()
                {
                    Id = 2,
                    HeaderTask = "Next task",
                    TaskIsDone = true,
                    RepeatTask = false,
                    DeadLine = "20.07.2021",
                    DateOfCreation = DateTime.Now.ToString(CultureInfo.InvariantCulture)
                }

            };
        }
    }
}
