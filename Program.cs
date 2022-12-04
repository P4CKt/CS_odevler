using System;

namespace Calisma 
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string kelime = "ömür";
            Console.WriteLine(kelime);

            //       Veri Tipleri


            byte b = 5;         //1 byte
            sbyte sb = 5;        //1 byte
            short s = 5;        //2 byte
            ushort us = 5;       //2 byte

            Int16 i16 = 2;      //2 byte
            int i = 2;          //4 byte
            Int32 i32 = 2;      //4 byte
            Int64 i64 = 2;      //8 byte
            uint ui = 2;        //4 byte
            long l = 2;         //8 byte
            ulong ul = 2;        //8 byte

            float f = 5;        //4 byte
            double d = 5.4;     //8 byte

            char c = 'a';       //2byte
            string str = "Ömür"; 

            bool bl = false;

            DateTime dt = DateTime.Now;     // Şu anın saat ve tarihi verir.
            Console.WriteLine(dt);

            object o1 = "x";    //string
            object o2 = 'y';    //char
            object o3 = 4.5;    //decimal
            object o4 = 6;      //integer
           
            string str1 = string.Empty;
            string str2 = null;
            string str3;

            string strName = "Ömürcan Uslu";
            string name = "Ömürcan";
            string surname = "Uslu";
            string fullname = name + " " + surname;

            Console.WriteLine(strName);
            Console.WriteLine(fullname);

            
            int int1 = 5;
            int int2 = 3;
            int in3 = int1 * int2;

        
            bool b1 = 10 > 2;//True değer döndürür.

            //  Değişken Dönüşümleri 

            // int.Parse(int1) 
            // Convert.ToInt32(dönüştürülecek);
               
            
            string str20 = "20";
            int int20 = 20;
            string str4 = str20 + int20.ToString(); 

            Console.WriteLine(str4);   

         
            // int20.ToString() 
            // Convert.ToString(int20);


            int int3 = int20 + Convert.ToInt32(str20);  
            
            Console.WriteLine(int3);  

            int int4 = int20 + int.Parse(str20);  
           
            Console.WriteLine(int4);

            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy"); // Gün ay yıl şeklinde verir.
            Console.WriteLine(datetime1);
            
            string hour = DateTime.Now.ToString("HH:mm");  //Şu anın saat:dk şeklinde verir.
            Console.WriteLine(hour);

            Console.ReadLine();
        }
    }
}