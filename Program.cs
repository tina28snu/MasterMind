using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        static void Main(string[] args)
        {
            bool newJeu = true;
            Fin Fin = new Fin();

            while (newJeu == true)
            {
                Game Jeu = new Game();

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine();
                Console.WriteLine("Bienvenue au Master Mind".PadLeft(50));
                Console.WriteLine();

                Console.WriteLine("Veuillez choisir le niveau de difficulté: ".PadLeft(60));
                Console.WriteLine("1. Lvl 1 (5 chiffres)".PadLeft(44));
                Console.WriteLine("2. Lvl 2 (10 chiffres)".PadLeft(45));
                Console.WriteLine("3. Lvl 3 (15 chiffres)".PadLeft(45));

                string ChoixDif = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
            
                Jeu.GenererChiffres(ChoixDif);

                Console.WriteLine("Vos chiffres ont été génèrés.".PadLeft(50));

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.BackgroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine();
                Console.WriteLine(Jeu.guess.PadLeft(40));
                Console.WriteLine();

                Console.ResetColor();

                bool check = false;
                while (check == false)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine("Veuillez choisir un chiffre".PadLeft(50));
                    int c;
                    int.TryParse(Console.ReadLine(), out c);

                    Jeu.VerifierChiffre(c);

                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine();
                    Console.WriteLine(Jeu.guess.PadLeft(40));
                    Console.WriteLine();
                    Console.ResetColor();


                    if (Jeu.guess.IndexOf("*") == -1)
                    {
                        check = true;
                    }

                    Jeu.coups++;
                }

                Fin.count++;
                Fin.coups.Add(Jeu.coups);

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.BackgroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine();
                string msg = "Trouvé en " + Jeu.coups.ToString() + " coups.";
                Console.WriteLine(msg.PadLeft(50));

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine();
                msg = "Vous avez joué " + Fin.count + " parties.";
                Console.WriteLine(msg.PadLeft(50));

                int i = 0;
                foreach (int coup in Fin.coups)
                {
                    i++;
                    msg = "Partie " + i + ": Vous avez trouvé en  " + coup + " coups";
                    Console.WriteLine(msg.PadLeft(50));
                }

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine();
                Console.WriteLine("Voulez vous jouer une nouvelle partie? Oui/Non".PadLeft(60));

                string response = Console.ReadLine();
                Console.WriteLine();

                Console.ResetColor();

                if (response.ToLower() != "oui")
                {
                    newJeu = false;
                }
            }
            
        }

        


    }
}
