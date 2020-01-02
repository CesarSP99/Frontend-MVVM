using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Student
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Nombre y Apellido")]
        public string NombreCompleto { get; set; }
        [Required]
        [Display(Name = "Registro")]
        public ulong Registro { get; set; }
        [Required]
        [Display(Name = "Docente")]
        public Docentes docentes { get; set; }
        [Required]
        [Display(Name = "Consulta")]
        [MaxLength(40)]
        public string Consulta { get; set; }
        [Required]
        [Display(Name = "Fecha")]
        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }
    }
    public enum Docentes
    {
        Carlos_Huanca,
        Igor_Garcia,
        Alberto_Lopez
    }
}