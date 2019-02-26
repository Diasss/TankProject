using System;
using System.Collections.Generic;
using TankLib;

namespace TankWar
{
    public class TanksWar
    {
        public void Tankss()
        {
           
                    CreateTank();

            
                    TankWar();
                
              
                    PrintInfoAboutTank();
              
            
          
                
        } 
        List<Tank> tankT34 = new List<Tank>();
        List<Tank> tankPantera = new List<Tank>();

        public void CreateTank()
        {
            Console.WriteLine("Добавьте 5 танков T-34");
            string name = null;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("введите название {0} танка T-34: ", i + 1);
                name = Console.ReadLine();
                Tank tank = new Tank(name);
                tankT34.Add(tank);
                name = null;
            }

            Console.WriteLine("Добавьте 5 танков Pantera");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("введите название {0} танка Pantera: ", i + 1);
                name = Console.ReadLine();
                Tank tank = new Tank(name);
                tankPantera.Add(tank);
                name = "";
            }
        }
        public void PrintInfoAboutTank()
        {
            Console.WriteLine("Информацию о каких танках вы хотите увидеть?");
            Console.WriteLine("1)T-34\n2)Pantera");

            int choice = 0;
            while (choice == 0)
            {
                Int32.TryParse(Console.ReadLine(), out choice);

                if (choice == 1)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Информация о {0} танке T-34: ", i + 1, tankT34[i]);
                        tankT34[i].PrintInfo();
                    }
                }
                else if (choice == 2)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Информация о {0} танке Pantera: ", i + 1, tankPantera[i]);
                        tankPantera[i].PrintInfo();
                    }
                }
            }
        }
        public void TankWar()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Между {0} и {1}", tankT34[i].tankName, tankPantera[i].tankName);
                var result = tankT34[i] * tankPantera[i];
                Console.WriteLine("Победил танк {0}", result.tankName);
            }
        }

    }
}