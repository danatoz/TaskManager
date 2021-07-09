using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace ToDoWPFTest.ViewModels
{
    class ShellViewModel : BindableBase
    {
        #region property DisplayName

        /// <summary>
        /// Represent DisplayName property
        /// </summary>
        public string DisplayName
        {
            get => _displayName;
            set => SetProperty(ref _displayName, value);
        }

        /// <summary>
        /// Backing field for property DisplayName
        /// </summary>
        private string _displayName = "WPF PRISM (MVVM) + DI (DryIoc)";

        #endregion
    }
}
