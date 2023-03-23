using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Variablen deklarieren
			string name;
			int gold = 5;

			// Begrüßung
            Console.WriteLine("Wie heißt ihr, Abenteurer?");
			Console.Write("> ");
			name = Console.ReadLine();
            Console.WriteLine("Willkommen, " + name + "!\n");
            Console.WriteLine("Du greifst in deine Tasche und findest " + gold + " Goldmünzen!");

            Console.WriteLine("-----------------------------------------#########|||||||||||#########-----------------------------------------");

            // Wegwahl
            Console.WriteLine("Wohin willst du gehen?\n[1] In den finsteren Wald\n[2] In die nächstgelegene Stadt\n[3] In die nächste Herberge auf dem Weg");
			Console.Write("> ");
			string input1 = Console.ReadLine();
			Console.WriteLine("-----------------------------------------#########|||||||||||#########-----------------------------------------");

			if (input1 == "1")
			{
                Console.WriteLine("Du gehst durch den finsteren Wald und begegnest zwielichtigen Wegelagerern. \nWas willst du tun?");
				Console.WriteLine("[1] Den Überraschungsmoment nutzen und sie überwältigen\n[2] Die Männer ansprechen\n[3] Versuchen die Männer zu bestechen (-3 Gold)");

				string input2 = Console.ReadLine();

				Console.WriteLine("-----------------------------------------#########|||||||||||#########-----------------------------------------");

				if (input2 == "1")
				{
                    Console.WriteLine("Du schaffst es die Wegelagerer in einem ruhigen moment zu überwältigen und fesselst die Männer!");
					Console.WriteLine("Zufällig findest du 10 Gold bei ihnen und nimmst es an dich, bevor du deines Weges gehst.");

					// Gold wird um 10 erhöht: gold = gold + 10; ist auch möglich
					gold += 10;

                    Console.WriteLine("Du besitzt jetzt " + gold + " Goldmünzen");
                }
				else if (input2 == "2")
				{
					Console.WriteLine("Die Wegelagerer sind schlecht auf besuch geestimmt und eh du dich versiehst hast du ein Messer in der Brust!");
				}
				else if (input2 == "3")
				{
					Console.WriteLine("Du sprichst die Männer an und sie akzeptieren dein Wegegeld.");

					// Gold wird um 3 reduziert: gold = gold - 3; ist auch möglich
					gold -= 3;

					Console.WriteLine("Du besitzt jetzt " + gold + " Goldmünzen");
				}
			}
            else if (input1 == "2")
			{
				Console.WriteLine("Du begibst dich in die nächste Stadt. Doch bereits am Tor stößt du auf das erste Problem; Der Torwächter lässt dich nicht passieren! \nWas willst du tun?");
				Console.WriteLine("[1] Ihm drohen\n[2] Ihn bestechen (-2 Gold)");

				string input2 = Console.ReadLine();

				Console.WriteLine("-----------------------------------------#########|||||||||||#########-----------------------------------------");

				if (input2 == "1")
				{
					Console.WriteLine("Dem Wachmann gefällt die drohung garnicht und er lässt dich in den kerker sperren!");
				}
				else if (input2 == "2")
				{
					Console.WriteLine("Der Wachmann akzeptiert dein angebot und lässt dich passieren.");

					gold -= 2;

					Console.WriteLine("Du besitzt jetzt " + gold + " Goldmünzen");
				}
			}
			else if (input1 == "3")
			{
				Console.WriteLine("Du suchst die nächstgelegene Herberge auf und willst dort die Nacht verbringen. Das kostet 2 Goldmünzen. \nWas willst du tun?");
				Console.WriteLine("[1] Dort nächtigen (-2 Gold)\n[2] Die Herberge verlassen");

				string input2 = Console.ReadLine();

				Console.WriteLine("-----------------------------------------#########|||||||||||#########-----------------------------------------");

				if (input2 == "1")
				{
					Console.WriteLine("Du nächtigst in einem bescheidenen Zimmer.");

					gold -= 2;

					Console.WriteLine("Du besitzt jetzt " + gold + " Goldmünzen");
				}
				else if (input2 == "2")
				{
					Console.WriteLine("Du verbringst die Nacht draußen.\n");
				}
			}
			Console.WriteLine(name + " hat sein Abenteuer beendet!\n");
		}
	}
}
