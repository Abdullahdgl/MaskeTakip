
using Business.Concrete;
using Entities.Concrete;



internal class Program
{

    private static void Main(string[] args)
    {
      
        SelamVer("Abdullah");
        SelamVer("Mehmet");
        SelamVer("Muhammed");
        SelamVer();

        int sonuc = Topla(3,5);
        int sonuc2 = Topla();

        //Arrays / Diziler
        string ogrenci1 = "A";
        string ogrenci2 = "B";
        string ogrenci3 = "C";
        //Console.WriteLine(ogrenci1);
        //Console.WriteLine(ogrenci2);
        //Console.WriteLine(ogrenci3);

        

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "A";
        ogrenciler[1] = "B";
        ogrenciler[2] = "C";

        ogrenciler = new string[4];
        ogrenciler[3] = "D";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i] );
        }

        string[] sehirler1 = new[] { "İstanbul", "Malattya", "Bartın" };
        string[] sehirler2 = new[] { "Bursa", "Balıkesir", "Bilecik" };
        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";

        Console.WriteLine(sehirler2[0]);

        int sayi1 = 10;
        int sayi2 = 20;
        sayi2 = sayi1;
        sayi1 = 30;
        Console.WriteLine(sayi2);

        Person person1 = new Person();
        
        person1.FirstName = "ABDULLAH";
        person1.LastName = "DAĞLI";
        person1.DateOfBirthYear = 1993;
        person1.NationalIdentity = 1013678111;


        Person person2 = new Person();
        person2.FirstName = "MURAT";

        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }

        List<string> yeniSehirler1 = new List<string> { "Ankara 2", "İstanbul", "İzmir" };
        yeniSehirler1.Add("izmir 2");
        foreach (string sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }



        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);




        Console.ReadLine();

      

    }
 


    static void SelamVer(string isim = "noname")
    {
        //
        //
        //...

        Console.WriteLine("Merhaba" + isim);
    }
    static int Topla(int sayi1=5,int sayi2 = 10)
    {
        int sonuc = sayi1 + sayi2;

        Console.WriteLine("Toplam : " + sonuc.ToString());
        return sonuc;

    }
}



