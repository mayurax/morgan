﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Morgan
{
    /// <summary>
    /// View Model for the state of the Entire Application
    /// </summary>
    public class ApplicationViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// List of root music directories that the user has selected
        /// </summary>
        public ObservableCollection<string> LocationList { get; set; } = new ObservableCollection<string>();


        /// <summary>
        /// Backing field for the application page
        /// </summary>
        ApplicationPage _applicationPage = ApplicationPage.None;

        /// <summary>
        /// Controls the currently visible page of the application
        /// </summary>
        public ApplicationPage CurrentPage
        {
            get => _applicationPage;
            set
            {
                if (value == _applicationPage)
                    return;
                _applicationPage = value;
                OnPropertyChanged();
            }
        }

        #endregion
    }
}
