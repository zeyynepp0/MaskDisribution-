using Business.Concrete;
public class Program
{
    static void Main(string[] args)
    {
        //Degiskenler();
        Vatandas vatandas1 = new Vatandas();


        SelamVer("Engin");
        SelamVer("Ahmet");
        SelamVer("Ayşe");
        SelamVer();

        int sonuc = Topla(6, 58);

        //Diziler /Arrays

        string ogrenci1 = "Engin";
        string ogrenci2 = "Kerem";
        string ogrenci3 = "Berkay";

        //Console.WriteLine(ogrenci1);
        //Console.WriteLine(ogrenci2);
        //Console.WriteLine(ogrenci3);


        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Kerem";
        ogrenciler[2] = "Berkay";

        ogrenciler = new string[4];// ogrencilerin eleman sayisini 4 yaptık.
        ogrenciler[3] = "İlker";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler1 = new[] { "Ankara", "İstanbul", "izmir" }; // dizileri bu şekilde de tanımlayabiliriz
        string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";
        Console.WriteLine(sehirler2[0]);

        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }

        //MyList eğer generic listeyi bilmeseydik bu aşağıdaki ifadeyi nasıl yazardık ?
        List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
        yeniSehirler1.Add("Adana 1");

        foreach (var sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }

        PttManager pttManager = new PttManager();




        Console.ReadLine();
    }
    

    static void SelamVer(string isim = "isimsiz") //metot
    {
        Console.WriteLine("Merhaba " + isim);
    }
    //resharper
    static int Topla(int sayi1 = 5, int sayi2 = 10)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam: " + sonuc);
        return sonuc;
    }

    private static void Degiskenler()
    {
        string mesaj = "Selam";
        double tutar = 100000; //db den gelir veritabanından
        int sayi = 100;
        bool girisYapmiMi = false;

        string ad = "Engin";
        string soyad = "Demiroğ";
        int dogumYili = 1995;
        long tcNo = 12345678910;

        Console.WriteLine(tutar * 1.18);
        Console.WriteLine(mesaj);
    }
}
//pascal casing 
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}


