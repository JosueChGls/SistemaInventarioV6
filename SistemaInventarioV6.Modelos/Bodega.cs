﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioV6.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nombre es Requerido")]
        [MaxLength(60, ErrorMessage = "Nombre debe ser Maxmo 60 Caracteres")]
        public string Nombre{ get; set; }

        [Required(ErrorMessage = "Nombre es Requerido")]
        [MaxLength(100, ErrorMessage="Nombre debe ser Maxmo 60 Caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Nombre es Requerido")]
        public bool Estado { get; set; }

    }
}
