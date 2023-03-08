//List<T>class
//System.Collections.Generic
//T --> Object türündedir.

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi = new List<string>();
        renkListesi.Add("kirmizi");
        renkListesi.Add("mavi");
        renkListesi.Add("turuncu");
        renkListesi.Add("sari");
        renkListesi.Add("yesil");

        //Count

        Console.WriteLine(renkListesi.Count);
        Console.WriteLine(sayiListesi.Count);

        //Foreach ve List.ForEach ile elemanlara erişim
        foreach (var sayi in sayiListesi)
            Console.WriteLine(sayi);
        foreach (var renk in renkListesi)
            Console.WriteLine(renk);

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        //Listeden eleman çıkarma
        sayiListesi.Remove(4);
        renkListesi.Remove("yesil");
        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        //Liste içerisinde arama
        if (sayiListesi.Contains(10))
            Console.WriteLine("10 sayi listesi içerisinde bulundu!");

        //Eleman ile index'e erişmek
        Console.WriteLine(renkListesi.BinarySearch("sari"));

        //Diziyi List'e çevirme
        string[] hayvanlar = { "kedi", "Köpek", "Kuş" };
        List<string> hayvanListesi = new List<string>(hayvanlar);

        //Listeyi nasıl temizleriz?
        hayvanListesi.Clear();
        
        //Liste içerisinde nesne tutma
        List <Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

        Kullanicilar kullanici1 = new Kullanicilar();
        kullanici1.Isim = "Ayse";
        kullanici1.SoyIsim = "Yilmaz";
        kullanici1.Yas = 26;

        Kullanicilar kullanici2 = new Kullanicilar();
        kullanici2.Isim = "Ozcan";
        kullanici2.SoyIsim = "Caliskan";
        kullanici2.Yas = 26;

        kullaniciListesi.Add(kullanici1);
        kullaniciListesi.Add(kullanici2);

        List<Kullanicilar> yeniListe = new List<Kullanicilar>();

        yeniListe.Add(new Kullanicilar(){
            Isim = "Deniz",
            SoyIsim = "Arda",
            Yas = 24
        });

        foreach(var kullanici in kullaniciListesi)
        {
            Console.WriteLine($"kullanıcı Adı: {kullanici.Isim}");
            Console.WriteLine($"kullanıcı Soyadı: {kullanici.SoyIsim}");
            Console.WriteLine($"kullanıcı Adı: {kullanici.Yas}");
        }
        yeniListe.Clear();

    }
}


public class Kullanicilar{

    private string isim;
    private string soyisim;
    private int yas;

    public string Isim {get => isim; set => isim= value;}
    public string SoyIsim {get => soyisim; set => soyisim= value;}
    public int Yas { get=> yas; set => yas=value;}


}


