using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiaisonDonnées
{
    class Diplôme
    {
        int id;
        List<Employe> lesEmployes;
        string libelle;
        public int ID
        {
            get
            {
                return id;
            }
        }
        public List<Employe> LesEmploye
        {
            get
            {
                return this.lesEmployes;
            }
        }
        public string Libelle
        {
            get
            {
                return this.libelle;
            }
        }
    }
}
