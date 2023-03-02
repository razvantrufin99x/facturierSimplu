using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturierSimplu
{
    public class facturier
    {
        public string codfacturier;
        public string codpersoana;
        public string denumire;
        public DateTime datalansarii = new DateTime();
        public List<factura> facturi = new List<factura>();

        public void addNewFactura(factura f)
        { 
            facturi.Add(f);

        }

    }
}
