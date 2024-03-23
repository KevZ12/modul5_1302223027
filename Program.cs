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



                Console.WriteLine(JumlahTigaAngka<int>(13, 02, 22));
            }
        }

        
    }

