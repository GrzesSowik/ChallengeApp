﻿namespace ChallengeApp
{
    public abstract class EmploeeBase : IEmploee
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public EmploeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(string grade);

        public abstract Statistics GetStatistics();
    }
}