using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Input;
using TaskManager.Infrastructure;
using TaskManager.Model;

namespace TaskManager.ViewModel
{
    class MainWindowViewModel : Base.ViewModel
    {
        private Model.Task _selectedTask;
        public ObservableCollection<Model.Task> Tasks { get; set; }
        public ObservableCollection<Model.Task> TasksDone { get; set; }
        public ObservableCollection<Model.Task> TasksMyDay { get; set; }

        #region Command
        #region Add and remove command
        private RelayCommand _addCommand;
        private RelayCommand _removeCommand;

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

        #endregion

        #region Close App
        public ICommand CloseApplicationCommand { get; set; }
        private bool CanCloseApplicationCommandExecuted(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }



        #endregion

        #region TransferTaskCommand

        private RelayCommand _transferTaskCommand;

        public RelayCommand TransferTaskCommand
        {
            get
            {
                return _transferTaskCommand ??= new RelayCommand(obj =>
                {
                    if (SelectedTask.TaskIsDone)
                    {
                        
                    }
                });
            }
        }

        #endregion

        #region MyRegion
        private RelayCommand _myDayTaskCommand;

        public RelayCommand MyDayTaskCommand
        {
            get
            {
                return _myDayTaskCommand ??= new RelayCommand(obj =>
                {
                    Tasks.Clear();
                    foreach (var t in TasksMyDay)
                    {
                        Tasks.Insert(0, t);
                    }
                });
            }
        }

        #endregion
        #endregion


        public bool TaskIsDone
        {
            get => SelectedTask.TaskIsDone;
            set
            {
                if(SelectedTask.TaskIsDone == value) return;
                SelectedTask.TaskIsDone = value;
                OnPropertyChanged("TaskIsDone");
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

        public MainWindowViewModel()
        {
            #region Commands
            CloseApplicationCommand = new RelayCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecuted);


            #endregion
            TasksDone = new ObservableCollection<Model.Task>();
            TasksMyDay = new ObservableCollection<Model.Task>()
            {
                new Model.Task()
                {
                    Id = 4,
                    HeaderTask = "MyDayNow",
                    TaskIsDone = true,
                    RepeatTask = true,
                    DeadLine = "20.07.2021",
                    DateOfCreation = DateTime.Now.ToString(CultureInfo.CurrentCulture)
                },
                new Model.Task()
                {
                    Id = 4,
                    HeaderTask = "Every day",
                    TaskIsDone = true,
                    RepeatTask = true,
                    DeadLine = "20.07.2021",
                    DateOfCreation = DateTime.Now.ToString(CultureInfo.CurrentCulture)
                },
            };
            Tasks = new ObservableCollection<Task>
            {
                new Model.Task()
                {
                    Id = 0,
                    HeaderTask = "Hello world!",
                    TaskIsDone = true,
                    RepeatTask = true,
                    DeadLine = "20.07.2021",
                    DateOfCreation = DateTime.Now.ToString(CultureInfo.CurrentCulture)
                },
                new Model.Task()
                {
                    Id = 1,
                    HeaderTask = "Two task",
                    TaskIsDone = false,
                    RepeatTask = true,
                    DeadLine = "20.07.2021",
                    DateOfCreation = DateTime.Now.ToString()
                },
                new Model.Task()
                {
                    Id = 2,
                    HeaderTask = "Next task",
                    TaskIsDone = true,
                    RepeatTask = false,
                    DeadLine = "20.07.2021",
                    DateOfCreation = DateTime.Now.ToString()
                }

            };
        }
    }
}
