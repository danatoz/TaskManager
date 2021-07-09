﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ToDoWPFTest.ViewModels.Base
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field,value)) return false;
            field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }
    }
}
