using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace facturierSimplu
{
    public class factura
    {
        public string codfactura;
        public string codcompania;
        public string codpersoana;
        public DateTime data = new DateTime();
        public string nraviz;
        public string semnaturasistampilafurnizor;
        public string semnaturadeprimire;
        public float totalvaloare;
        public float totaltva;
        public float totaldeplata;
        public DateTime datasioraexpedierii = new DateTime();
        public string semnaturi;
        public string coddelegat;
        public string codmijlocdetransport;
        public float cotadetva;
        public bool cotadetvaunicaperfactura=false;

        public List<inregistrare> inregistrari = new List<inregistrare>();

        public void calculareTotalValoare() 
        {
            float sumaTotalValoare=0;
            for(int i = 0;i<inregistrari.Count;i++)
            {
                sumaTotalValoare += inregistrari[i].valoare;
            }
            this.totalvaloare = sumaTotalValoare;
        }
        public void calculareTotalTVA()
        {
            float sumaTotalTVA = 0;
            for (int i = 0; i < inregistrari.Count; i++)
            {
                sumaTotalTVA += inregistrari[i].valoaretva;
            }
            this.totaltva = sumaTotalTVA;
        }
        public void calculareTotalDePlata()
        {
                    
            this.totaldeplata = totalvaloare + totaltva;
        }
        public void calcularePentruFiecareInregistrare()
        {
            
            for (int i = 0; i < inregistrari.Count; i++)
            {
                inregistrari[i].calcvaloare();
                inregistrari[i].calcvaloaretva();
            }
           
        }
    }
}
