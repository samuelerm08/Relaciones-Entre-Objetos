using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesEntreObjetos.Caso_5
{
    public class DatosContacto
    {
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public List<Cliente> Clientes { get; set; }
        public Empleado Empleado { get; set; }
    }
}
