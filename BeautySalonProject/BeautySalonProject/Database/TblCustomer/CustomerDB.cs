using BeautySalonProject.Customers;
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
        private static readonly string filepath = "..\\..\\Database\\TblCustomer\\Customer_tbl.txt";

        public static List<Customer> GetAll()
        {
            string[] satirlar = File.ReadAllLines(filepath);
            List<Customer> list = new List<Customer>();


            for (int i = 0; i < satirlar.Length; i++)
            {
                string[] guncelsatir = satirlar[i].Split('-');

                list.Add(new Customer()
                {
                    ID = Convert.ToInt16(guncelsatir[0]),
                    Name = guncelsatir[1],
                    Surname = guncelsatir[2],
                    PhoneNumber = guncelsatir[3],
                    Address = guncelsatir[4]
                });
            }
            return list;
        }

        public static void AddCustomer(Customer c)
        {
            int id = GetID() + 1;

            using (StreamWriter dosya = File.AppendText(filepath))
            {
                dosya.WriteLine($"{id}-{c.Name}-{c.Surname}-{c.PhoneNumber}-{c.Address}");
            }
        }

        public static void DeleteCustomer(int id)
        {
            List<Customer> list = GetAll();

            File.WriteAllText(filepath, string.Empty);

            foreach (Customer c in list)
            {
                if (c.ID == id)
                {
                    list.Remove(c);
                    break;
                }
            }

            using (StreamWriter dosya = File.AppendText(filepath))
            {
                foreach (Customer c in list)
                {
                    dosya.WriteLine($"{c.ID}-{c.Name}-{c.Surname}-{c.PhoneNumber}-{c.Address}");
                }
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
