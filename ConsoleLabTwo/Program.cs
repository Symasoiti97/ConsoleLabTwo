using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleLabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person player;// = new Person("Name", new WSward());
            player = Person.getInstance("Name", new WSward());
            player.attack();
            player.weapon = new WBow();
            player.attack();
            player.weapon = new WMagic();
            player.attack();
            Console.ReadLine();
        }
    }
}
