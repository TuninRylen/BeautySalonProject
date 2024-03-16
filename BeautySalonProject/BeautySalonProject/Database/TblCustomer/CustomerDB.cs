using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonProject
{
    public static class CustomerDB
    {
        private static readonly string filepath = "..\\..\\Database\\Customer_tbl.txt";
        public static void AddCustomer()
        {
            using (StreamWriter dosya = File.AppendText(filepath))
            {
                dosya.WriteLine("");
            }
        }

        private static int GetID()
        {
            int sonId = 0;

            string[] satirlar = File.ReadAllLines(filepath);

            if (satirlar.Length > 0)
            {
                string[] sonSatirParcalari = satirlar[satirlar.Length - 1].Split('-');

                if (sonSatirParcalari.Length > 0)
                {
                    int.TryParse(sonSatirParcalari[0], out sonId);
                }
            }

            return sonId;
        }

    }
}
