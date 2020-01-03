using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string NombreCompleto { get; set; }
        public ulong Registro { get; set; }
        public Docentes docentes { get; set; }
        public string Consulta { get; set; }
        public DateTime Fecha { get; set; }
    }
    public enum Docentes
    {
        Carlos_Huanca,
        Igor_Garcia,
        Alberto_Lopez
    }
}
