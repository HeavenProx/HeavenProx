using System;

namespace prog_du_jeu
{
    class Program
    {
        static void Main(string[] args)
        {
            //attribution des noms des joueurs
            string[] tabjoueur = new string[3];
            for (int i = 0; i < tabjoueur.Length; i++)
            {
                Console.WriteLine("Nom du joueur " + i + " :");
                tabjoueur[i] = Console.ReadLine();
            }
            //fin de l'attribution des noms des joueurs


            //partie lancer de dé
            Random aleatoire = new Random();
            int nbde = aleatoire.Next(1, 7);

            int lance(int nbde)
            {
                return nbde;
            }
            Console.WriteLine(lance(nbde));
            // fin partie lancer de dé

            Console.WriteLine("\r\n");

            //attribution des nb dans un tab
            int[] tabnb = new int[3];
            for (int i = 0; i < tabnb.Length; i++)
            {
                tabnb[i] = lance(nbde);
                Console.WriteLine(tabnb[i]);
            }
            //fin attribution des nb dans un tab



        }
    }
}
