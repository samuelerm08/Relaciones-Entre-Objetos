﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesEntreObjetos.Caso_1
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Usuario Usuario { get; set; }
    }
}

