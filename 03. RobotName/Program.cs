using System;
using System.Text;

namespace RobotNameExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RobotName robotName = new RobotName();
            string name = robotName.Name;
            Console.WriteLine(name);
        }
    }
    public class RobotName
    {
        private string name = string.Empty;
        private List<string> nameList = new List<string>();
        private Random random = new Random();
        private string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string numbers = "0123456789";

        public string Name
        {
            get
            {
                return GetName();
                throw new NotImplementedException("Implement this function.");
            }
        }


        public string GetName()
        {
            if (this.name == string.Empty)
            {
                this.name = GenerateRandomName();
            }

            return this.name;
        }
        private string GenerateRandomName()
        {
            bool nameIsUnique = false;
            string generatedName = string.Empty;
            while (!nameIsUnique)
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < 2; i++)
                {
                    string letter = letters[random.Next(0, letters.Length)].ToString();
                    stringBuilder.Append(letter);
                }

                for (int i = 0; i < 3; i++)
                {
                    string number = random.Next(0, numbers.Length).ToString();
                    stringBuilder.Append(number);
                }
                generatedName = stringBuilder.ToString();
                nameIsUnique = !this.nameList.Contains(generatedName);
            }
            nameList.Add(generatedName);
            return generatedName;
            throw new NotImplementedException();
        }
        public void Reset()
        {
            this.name = GenerateRandomName();
            throw new NotImplementedException("Implement this function.");
        }
    }
}