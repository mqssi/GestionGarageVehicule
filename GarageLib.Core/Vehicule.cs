using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLib.Core
{
    public abstract class Vehicule : IComparable
    {

        private int idglobal;


        private static int id;

        private string nom;

        private decimal prix;

        private string marque;

        private Moteur moteur;

        private Option option;

       


        List<Option> options = new List<Option>();


        public string Nom { get => nom; set => nom = value; }
        public decimal Prix { get => prix; set => prix = value; }
        public string Marque { get => marque; set => marque = value; }
        public Moteur Moteur { get => moteur; set => moteur = value; }
        public Option Option { get => option; set => option = value; }
        public static int Id { get => id; set => id = value; }
        public int Idglobal { get => idglobal; set => idglobal = value; }

        public Vehicule(string nom, string marque, decimal prix, Option option, Moteur moteur)
        {


            Id = id;
            Nom = nom;
            Marque = marque;
            Prix = prix;
            Option = option;
            Moteur = moteur;

            Id = Idglobal;
            Idglobal = Vehicule.id++;
            

            

            
        }



        public string RecupMarque()
        {
            return Marque;
        }





        public void AfficherPrixHT() 
        {

            Console.WriteLine(string.Format("prixHT du vehicule : {0}", Prix));
        }

    
        public void  AfficherPrixTTC() 
        {
            
            decimal prixTTC = Prix;
            prixTTC += Convert.ToDecimal(CalculerTaxe());


            Console.WriteLine(string.Format("prixTTC du vehicule : {0}", prixTTC));

        }




        public void AjouterOption(Option option)
        {

            options.Add(option);

        }


        public void AfficherOption()
        {
            for (int i = 0; i < options.Count; i++)
            {
                
                Console.WriteLine(string.Format("Options présentes du vehicule :  {0}", options[i].Nom));
            }

        }







        public abstract decimal CalculerTaxe();
        public virtual void AfficherResume()
        {
            Console.WriteLine(string.Format("ID du vehicule :  {0}", Id));
            Console.WriteLine(string.Format("nom du vehicule :  {0}", Nom));
            Console.WriteLine(string.Format("marque du vehicule : {0}", Marque));
            Console.WriteLine(string.Format("prixHT du vehicule : {0}", Prix));
            Console.WriteLine(string.Format("Option du vehicule : {0}", Option.RecupOption()));
            Console.WriteLine(string.Format("Moteur du vehicule : {0}", Moteur.RecupMoteur()));



        }







        public int CompareTo(object Vehicule)
        {
            Vehicule vehicule = (Vehicule)Vehicule;
            return Prix.CompareTo(vehicule.prix);

        }

    }
}
