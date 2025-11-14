using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionAcademica_ViewModels.Models
{
    public class AlumnoCursoProfesorViewModel
    {
        public int AlumnoId { get; set; }
        public string AlumnoNombre { get; set; }
        public string CursoNombre { get; set; }
        public string ProfesorNombre { get; set; }

    }
}