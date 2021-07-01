using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        public static Random rng = new Random();        
        public static bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };


        static void Main(string[] args)
        {
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            string answer = "";

            answer = Console.ReadLine().ToLower();
            if(answer == "yes")
			{
                cont = true;
			}
			else if (answer == "no")
			{
                cont = false;
			}
            
            
            //cont = bool.Parse(answer);
			Console.WriteLine();
			if (!cont)
			{
                Console.WriteLine("Okay, bye.");
                Console.WriteLine();
			}
            if (cont)
            {
                Console.Write("We are going to need your information first! What is your name? ");
                string userName = Console.ReadLine();

                Console.WriteLine();

                Console.Write("What is your age? ");
                int userAge = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
                bool seeList = true;
                string listAnswer = Console.ReadLine().ToLower();
                if(listAnswer == "sure")
				{
                    seeList = true;
				}
				else if (listAnswer == "no thanks")
				{
                    seeList = false;
				}
                bool addToList = true;
                if (seeList)
                {
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(500);
                    }

                    Console.WriteLine();
                    Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                    
                    string addListAnswer = Console.ReadLine().ToLower();
                    if(addListAnswer == "yes")
					{
                        addToList = true;
					}
                    else if(addListAnswer == "no")
					{
                        addToList = false;
					}
                    Console.WriteLine();
                    if(addToList)
                    {
                        while(addToList)
                        {
                            while (addToList)
                            {
                                Console.Write("What would you like to add? ");
                                string userAddition = Console.ReadLine();

                                activities.Add(userAddition);

                                foreach (string activity in activities)
                                {
                                    Console.Write($"{activity} ");
                                    Thread.Sleep(250);
                                }

                                Console.WriteLine();
                                Console.WriteLine("Would you like to add more? yes/no: ");
                                //addToList = bool.Parse(Console.ReadLine());
                                addListAnswer = Console.ReadLine().ToLower();
                                if (addListAnswer == "yes")
                                {
                                    addToList = true;
                                }
                                else if (addListAnswer == "no")
                                {
                                    addToList = false;
                                }

                                if (!addToList)
                                {
                                    break;
                                }
                            }
                        }
					}
					else
					{

					}
                }
                else if(!seeList)
                {
                    while (cont)
                    {
                        
                        Console.Write("Connecting to the database");

                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(". ");
                            Thread.Sleep(500);
                        }

                        Console.WriteLine();

                        Console.Write("Choosing your random activity");

                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write(". ");
                            Thread.Sleep(500);
                        }

                        Console.WriteLine();

                        int randomNumber = rng.Next(activities.Count);

                        string randomActivity = activities[randomNumber];

                        if (userAge > 21 && randomActivity == "Wine Tasting")
                        {
                            Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                            Console.WriteLine("Pick something else!");

                            activities.Remove(randomActivity);

                            randomNumber = rng.Next(activities.Count);

                            randomActivity = activities[randomNumber];
                        }

                        Console.Write($"Ah got it! {randomActivity}, your random activity is: {userName}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                        Console.WriteLine();
                        //cont = bool.Parse(Console.ReadLine());
                        answer = Console.ReadLine().ToLower();
                        if (answer == "redo")
                        {
                            cont = true;
                        }
                        else if (answer == "keep")
                        {
                            cont = false;
                        }
                        
                    }
                }
            }
			else
			{
                
			}
        }


        
    }
}

