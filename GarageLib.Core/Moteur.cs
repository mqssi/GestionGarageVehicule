using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLib.Core
{


    public class Moteur
    {



        private string type;

        private int puissance;

        public string Type { get => type; set => type = value; }
        public int Puissance { get => puissance; set => puissance = value; }

        public Moteur(string type, int puissance)
        {
            Type = type;
            Puissance = puissance;
        }

        public string RecupMoteur()
        {
            return type;
        }


    }








    }
