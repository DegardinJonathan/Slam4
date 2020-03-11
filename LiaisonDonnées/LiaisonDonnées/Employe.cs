using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiaisonDonnées
{
    class Employe
    {
        byte cadre;
        int id;
        string nom;
        string prenom;
        decimal salaire;
        char sexe;
        List<Diplôme> lesDiplômes;
        Service leService;

        public byte Cadre
        {
            get
            {
                return this.cadre;
            }
        }
        public int GetId
        {
            get
            {
                return this.id;
            }
        }
        public string Nom
        {
            get
            {
                return this.nom;
            }
        }
        public decimal Salaire
        {
            get
            {
                return this.salaire;
            }
        }
        public char Sexe
        {
            get
            {
                return this.sexe;
            }
        }
        public string Prenom
        {
            get
            {
                return this.prenom;
            }
        }
       public List<Diplôme> LesDiplomes
        {
            get
            {
                return this.lesDiplômes;

            }
        }
        public Service LeService
        {
            get
            {
                return this.leService;
            }
        }
        public string StrSexe()
        {
            if(this.sexe == 'M')
            {
                return "Homme";
            }
            else
            {
                return "Femme";
            }
        }
        public Employe(byte cadre, int id, string nom, string prenom, decimal salaire,char sexe,Service leService)
        {
            this.cadre = cadre;
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.salaire = salaire;
            this.sexe = sexe;
            this.leService = leService;
        }
        public string ToString()
        {
            return string.Format("Nom : {0}\nPrénom : {1}\nSexe :{2}\nSalaire : {3}\nCadre : {4}\n",this.nom,this.prenom,this.sexe,this.salaire,this.cadre);
        }

    }
}
