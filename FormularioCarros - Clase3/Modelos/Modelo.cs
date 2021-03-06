using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioCarros___Clase3.Modelos
{
    public class Modelo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int TipoId { get; set; }
        public int MarcaId { get; set; }

        public bool Visible { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
