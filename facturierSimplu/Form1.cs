using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturierSimplu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //facturier
        public facturier facturiernou = new facturier();
        factura fact1 = new factura();
        inregistrare inregnoua = new inregistrare();
        compania comp1 = new compania();
        persoana pers1 = new persoana();
        persoana pers2 = new persoana();
        persoana pers3 = new persoana();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //inregistrare
            inregnoua.codinregistrare = "1";
            inregnoua.denumire = "apa plata";
            inregnoua.codprodus = "1";
            inregnoua.um = "bucati";
            inregnoua.cantitate = 1;
            inregnoua.pretunitarfaratva = 2.0f;
            inregnoua.cotatva = 19.0f;
            inregnoua.calcvaloare();
            inregnoua.calcvaloaretva();

           //factura
            fact1.codfactura = "1";
            fact1.codcompania= "1";
            fact1.codpersoana = "1";
            fact1.data = DateTime.Now ;
            fact1.nraviz = "1";
            fact1.coddelegat = "2";
            fact1.codmijlocdetransport = "1";
            fact1.inregistrari.Add(new inregistrare());
            fact1.inregistrari[0] = inregnoua;



            //persoane
            pers1.codpersoana = "1";
            pers1.nume = "maria";
            pers1.prenume = "iulia";
            pers1.datanasterii=DateTime.Now;
            pers1.adresa = "strada nrstrada blo nrbloc casa nrcasa etaj nretaj apartament nrapartament";
            pers1.judet = "sibiu";
            pers1.oras = "sibiu";
            pers1.serieci = "sb";
            pers1.numarci = "794732";
            pers1.eliberatde = "ipj sibiu";
            pers1.cnp = "9327498327498327";

            pers2.codpersoana = "2";
            pers2.nume = "calin";
            pers2.prenume = "marius";
            pers2.datanasterii = DateTime.Now;
            pers2.adresa = "strada nrstrada blo nrbloc casa nrcasa etaj nretaj apartament nrapartament";
            pers2.judet = "sibiu";
            pers2.oras = "sibiu";
            pers2.serieci = "sb";
            pers2.numarci = "4321";
            pers2.eliberatde = "ipj sibiu";
            pers2.cnp = "4234321353534534";

            pers3.codpersoana = "3";
            pers3.nume = "mircea";
            pers3.prenume = "ispas";
            pers3.datanasterii = DateTime.Now;
            pers3.adresa = "strada nrstrada blo nrbloc casa nrcasa etaj nretaj apartament nrapartament";
            pers3.judet = "sibiu";
            pers3.oras = "sibiu";
            pers3.serieci = "sb";
            pers3.numarci = "4432";
            pers3.eliberatde = "ipj sibiu";
            pers3.cnp = "93827493287493287";

            //companie
            comp1.codcompania = "1";
            comp1.datainfintarii = DateTime.Now;
            comp1.denumirea = "dimiter livrari";
            comp1.formajuridica = "sc srl";
            comp1.nrinregistrareinregistrulcomertului = "6872648732648732";
            comp1.anulinregistrarii = "2009";
            comp1.cui = "371928379821d9287398hdd9289";
            comp1.sediul= "strada nrstrada blo nrbloc casa nrcasa etaj nretaj apartament nrapartament";
            comp1.judetul="sibiu";
            comp1.contul = "9827391283712983rba0938210318203";
            comp1.banca = "banca reiffasein sibiu";

            //calcule
            fact1.calculareTotalValoare();
            fact1.calculareTotalTVA();
            fact1.calculareTotalDePlata();

           //facturier date
            facturiernou.denumire = "facturier nou sc alfa srl";
            facturiernou.codpersoana= "3";
            facturiernou.codfacturier = "2";
            facturiernou.datalansarii = DateTime.Now;
            facturiernou.addNewFactura(new factura());
            facturiernou.facturi[0] = fact1;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //afisare 

            //date facturier
            textBox1.Text += "\r\n DATE FACTURIER \r\n";

            textBox1.Text += facturiernou.denumire;
            textBox1.Text += " ;";
            textBox1.Text += facturiernou.codpersoana;
            textBox1.Text += " ;";
            textBox1.Text += facturiernou.codfacturier;
            textBox1.Text += " ;";
            textBox1.Text += facturiernou.datalansarii.ToString();
            textBox1.Text += " ;";
            textBox1.Text += facturiernou.facturi.Count.ToString();
            textBox1.Text += " ;";
            textBox1.Text += "\r\n DATE FACTURIER \r\n";

            //date factura
            textBox1.Text += "\r\n DATE FACTURA \r\n";

            textBox1.Text += fact1.codfactura;
            textBox1.Text += " ;";
            textBox1.Text += fact1.codcompania;
            textBox1.Text += " ;";
            textBox1.Text += fact1.codpersoana;
            textBox1.Text += " ;";
            textBox1.Text += fact1.data.ToString();
            textBox1.Text += " ;";
            textBox1.Text += fact1.nraviz;
            textBox1.Text += " ;";
            textBox1.Text += fact1.coddelegat;
            textBox1.Text += " ;";
            textBox1.Text += fact1.codmijlocdetransport;
            textBox1.Text += " ;";
            textBox1.Text += fact1.totaldeplata.ToString();
            textBox1.Text += " ;";
            textBox1.Text += fact1.totalvaloare.ToString();
            textBox1.Text += " ;";
            textBox1.Text += fact1.totaltva.ToString();
            textBox1.Text += " ;";
            textBox1.Text += "\r\n DATE FACTURA \r\n";

            //date companie
            textBox1.Text += " \r\n DATE COMPANIA \r\n";
            
            textBox1.Text += comp1.codcompania;
            textBox1.Text += " ;";
            textBox1.Text += comp1.datainfintarii.ToString();
            textBox1.Text += " ;";
            textBox1.Text += comp1.denumirea;
            textBox1.Text += " ;";
            textBox1.Text += comp1.formajuridica;
            textBox1.Text += " ;";
            textBox1.Text += comp1.nrinregistrareinregistrulcomertului;
            textBox1.Text += " ;";
            textBox1.Text += comp1.anulinregistrarii;
            textBox1.Text += " ;";
            textBox1.Text += comp1.cui;
            textBox1.Text += " ;";
            textBox1.Text += comp1.sediul;
            textBox1.Text += " ;";
            textBox1.Text += comp1.judetul;
            textBox1.Text += " ;";
            textBox1.Text += comp1.contul;
            textBox1.Text += " ;";
            textBox1.Text += comp1.banca;
            textBox1.Text += " ;";
            textBox1.Text += " \r\n DATE COMPANIA \r\n";

            //date persoana
            textBox1.Text += "\r\n DATE PERSOANA 1 \r\n";

            textBox1.Text += pers1.codpersoana;
            textBox1.Text += " ;";
            textBox1.Text += pers1.nume;
            textBox1.Text += " ;";
            textBox1.Text += pers1.prenume;
            textBox1.Text += " ;";
            textBox1.Text += pers1.datanasterii;
            textBox1.Text += " ;";
            textBox1.Text += pers1.adresa;
            textBox1.Text += " ;";
            textBox1.Text += pers1.judet;
            textBox1.Text += " ;";
            textBox1.Text += pers1.oras;
            textBox1.Text += " ;";
            textBox1.Text += pers3.serieci;
            textBox1.Text += " ;";
            textBox1.Text += pers1.numarci;
            textBox1.Text += " ;";
            textBox1.Text += pers1.eliberatde;
            textBox1.Text += " ;";
            textBox1.Text += pers1.cnp;
            textBox1.Text += " ;";
            textBox1.Text += "\r\n DATE PERSOANA 1 \r\n";


            textBox1.Text += "\r\n DATE PERSOANA 2 \r\n";

            textBox1.Text += pers2.codpersoana;
            textBox1.Text += " ;";
            textBox1.Text += pers2.nume;
            textBox1.Text += " ;";
            textBox1.Text += pers2.prenume;
            textBox1.Text += " ;";
            textBox1.Text += pers2.datanasterii;
            textBox1.Text += " ;";
            textBox1.Text += pers2.adresa;
            textBox1.Text += " ;";
            textBox1.Text += pers2.judet;
            textBox1.Text += " ;";
            textBox1.Text += pers2.oras;
            textBox1.Text += " ;";
            textBox1.Text += pers2.serieci;
            textBox1.Text += " ;";
            textBox1.Text += pers2.numarci;
            textBox1.Text += " ;";
            textBox1.Text += pers2.eliberatde;
            textBox1.Text += " ;";
            textBox1.Text += pers2.cnp;
            textBox1.Text += " ;";
            textBox1.Text += "\r\n DATE PERSOANA 2 \r\n";

            //date delegat
            textBox1.Text += "\r\n DATE DELEGAT \r\n";

            textBox1.Text += pers3.codpersoana;
            textBox1.Text += " ;";
            textBox1.Text += pers3.nume;
            textBox1.Text += " ;";
            textBox1.Text += pers3.prenume;
            textBox1.Text += " ;";
            textBox1.Text += pers3.datanasterii;
            textBox1.Text += " ;";
            textBox1.Text += pers3.adresa;
            textBox1.Text += " ;";
            textBox1.Text += pers3.judet;
            textBox1.Text += " ;";
            textBox1.Text += pers3.oras;
            textBox1.Text += " ;";
            textBox1.Text += pers3.serieci;
            textBox1.Text += " ;";
            textBox1.Text += pers3.numarci;
            textBox1.Text += " ;";
            textBox1.Text += pers3.eliberatde;
            textBox1.Text += " ;";
            textBox1.Text += pers3.cnp;
            textBox1.Text += " ;";
            textBox1.Text += "\r\n DATE DELEGAT \r\n";





            //date aviz
            //not included
            //date mijlocdetransport
            //not included

            //date inregistrari
            textBox1.Text += "\r\n DATE inregistrari \r\n";

            textBox1.Text += inregnoua.codinregistrare;
            textBox1.Text += " ;";
            textBox1.Text += inregnoua.denumire;
            textBox1.Text += " ;";
            textBox1.Text += inregnoua.codprodus;
            textBox1.Text += " ;";
            textBox1.Text += inregnoua.um;
            textBox1.Text += " ;";
            textBox1.Text += inregnoua.cantitate;
            textBox1.Text += " ;";
            textBox1.Text += inregnoua.pretunitarfaratva;
            textBox1.Text += " ;";
            textBox1.Text += inregnoua.cotatva;
            textBox1.Text += " ;";
            textBox1.Text += inregnoua.valoare.ToString();
            textBox1.Text += " ;";
            textBox1.Text += inregnoua.valoaretva.ToString();
            textBox1.Text += " ;";
            textBox1.Text += "\r\n DATE inregistrari \r\n";

            //date produs
            //not included
            //date serviciu
            //not included


            //verificati daca inregistrarea si toate datele au fost introduse si in lista de inregitrari
            //iar facturi in lista de facturi
            //un exemplu de cum se poate crea o aplicatie insa lipseste bazele de date
        }
    }
}
