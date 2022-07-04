using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Adapter;
using TrainingApp.Strategy;

namespace TrainingApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Session session = new Session();
            int option = 0;
            do
            {
                Console.Clear();
            Console.WriteLine($"|       Team FC       |\n|---------------------|\n|         Menu        |" +
                $"\n|1. Scedule" +
                $"\n|2. Squad" +
                $"\n|3. Exit");

                try
                {
                    option = int.Parse(Console.ReadLine());

                    //init when choice value is 1, 2 or 3 only
                    if (option > 0 && option < 4)
                    {
                        switch (option)
                        {
                            case 1:
                                //using strategypattern
                                Console.Clear();
                                Console.WriteLine($"1. Matches\n2. Trainings ");
                                var input = int.Parse(Console.ReadLine());
                                StrategyExecutor(input, session);
                                

                                break;

                            case 2:
                                //Using adapter pattern
                                SquadAdaptee adaptee = new SquadAdaptee();
                                ITarget target = new SquadAdapter(adaptee);
                                target.GetPlayersList();
                                break;

                            case 3:
                                Console.WriteLine("Exiting...");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("This option does not exist");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            } while (option != 3);
        }

        //static method to return the right value for user input to init strategy pattern.
        public static void StrategyExecutor(int input, Session session) 
        {
            //only 1 and 2 is choosable
            if (input == 1)
            {
                session.SetSession(new MatchSession());
                session.Show();
            }
            else if (input == 2)
            {
                session.SetSession(new TrainingSession());
                session.Show();
            }
            else
            {
                Console.WriteLine("Wrong input was entered. Try again!");
            }
        }
    }
}

