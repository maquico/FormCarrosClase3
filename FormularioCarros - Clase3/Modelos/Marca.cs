using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioCarros___Clase3.Modelos
{
    public class Marca
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Visible { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
