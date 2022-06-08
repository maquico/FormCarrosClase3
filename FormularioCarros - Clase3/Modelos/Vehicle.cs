using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioCarros___Clase3.Modelos
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int ColorId { get; set; }

        public int TipoId { get; set; }
        public string Matricula { get; set; }

        public int MarcaId { get; set; }

        public int ModeloId { get; set; }

        public int Año { get; set; }
        public string Descripcion { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }



    }
}
