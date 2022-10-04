using System;

namespace SpaceAge
{
    public class Program
    {
        static void Main(string[] args)
        {
            int ageInSeconds = int.Parse(Console.ReadLine());

            SpaceAge spaceAge = new SpaceAge(ageInSeconds);

            double ageOnEarth = spaceAge.OnEarth();
            Console.WriteLine(Math.Round(ageOnEarth, 2));

            double ageOnMercury = spaceAge.OnMercury();
            Console.WriteLine(Math.Round(ageOnMercury, 2));

            double ageOnVenus = spaceAge.OnVenus();
            Console.WriteLine(Math.Round(ageOnVenus, 2));

            double ageOnMars = spaceAge.OnMars();
            Console.WriteLine(Math.Round(ageOnMars, 2));

            double ageOnJupiter = spaceAge.OnJupiter();
            Console.WriteLine(Math.Round(ageOnJupiter, 2));

            double ageOnSaturn = spaceAge.OnSaturn();
            Console.WriteLine(Math.Round(ageOnSaturn, 2));

            double ageOnUranus = spaceAge.OnUranus();
            Console.WriteLine(Math.Round(ageOnUranus, 2));

            double ageOnNeptune = spaceAge.OnNeptune();
            Console.WriteLine(Math.Round(ageOnNeptune, 2));
        }
    }
    public class SpaceAge
    {
        private int ageInSeconds;
        public SpaceAge(int seconds)
        {
            this.ageInSeconds = seconds;
        }

        public double OnEarth()
        {
            double ageInSecondsDouble = this.ageInSeconds * 1.0;
            double years = ageInSecondsDouble / 31557600;
            return years;
            throw new NotImplementedException("Implement this function.");

        }

        public double OnMercury()
        {
            double ageInSecondsDouble = this.ageInSeconds * 1.0;
            double years = ageInSecondsDouble / 31557600 / 0.2408467;
            return years;
            throw new NotImplementedException("Implement this function.");
        }

        public double OnVenus()
        {
            double ageInSecondsDouble = this.ageInSeconds * 1.0;
            double years = ageInSecondsDouble / 31557600 / 0.61519726;
            return years;
            throw new NotImplementedException("Implement this function.");
        }

        public double OnMars()
        {
            double ageInSecondsDouble = this.ageInSeconds * 1.0;
            double years = ageInSecondsDouble / 31557600 / 1.8808158;
            return years;
            throw new NotImplementedException("Implement this function.");
        }

        public double OnJupiter()
        {
            double ageInSecondsDouble = this.ageInSeconds * 1.0;
            double years = ageInSecondsDouble / 31557600 / 11.862615;
            return years;
            throw new NotImplementedException("Implement this function.");
        }

        public double OnSaturn()
        {
            double ageInSecondsDouble = this.ageInSeconds * 1.0;
            double years = ageInSecondsDouble / 31557600 / 29.447498;
            return years;
            throw new NotImplementedException("Implement this function.");
        }

        public double OnUranus()
        {
            double ageInSecondsDouble = this.ageInSeconds * 1.0;
            double years = ageInSecondsDouble / 31557600 / 84.016846;
            return years;
            throw new NotImplementedException("Implement this function.");
        }

        public double OnNeptune()
        {
            double ageInSecondsDouble = this.ageInSeconds * 1.0;
            double years = ageInSecondsDouble / 31557600 / 164.79132;
            return years;
            throw new NotImplementedException("Implement this function.");
        }
    }
}
