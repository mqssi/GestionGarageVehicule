using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLib.Core
{



    public class VehiculesIsEmptyException : Exception
    {

        public VehiculesIsEmptyException() : base("Aucun vehicule présent")
        {

        }

    }


    public class OptionIsEmptyException : Exception
    {

        public OptionIsEmptyException() : base("Aucune option présente")
        {

        }

    }


    public class MoteurIsEmptyException : Exception
    {

        public MoteurIsEmptyException() : base("Aucun moteur présent")
        {

        }

    }

    public class Garage
        {







        private string nom;

        private string adresse;




        List<Vehicule> vehicules = new List<Vehicule>();
        List<Moteur> moteurs = new List<Moteur>();
        List<Option> options = new List<Option>();


        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
       

        public Garage(string nom, string adresse)
        {
            
            Nom = nom;
            Adresse = adresse;
            

        }


        public void Tri()
            {
            vehicules.Sort();

            }


        public void AfficherTri()
        {

            for (int i = 0; i < vehicules.Count; i++)
            {
                
                Console.WriteLine(string.Format("------- Tri par prix du garage {0} : {1}  {2} {3} euros ---- ", Nom, vehicules[i].Marque, vehicules[i].Nom, vehicules[i].Prix));
            }


        }

            public string RecupNom()
            {

            return nom;


            }

        public void AfficherVehicule()
        {
            
            
            for (int i = 0; i < vehicules.Count; i++)
            {

                Console.WriteLine(string.Format("Vehicules dans le garage {0} :   {1} {2}", Nom, vehicules[i].Nom, vehicules[i].Marque));
                Console.WriteLine(string.Format(""));
            }

            if(vehicules.Count()== 0)
            {

                throw new VehiculesIsEmptyException();
            }
           

        }


        public void AjouterVehicule(Vehicule vehicule)
        {

            vehicules.Add(vehicule);

        }


        public void AjouterMoteur(Moteur moteur)
        {

            moteurs.Add(moteur);

        }


        public void AjouterOption(Option option)
        {

            options.Add(option);

        }







    }

}
