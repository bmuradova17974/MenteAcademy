using System;

namespace MenteAcademy.week2
{
    internal class Task1week2
    {
        string[] names = { "Bilqeyis", "Nurlana", "Aysel" };

        static void Main(string[] args)
        {
            Task1week2 task = new Task1week2();
            task.find();
        }

        public void find()
        {
            int cnt = 0;
            foreach (string name in names)
            {
                if (name.StartsWith("A"))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
