using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLib.Core
{


    public class Voiture : Vehicule
    {



        private int puissance;

        private int nbporte;

        private int nbsiege;

        private double taillecoffre;


        public int Puissance { get => puissance; set => puissance = value; }

        public int Nbporte { get => nbporte; set => nbporte = value; }

        public int Nbsiege { get => nbsiege; set => nbsiege = value; }

        public double Taillecoffre { get => taillecoffre; set => taillecoffre = value; }




        public Voiture( string nom, string marque, decimal prix,int puissance,int nbporte, int nbsiege, double taillecoffre, Option option, Moteur moteur) : base(nom, marque, prix, option, moteur)
        {
            Puissance = puissance;
            Nbporte = nbporte;
            Nbsiege = nbsiege;
            Taillecoffre = taillecoffre;
            
        }



        public override decimal CalculerTaxe()
        {
            return Puissance * 10;
            
        }






        public override void AfficherResume()
        {
            base.AfficherResume();
            Console.WriteLine(string.Format("Puissance de la voiture : {0}", Puissance));
            Console.WriteLine(string.Format("Nombre de sièges de la voiture : {0}", Nbsiege));
            Console.WriteLine(string.Format("Nombre de porte de la voiture : {0}", Nbporte));
            Console.WriteLine(string.Format("Taille du coffre : {0}", Taillecoffre));

            Console.WriteLine("*************************************");

        }


    }


 






}
