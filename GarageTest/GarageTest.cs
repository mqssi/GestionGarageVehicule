using GarageLib.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageTest
{
    [TestFixture]
    public class GarageTest
    {

        [Test]
        public void TestCreationOption() {

            // ARRANGE : Créer une option

            Option BoiteAuto = new Option("Boite Automatique", 158);

            // ACT : Créer une option



            // ASSERT : on valide le test

            Assert.AreEqual("Boite Automatique", BoiteAuto.Nom);

            Assert.AreEqual(158, BoiteAuto.Prix);


        }


        [Test]
        public void TestCreationMoteur()
        {

            // ARRANGE : Créer une option

            Moteur Essence = new Moteur("Essence", 320);

            // ACT : Créer une option



            // ASSERT : on valide le test

            Assert.AreEqual("Essence", Essence.Type);

            Assert.AreEqual(320, Essence.Puissance);


        }





        [Test]
        public void TestCreationVoiture()
        {

            // ARRANGE : Créer une option
            
            Moteur Diesel = new Moteur("Diesel", 50);
            Option GPS = new Option("GPS", 145);
            Voiture Renault = new Voiture("Clio", "Renault", 15000, 50, 4, 5, 6, GPS, Diesel);


            // ACT : Créer une option



            // ASSERT : on valide le test

           

            Assert.AreEqual("Clio", Renault.Nom);
            Assert.AreEqual("Renault", Renault.Marque);
            Assert.AreEqual(15000, Renault.Prix);
            Assert.AreEqual(50, Renault.Puissance);
            Assert.AreEqual(4, Renault.Nbporte);
            Assert.AreEqual(5, Renault.Nbsiege);
            Assert.AreEqual(6, Renault.Taillecoffre);
            Assert.AreEqual(GPS, Renault.Option);
            Assert.AreEqual(Diesel, Renault.Moteur);

        }





        [Test]
        public void TestCreationMoto()
        {

            // ARRANGE : Créer une option
            Option BoiteAuto = new Option("Boite Automatique", 158);
            Moteur Elec = new Moteur("Electrique", 12);
            Moto Suzuki = new Moto("Scooter", "Suzuki", 15023, 999, BoiteAuto, Elec);

            // ACT : Créer une option



            // ASSERT : on valide le test



            Assert.AreEqual("Scooter", Suzuki.Nom);
            Assert.AreEqual("Suzuki", Suzuki.Marque);
            Assert.AreEqual(15023, Suzuki.Prix);
            Assert.AreEqual(999, Suzuki.Cylindree);
            Assert.AreEqual(BoiteAuto, Suzuki.Option);
            Assert.AreEqual(Elec, Suzuki.Moteur);


        }





        [Test]
        public void TestCreationCamion()
        {

            // ARRANGE : Créer une option
            Option Clim = new Option("Climatisation", 225);
            Moteur Elec = new Moteur("Electrique", 12);
            Camion Volvo = new Camion("Camion-Citerne", "Volvo", 220505, 552, 50, 8, Clim, Elec);

            // ACT : Créer une option



            // ASSERT : on valide le test



            Assert.AreEqual("Camion-Citerne", Volvo.Nom);
            Assert.AreEqual("Volvo", Volvo.Marque);
            Assert.AreEqual(220505, Volvo.Prix);
            Assert.AreEqual(552, Volvo.Nbessieux);
            Assert.AreEqual(50, Volvo.Poidcharge);
            Assert.AreEqual(8, Volvo.Volcharge);
            Assert.AreEqual(Clim, Volvo.Option);
            Assert.AreEqual(Elec, Volvo.Moteur);


        }




        [Test]
        public void TestTaxeVoiture()
        {

            // ARRANGE : Créer une option
            Moteur Diesel = new Moteur("Diesel", 50);
            Option GPS = new Option("GPS", 145);
            Voiture Renault = new Voiture("Clio", "Renault", 15000, 50, 4, 5, 6, GPS, Diesel);



            // ACT : Créer une option

           decimal taxe =  Renault.CalculerTaxe();

            // ASSERT : on valide le test



            Assert.AreEqual(Renault.Puissance * 10, taxe) ;



        }




        [Test]
        public void TestTaxeMoto()
        {

            // ARRANGE : Créer une option
            Option BoiteAuto = new Option("Boite Automatique", 158);
            Moteur Elec = new Moteur("Electrique", 12);
            Moto Suzuki = new Moto("Scooter", "Suzuki", 15023, 999, BoiteAuto, Elec);



            // ACT : Créer une option

           decimal taxe =  Suzuki.CalculerTaxe();

            // ASSERT : on valide le test

            

            Assert.AreEqual(Convert.ToInt32(Suzuki.Cylindree * 0.3), taxe);



        }

        [Test]
        public void TestTaxeCamion()
        {

            // ARRANGE : Créer une option
            Option Clim = new Option("Climatisation", 225);
            Moteur Elec = new Moteur("Electrique", 12);
            Camion Volvo = new Camion("Camion-Citerne", "Volvo", 220505, 552, 50, 8, Clim, Elec);




            // ACT : Créer une option

            decimal taxe = Volvo.CalculerTaxe();

            // ASSERT : on valide le test



            Assert.AreEqual(Volvo.Nbessieux * 50, taxe);



        }



        [Test]
        public void TestPrixTotal()
        {

            // ARRANGE : Créer une option
            Moteur Diesel = new Moteur("Diesel", 50);
            Option GPS = new Option("GPS", 145);
            Voiture Renault = new Voiture("Clio", "Renault", 15000, 50, 4, 5, 6, GPS, Diesel);



            // ACT : Créer une option

            decimal prix = Renault.CalculerTaxe();
            decimal prixTTC = Renault.CalculerTaxe() + Renault.Prix;

            // ASSERT : on valide le test



            Assert.AreEqual((Renault.Puissance * 10 + 15000 ) , prixTTC);




        }





        [Test]
        public void TestVehiculeIsEmpty()
        {

            // ARRANGE : Créer une option

            Garage PointS = new Garage("Michelin", "7 rue de Montesquieu, Lyon 69001");


            // ACT : Créer une option

            var ex = Assert.Throws<VehiculesIsEmptyException>(() => PointS.AfficherVehicule());

            // ASSERT : on valide le test



            Assert.AreEqual(ex.Message, "Aucun vehicule présent");




        }





    }
}
