using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_pr6
{
    class Random_singleton
    {
        Random random = new Random();
        private static Random_singleton instance;
        public String get_rand;
        private Random_singleton()
        { 
            Dictionary<int, string> rand = new Dictionary<int, string>();
            AddRand(rand);
            get_rand=Getrand(rand);
        }
        private static void AddRand(Dictionary<int, string> rand)
        {
            rand.Add(1, "Пациент повторно поступил с травмой или болезнью");
            rand.Add(2, "Пациент отказался от лечения");
            rand.Add(3, "Пациент подскальзнулся на только помытом полу и получил еще одну травму");
            rand.Add(4, "Пациент прошел по только помытому полу и получил трапкой от уборщицы");

        }
        private string Getrand(Dictionary<int, string> rand)
        {
            int k = random.Next(0, 5);

            switch (k)
            {
                case 1:
                    return rand[k];
                case 2:
                    return rand[k];
                case 3:
                    return rand[k];
                case 4:
                    return rand[k];
                default:
                    return null;
            }
        }
        public static Random_singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Random_singleton();
            }
            return instance;
        }
    }
    class Get_rand
    {
        public Random_singleton Rand { get; set; }

        public void Get()
        {
            Rand = Random_singleton.GetInstance();

        }
    }
}
