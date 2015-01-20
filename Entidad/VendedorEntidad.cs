using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class VendedorEntidad
    {
        
        //Entidades que estan en la tabla en sql
        //encapsulamiento de las entidades 
        public int idVendedor { get; set; }
        public string nombreVende { get; set; }
        public string apeVende { get; set; }
        public int dniVende { get; set; }
        public string direcVende { get; set; }
        public string celularVende { get; set; }
        public string telVende { get; set; }

    }
}
