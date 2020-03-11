using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiaisonDonnées
{
    class Donnees
    {
        private List<Diplôme> lesDiplomes;
        private List<Service> lesServices;
        private List<Employe> lesEmployes; 
        public void AfficherDiplomes()
        {
            for (int i = 0; i < lesDiplomes.Count; i++)
            {
                Console.WriteLine(lesDiplomes[i].ToString());
            }
        }
        public void AfficherServices()
        {
            for (int i = 0; i < lesServices.Count; i++)
            {
                Console.WriteLine(lesServices[i].ToString());
            }
        }
        public void AfficherEmployes()
        {
            for (int i = 0; i < lesEmployes.Count; i++)
            {
                Console.WriteLine(lesEmployes[i].ToString());
            }
        }
        public void AjouterService()
        {

        }
    }
}
