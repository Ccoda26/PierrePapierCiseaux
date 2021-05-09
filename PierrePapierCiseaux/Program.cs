using System;

namespace PierrePapierCiseaux
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int myvaleur = 0;
            int ordi;
            int scoreMe = 0;
            int scoreOrdi = 0;

           

            Console.WriteLine("Bienvenue pour une partie de Pierre, Papier ou Ciseaux");


            while ((scoreMe != 1) || (scoreOrdi != 1))
            {
                string input = Console.ReadLine();

                var Rand = new Random();
                string[] arme = { "ciseaux", "pierre", "papier" };
                ordi = Rand.Next(0, 2);

                if (input == "ciseaux")
                {
                    myvaleur = 1;
                }
                else if (input == "pierre")
                {
                    myvaleur = 2;
                }
                else if (input == "papier")
                {
                    myvaleur = 3;
                }
                else
                {
                    Console.WriteLine("L'outil choisi ne fait pas parti des outils du jeu");
                    Console.WriteLine("Veuilez choisir entre Pierre, Papier ou Ciseaux");
                }

                if (myvaleur != 0)
                {

                    if (input == "ciseaux")                       // cas du ciseaux
                    {
                        if (input == "ciseaux" && ordi == 2)
                        {
                            scoreMe++;
                            Console.WriteLine("you win");
                        }
                        else if (input == "ciseaux" && ordi == 0)
                        {
                            Console.WriteLine("egality");
                        }
                        else
                        {
                            scoreOrdi++;
                            Console.WriteLine("you loose");
                        }
                    }
                    else if (input == "pierre")                 // cas de la pierre
                    {
                        if (input == "pierre" && ordi == 0)
                        {
                            scoreMe++;
                            Console.WriteLine("you win");
                        }
                        else if (input == "pierre" && ordi == 1)
                        {
                            Console.WriteLine("egality");
                        }
                        else
                        {
                            scoreOrdi++;
                            Console.WriteLine("you loose");
                        }
                    }
                    else if (input == "papier")                 // cas du papier

                    {
                        if (input == "papier" && ordi == 1)
                        {
                            scoreMe++;
                            Console.WriteLine("you win");
                        }
                        else if (input == "papier" && ordi == 2)
                        {
                            Console.WriteLine("egality");
                        }
                        else
                        {
                            scoreOrdi++;
                            Console.WriteLine("you loose");
                        }
                    }

                    Console.WriteLine(input + " VS " + arme[ordi]);
                    Console.WriteLine( "Le score est de TOI : " + scoreMe + " à ordi : " + scoreOrdi);

    
                }
                else
                {
                    Console.WriteLine("tu n'as pas encore joué ou la valeur n'est pas valable");
                }


                if (scoreMe == 3)
                {
                    Console.WriteLine("Félicitations tu as gagné");
                    //break;
                }
                else
                {
                    Console.WriteLine("Dommage tu as perdu, réesaye");
                    //break;
                }
            }


           
        }
    }
}
