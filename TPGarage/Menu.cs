using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GarageLib.Core;

namespace TPGarage
{


    class MenuException : Exception
    {
        
        public MenuException() : base ("Le choix n'est pas compris entre 0 et 11")
        {
           
        }

   
    }






    public class Menu 
    {



        private string nom;

        private string adresse;

        private Vehicule vehicule;

        private Vehicule SelectedVehicule;



        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }


        List<Vehicule> vehicules = new List<Vehicule>();

        List<Moteur> moteurs = new List<Moteur>();
        List<Option> options = new List<Option>();


        public Garage Garage { get; private set; }
        public Vehicule Vehicule { get => vehicule; set => vehicule = value; }
        public Vehicule SelectedVehicule1 { get => SelectedVehicule; set => SelectedVehicule = value; }

        public Menu(Garage garage)
        {
             Garage = garage;
        }

        public void Start()
        {

            int choix = -1;

            do
            {
                Console.WriteLine(string.Format("********** Gestion de Garage**********"));
                Console.WriteLine(string.Format("1. Afficher les véhicules"));
                Console.WriteLine(string.Format("2. Ajouter un véhicule"));
                Console.WriteLine(string.Format("3. Sélectionner un véhicule"));
                Console.WriteLine(string.Format("3. Supprimer le véhicule"));
                Console.WriteLine(string.Format("5. Afficher les options du véhicule"));
                Console.WriteLine(string.Format("6. Ajouter des options au véhicule"));
                Console.WriteLine(string.Format("7. Supprimer des options au véhicule"));
                Console.WriteLine(string.Format("8. Afficher les options"));
                Console.WriteLine(string.Format("9. Afficher les marques"));
                Console.WriteLine(string.Format("10. Afficher les types de moteurs"));
                Console.WriteLine(string.Format("11. Sauvegarder le garage"));
                Console.WriteLine(string.Format("0. Quitter l'application"));
                Console.WriteLine(string.Format(""));

                try
                {

                    choix = GetChoixMenu();



                    switch (choix)

                    {

                        case 1:
                            Garage.AfficherVehicule();
                            break;

                        case 2:
                            AjouterVehicule();
                            break;


                        case 3:
                            SelectVehicule();
                            break;

                        case 4:
                            SupprimerVehicule();
                            break;

                        case 5:
                            AfficherOptionVehicule();
                            break;

                        case 6:
                            AjouterOptionVehicule();
                            break;

                        case 7:
                            SupprimerOptionVehicule();
                            break;

                        case 8:
                            AfficherOption();
                            break;

                        case 9:
                            AfficherMarque();
                            break;

                        case 10:
                            AfficherTypeMoteur();
                            break;

                        case 11:
                            SauvegarderGarage();
                            break;

                        default:
                            break;

                    }




                }



                catch (FormatException ex)
                {
                    Console.WriteLine("Erreur : {0}", ex.Message);
                    Start();

                }

                catch (MenuException ex)
                {
                    Console.WriteLine("Erreur : {0}", ex.Message);
                    Start();
                }



            } while ( choix != 0 );



            Console.WriteLine(string.Format("Au revoir"));


        }




        public int GetChoix()
        {

            try
            {

                Console.WriteLine(" Veuillez entrer le nombre voulu :  ");
                int choix = Convert.ToInt32(Console.ReadLine());
                
                return choix;
               

            }
            catch (FormatException)
            {
               
                throw new FormatException("Le choix saisie n'est pas un nombre. ");
                

            }

        }

        public int GetChoixMenu()
        {

            int choix = GetChoix();
            
            if (choix < 0 || choix > 11)
            {

                throw new MenuException();
            }
           
            
            return choix;
        }


        public void AjouterVehicule()
        {

            int choixCrea;
            
            Console.WriteLine(" Veuillez entrer le nom du Vehicule ");
            string nomVehicule = Console.ReadLine();
            

            Console.WriteLine(" Veuillez entrer la marque du Vehicule ");
            string marqueVehicule = Console.ReadLine();
            

            Console.WriteLine(" Veuillez entrer le prix du Vehicule (nombre) ");
            decimal prixVehicule = Convert.ToInt32(Console.ReadLine());

            Moteur Diesel = new Moteur("Diesel", 50);
            Option BoiteAuto = new Option("Boite Automatique", 158);


            Console.WriteLine(" Veuillez entrer le type du Vehicule: 1 (Voiture) 2 (moto) 3 (camion) ");
            choixCrea = Convert.ToInt32(Console.ReadLine());

            if (choixCrea == 1)
            {
                Console.WriteLine(" Veuillez entrer la puissance de la voiture");
                int puissanceVoiture = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Veuillez entrer le nombre de portes de la voiture  ");
                int nbporteVoiture = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine(" Veuillez entrer le nombre de sieges de la voiture ");
                int nbisiegeVoiture = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Veuillez entrer la taille du coffre de la voiture ");
                double taillecoffreVoiture = Convert.ToInt32(Console.ReadLine());


                Voiture voiture = new Voiture(nomVehicule, marqueVehicule, prixVehicule,  puissanceVoiture, nbporteVoiture, nbisiegeVoiture, taillecoffreVoiture, BoiteAuto, Diesel);
                Console.WriteLine(" Voiture crée ");
                Garage.AjouterVehicule(voiture);

            }
            else if (choixCrea == 2)
            {


                Console.WriteLine(" Veuillez entrer le volume cylindré de la MOTO ");
                int cylindreeMoto = Convert.ToInt32(Console.ReadLine());


                Moto moto = new Moto(nomVehicule, marqueVehicule, prixVehicule, cylindreeMoto, BoiteAuto, Diesel);
                Console.WriteLine(" Moto crée ");
                Garage.AjouterVehicule(moto);

            }
            else if (choixCrea == 3)
            {
                Console.WriteLine(" Veuillez entrer le nombre d'essieux du camion  ");
                int nbessieuxCamion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Veuillez entrerle poid de la charge du camion  ");
                double poidchargeCamion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Veuillez entrer le volume de charge du camion  ");
                int volchargeCamion = Convert.ToInt32(Console.ReadLine());

                Camion camion = new Camion(nomVehicule, marqueVehicule, prixVehicule, nbessieuxCamion, poidchargeCamion, volchargeCamion, BoiteAuto, Diesel);
                Console.WriteLine(" Camion créé ");
                Garage.AjouterVehicule(camion);
            }




        }




        public void SelectVehicule()
        {
            Garage.AfficherVehicule();





        }

        public void SupprimerVehicule()
        {


        }
        public void AfficherOptionVehicule()
        {


        }
        public void AjouterOptionVehicule()
        {


        }
        public void SupprimerOptionVehicule()
        {


        }

        public void AfficherOption()
        {


        }


        public void AfficherMarque()
        {


        }

        public void AfficherTypeMoteur()
        {


        }

        public void SauvegarderGarage()
        {


        }



    }





}
