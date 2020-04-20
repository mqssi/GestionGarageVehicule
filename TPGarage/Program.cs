using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GarageLib.Core;

namespace TPGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            



            Moteur Essence = new Moteur("Essence", 320);
            Moteur Elec = new Moteur("Electrique", 12);
            Moteur Diesel = new Moteur("Diesel", 50);


            Option BoiteAuto = new Option("Boite Automatique", 158);
            Option GPS = new Option("GPS", 145);
            Option Clim = new Option("Climatisation", 225);

            Voiture Renault = new Voiture("Clio", "Renault", 15000, 50, 4, 5, 6, GPS, Diesel);
            Voiture Audi = new Voiture("A4", "Audi", 50000, 564, 8, 2, 1.5, Clim, Elec);
            Voiture Dacia = new Voiture("Smart", "Dacia", 25023, 855, 5, 4, 2.5, GPS, Essence);
            Moto Suzuki = new Moto("Scooter", "Suzuki", 15023, 999, BoiteAuto, Elec);
            Camion Volvo = new Camion("Camion-Citerne", "Volvo", 220505, 552, 50, 8, Clim, Elec);


            Garage Michelin = new Garage("Michelin", "7 rue de Montesquieu, Lyon 69001");
            Garage Points = new Garage("Point S", "54 rue de Molière, Lyon 69002");



            Menu Accueil = new Menu(Michelin);
            
            Michelin.AjouterVehicule(Suzuki);
            Michelin.AjouterVehicule(Volvo);
            Michelin.AjouterVehicule(Dacia);
            Michelin.AjouterVehicule(Renault);
            Michelin.AjouterVehicule(Audi);


            Accueil.Start();
            


           /* Dacia.AjouterOption(Clim);
            Dacia.AjouterOption(BoiteAuto);

            Dacia.AfficherResume();
            Dacia.AfficherOption();
            Dacia.AfficherPrixHT();
            Dacia.AfficherPrixTTC();
            Console.WriteLine("");


            Suzuki.AfficherResume();
            Suzuki.AfficherPrixHT();
            Suzuki.AfficherPrixTTC();
            Console.WriteLine("");


            Volvo.AfficherResume();
            Volvo.AfficherPrixHT();
            Volvo.AfficherPrixTTC();
            Console.WriteLine("");

            Michelin.AjouterVehicule(Suzuki);
            Michelin.AjouterVehicule(Volvo);
            Michelin.AjouterVehicule(Dacia);
            Michelin.AjouterVehicule(Renault);
            Michelin.AjouterVehicule(Audi);


            Michelin.AfficherVehicule();
            Console.WriteLine("");

            
            Michelin.Tri();
            Michelin.AfficherTri();         */



            Console.ReadKey();

        }
    }
}
