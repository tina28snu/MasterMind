using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Game
    {
        public List<int> ListChiffres = new List<int>();

        public List<string> ToGuess = new List<string>();

        public string guess = "";

        public int coups = 0;

        public Random rdm = new Random();



        public void CreerGuess()
        {
            foreach (string s in ToGuess)
            {
                guess += s;
            }
        }

        public void GenererChiffres(string Choix)
        {
            if (Choix == "2")
            {
                for (int i = 0; i < 10; i++)
                {
                    ListChiffres.Add(rdm.Next(1, 10));
                }

                foreach (int chiffre in ListChiffres)
                {
                    ToGuess.Add("*");
                }
            }

            else if (Choix == "3")
            {
                for (int i = 0; i < 15; i++)
                {
                    ListChiffres.Add(rdm.Next(1, 10));
                }

                foreach (int chiffre in ListChiffres)
                {
                    ToGuess.Add("*");
                }
            }

            else
            {
                for (int i = 0; i < 5; i++)
                {
                    ListChiffres.Add(rdm.Next(1, 10));
                }

                foreach (int chiffre in ListChiffres)
                {
                    ToGuess.Add("*");
                }
            }
            CreerGuess();
        }

        public  void VerifierChiffre(int c)
        {
            int count = 0;
            for (int i = 0; i < ListChiffres.Count(); i++)
            {
                if (c == ListChiffres[i])
                {
                    ToGuess[i] = c.ToString();
                }
                else count++;
                guess = "";
                CreerGuess();
            }
            if (count == ListChiffres.Count())
            {
                guess += "(" + c.ToString() + ")";
            }
        }
    }
}
