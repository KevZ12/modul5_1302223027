// See https://aka.ms/new-console-template for more information
using System.Numerics;

namespace modul5_1302223027
{
    


        public class Penjumlahan
        {

            public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3) where T : IAdditionOperators<T,T,T>
            {
             


                return angka1 + angka2 + angka3;
            }
            static void Main(string[] args)
            {
                //1302223027



                Console.WriteLine("HASIL PENJUMLAHAN DARI 13+02+22 ADALAH",JumlahTigaAngka<int>(13, 02, 22));

            SimpleDataBase<int> test = new SimpleDataBase<int>();
            test.AddNewData(12);
            test.AddNewData(34);
            test.AddNewData(56);
            test.printAllData();

        }
        }


    public class SimpleDataBase<T>
    {
        private List<T> storeDatabase;
        private List<DateTime> inputDate;


        public  SimpleDataBase()
        {
            storeDatabase = new List<T>();
            inputDate = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storeDatabase.Add(data);
            inputDate.Add(DateTime.Now);
            
        }

        public void printAllData()
        {
            for (int i = 0; i < storeDatabase.Count; i++)
            {
                Console.WriteLine(storeDatabase[i]);
                Console.WriteLine(inputDate[i]);
            }
        }

        



    }




        
    }

