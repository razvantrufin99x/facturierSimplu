using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturierSimplu
{
    public class inregistrare
    {
        public string codinregistrare;
        public string denumire;
        public string codprodus;
        public string codserviciu;
        public string um;
        public int cantitate;
        public float pretunitarfaratva;
        public float valoare;               //se calculeaza call calcvaloare()
        public float valoaretva;            //se calculeaza call calcvloaretva()
        public float cotatva; 


        public void calcvaloare() { 
            this.valoare = this.cantitate * this.pretunitarfaratva;
        }
        public void calcvaloaretva()
        {
           
            this.valoaretva = (this.cantitate * this.pretunitarfaratva) * (this.cotatva / 100);
        }


    }
}
