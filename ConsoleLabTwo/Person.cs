using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLabTwo
{
    class Person
    {
        private string Name;
        public IWeapon weapon;
        private static Person person;
        private Person(string Name, IWeapon weapon)
        {
            this.Name = Name;
            this.weapon = weapon;
        }
        public static Person getInstance(string Name, IWeapon weapon)
        {
            if (person == null)
            {
                person = new Person(Name,weapon);
            }
            return person;
        }
        public void attack()
        {
            Console.WriteLine($"Name player: {Name} | Gived damage: " +
                $"{weapon.damageWeapon()} | Type Weapon: {weapon.typeWeapon()}");
        }
    }
}
