﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6
{
    class Person
    {
        // Properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SocialSecurityNumber { get; set; }
        // Methods
        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + SocialSecurityNumber;
        }
    }
    class Persons
    {
        // Members = Jäsenmuuttujat
        private List<Person> persons;
        // Constructor
        public Persons()
        {
            persons = new List<Person>(); 
        }
        // Methods
        public void Add(Person person)
        {
            persons.Add(person);
        }
        public Person Get(int index)
        {
            if (index < persons.Count)
                return persons.ElementAt(index);
            else
                return null;
        }
        public Person Find(string socialsecuritynumber)
        {
            foreach (Person p in persons)
            {
                if (p.SocialSecurityNumber.Equals(socialsecuritynumber))
                    return p;
            }
            return null;
        }
        public void ShowPersons()
        {
            foreach (Person p in persons)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
