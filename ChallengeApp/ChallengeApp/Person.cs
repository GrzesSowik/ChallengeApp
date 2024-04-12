﻿// Zadanie domowe - dzień 13

namespace ChallengeApp
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}