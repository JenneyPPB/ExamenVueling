﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Domain.Entities
  {

    public class AlumnoEntity
   {
    int Id { get; set; }
    string Nombre { get; set; }
    string Apellido { get; set; }
    int Dni { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public int Edad { get; set; }
   }
 }


