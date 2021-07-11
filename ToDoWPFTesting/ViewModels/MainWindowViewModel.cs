using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ToDoWPFTesting.Models;
using ToDoWPFTesting.ViewModels.Base;

namespace ToDoWPFTesting.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна
        private string _title = "Hello world!";
        

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }
        #endregion

        #region Checkbox Test
        private Model _model = new Model();
        private const string Msg1 = "blah 1";
        private const string Msg2 = "blah 2";
        private ObservableCollection<Model> taskCollection;
        private ObservableCollection<Model> taskDoneCollection;

        private void MoveTaskDone()
        {

        }
        public bool IsSelected
        {
            get => _model.CheckBoxTest;
            set
            {
                if(_model.CheckBoxTest == value) return;
                _model.CheckBoxTest = value;
                MyBoundMessage = _model.CheckBoxTest ? Msg1 : Msg2;
                OnPropertyChanged("IsSelected");
                OnPropertyChanged("MyBoundMessage");
            }
        }
        public string MyBoundMessage { get; set; }
        #endregion
    }
}
