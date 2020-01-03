using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.ViewModels
{
    public class MainViewModel
    {

        #region Properties
        public List<Student> ListStudent { get; set; }
        #endregion

        #region ViewModel
        public StudentViewModel studentViewModel { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            instance = this;
            this.studentViewModel = new StudentViewModel();
        }
        #endregion

        #region singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new MainViewModel();
            }
            return (instance);
        }
        #endregion
    }
}
