using System;

namespace algoritma_sorulari
{
    

    /*class IlkSoru
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("******Ilk Soru******");
            Console.WriteLine("Lütfen pozitif bir sayi giriniz:");
            int DiziUzunluk = int.Parse(Console.ReadLine());

            int[] SayilarDizisi;
            SayilarDizisi = new int[DiziUzunluk];

            Console.WriteLine($"Lütfen {DiziUzunluk} adet pozitif sayilar giriniz:");

            for(int i=0; i<DiziUzunluk; i++)
            {
                
                SayilarDizisi[i] = int.Parse(Console.ReadLine());
            }
            
            foreach(int item in SayilarDizisi)
            {
                if(item%2==0)
                {
                    Console.WriteLine(item);
                }
            }
                       
        }
    }*/
    

    /*class IkinciSoru
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("******Ikinci Soru******");
            int[] SayilarDizisi;
            SayilarDizisi = new int[2];
            Console.WriteLine("Lütfen iki adet pozitif sayi giriniz");
            
            for (int i=0; i<SayilarDizisi.Length; i++)
            {
                Console.WriteLine("Lütfen {0}. sayiyi giriniz: ", i+1);
                SayilarDizisi[i]= int.Parse(Console.ReadLine());
            }

            int[] DiziM;
            DiziM = new int[SayilarDizisi[0]];

            for (int i=0; i<SayilarDizisi[0]; i++)
            {
                Console.WriteLine("Lütfen {0}. sayiyi giriniz: ", i+1);
                DiziM[i]= int.Parse(Console.ReadLine());
            }


            foreach(int item in DiziM)
            {
                if(item==SayilarDizisi[1] || item%SayilarDizisi[1]==0)
                {
                    Console.WriteLine($"{item}, {SayilarDizisi[1]}'e eşittir veya tam bölünür");
                }
            }
        }
    }*/

    /*
    class UcuncuSoru
    {
        
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.WriteLine("******Ucuncu Soru******");
            
            Console.WriteLine("Lütfen bir adet pozitif sayi giriniz");
            int size = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Lütfen {size} adet kelime giriniz:");
            string[] text;
            text = new string[size];
            for(int i=0; i<size; i++)
            {
                Console.WriteLine("Lütfen {0}.kelimeyi giriniz:", i+1);
                text[i] = Console.ReadLine();
            }
           
            Console.WriteLine("Kelimelerin sondan başa çevrilmiş halleri:" );
            for(int i = (text.Length - 1); i >= 0; i--) 
            {
                string rev =  text[i];     
                Console.Write(rev+' ');
            }
        
            

        }
    }*/

    /*
    class DorduncuSoru
    {
        
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("******Dorduncu   Soru******");
            
            Console.WriteLine("Lütfen bir cümle yaziniz:");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] {}, StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length;

            int lettersCount = text.Length;

            Console.WriteLine("There are {0} words in this sentence.",wordCount);
            Console.WriteLine("There are {0} letters in this sentence.",lettersCount);
          
        }
    }*/
}

