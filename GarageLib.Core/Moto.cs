using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLib.Core
{
    public class Moto : Vehicule
    {




        private int cylindree;



        public int Cylindree { get => cylindree; set => cylindree = value; }



        public Moto(string nom, string marque, decimal prix, int cylindree, Option option, Moteur moteur) : base(nom, marque, prix, option, moteur)
        {
            Cylindree = cylindree;

        }



        public override decimal CalculerTaxe()
        {
            
            

            return Convert.ToInt32(Cylindree * 0.3); 

        }


        public override void AfficherResume()
        {
            base.AfficherResume();
            Console.WriteLine(string.Format("Cylindrée de la moto : {0}", Cylindree));

            Console.WriteLine("*************************************");

        }





    }
}
