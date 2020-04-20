using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLib.Core
{
    public class Camion : Vehicule
    {



        private int nbessieux;

        private double poidcharge;

        private int volcharge;

        public int Nbessieux { get => nbessieux; set => nbessieux = value; }
        public double Poidcharge { get => poidcharge; set => poidcharge = value; }
        public int Volcharge { get => volcharge; set => volcharge = value; }

        public Camion(string nom, string marque, decimal prix,int nbessieux, double poidcharge, int volcharge,  Option option, Moteur moteur) : base(nom, marque, prix, option, moteur)
        {

            Nbessieux = nbessieux;
            Poidcharge = poidcharge;
            Volcharge = volcharge;
        }


     
        public override decimal CalculerTaxe()
        {
            return Nbessieux * 50;

        }



        public override void AfficherResume()
        {
            base.AfficherResume();
            Console.WriteLine(string.Format("Nombre d'essieux : {0}", Nbessieux));
            Console.WriteLine(string.Format("Poid de Chargement : {0}", Poidcharge));
            Console.WriteLine(string.Format("Volume de chargement : {0}", Volcharge));
            Console.WriteLine("*************************************");

        }


    }
}
