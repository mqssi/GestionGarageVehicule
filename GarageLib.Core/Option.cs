using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLib.Core
{

    public class Option
    {



        private string nom;

        private decimal prix;


        public string Nom { get => nom; set => nom = value; }
        public decimal Prix { get => prix; set => prix = value; }

        public Option(string nom, decimal prix) 
        {
            Nom = nom;
            Prix = prix;
            
        }


        public string RecupOption()
        {

            return nom;

        }




    }




}
