using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp_pr6
{
    class Hospital_singleton
    {
        private static Hospital_singleton instance;
        public String get;
        private Hospital_singleton(int k)
        {
            Dictionary<int, string> diseases = new Dictionary<int, string>();
            AddDiseases(diseases);
            get= GetInfo(diseases,k);  
        }
        
        
        private static void AddDiseases(Dictionary<int, string> diseases )
        {
            diseases.Add(1, "Перелом ноги");
            diseases.Add(2, "Перелом ребер");
            diseases.Add(3, "Воспаленные лимфоузлы");
            diseases.Add(4, "Брюшная грыжа");
            diseases.Add(5, "Воспаление аппендикса");
        }
        
        
        public static Hospital_singleton GetInstance(int k)
        {
            if (instance == null)
            {
                instance=new Hospital_singleton(k);
            }
            return instance;
        }
        
        private string GetInfo(Dictionary<int,string> diseases,int k)
        {
            switch (k)
            {
                case 1:
                    return diseases[k];
                case 2:
                    return diseases[k];
                case 3:
                    return diseases[k];
                case 4:
                    return diseases[k];
                case 5:
                    return diseases[k];
                default:
                    return null;
            }
        }
    }
    class get
    {
        public Hospital_singleton Hospital_singleton { get; set; }
        
        public void Get(int k)
        {
            Hospital_singleton = Hospital_singleton.GetInstance(k);

        }
    }
}
