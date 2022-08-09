using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public  class Team:IEnumerable
    {
        private Person[] players;

        public Team()
        {
            players = new Person[3];
            players[0]=new Person { Age = 23, Salary = 56000, Location = "Pune", Name = "Raj" };
            players[1] = new Person { Age = 45, Salary = 88000, Location = "Mumbai", Name = "Radhika" };
            players[2]= new Person { Age = 33, Salary = 98000, Location = "Shivaji Nagar", Name = "Manisha" };
        }

        public Person[] GetAllPlayers()
        {
            return players;
        }

        public IEnumerator GetEnumerator()
        {
           return players.GetEnumerator();
        }
    }
}
