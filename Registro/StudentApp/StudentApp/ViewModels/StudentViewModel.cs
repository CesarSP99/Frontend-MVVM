using StudentApp.Models;
using StudentApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace StudentApp.ViewModels
{
    public class StudentViewModel : BaseViewModel
    {
        #region Attributes
        private ApiService apiService;
        private ObservableCollection<Student> students;
        #endregion

        #region Properties
        public ObservableCollection<Student> Students
        {
            get { return this.students; }
            set { SetValue(ref this.students, value); }
        }
        #endregion

        #region Constructor
        public StudentViewModel()
        {
            this.apiService = new ApiService();
            this.LoadStudents();
        }
        #endregion


        #region Method
        private async void LoadStudents()
        {
            var connection = await apiService.CheckConnection();
            if (!connection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                     "Internet Error",
                     connection.Message,
                     "Accept"
                    );
                return;
            }
            var response = await apiService.GetList<Student>(
                Ajustes.APIURL,
                "api/",
                "Students"
                );

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Service Student Error",
                    response.Message,
                    "Accept");
                return;
            }
            MainViewModel mainViewModel = MainViewModel.GetInstance();
            mainViewModel.ListStudent = (List<Student>)response.Result;

            this.Students = new ObservableCollection<Student>(this.ToStudentCollect());
        }
        private IEnumerable<Student> ToStudentCollect()
        {
            ObservableCollection<Student> collect = new ObservableCollection<Student>();
            MainViewModel main = MainViewModel.GetInstance();
            foreach (var item in main.ListStudent)
            {
                Student student = new Student();
                student.ID = item.ID;
                student.NombreCompleto = item.NombreCompleto;
                student.Registro = item.Registro;
                student.docentes = item.docentes;
                student.Consulta = item.Consulta;
                student.Fecha = item.Fecha;
                collect.Add(student);
            }
            return (collect);
        }
        #endregion
    }
}
