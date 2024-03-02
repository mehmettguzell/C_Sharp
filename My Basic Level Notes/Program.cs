/*String kursAdi=".Net 7 ile C# Programlama Dili";

var karakter=kursAdi.Length;
Console.WriteLine("Kurs Adı Karakter Sayısı: "+karakter);

var kucukHali=kursAdi.ToLower();
Console.WriteLine("Küçük Harfli Hali: "+kucukHali);

var baslama=kursAdi.StartsWith('.');
Console.WriteLine("Kurs Adı . ile mi başlıyor: "+baslama);

var konum=kursAdi.IndexOf("C#");
Console.WriteLine("C# kelimesinin başlangıç indexi: "+konum);

var varMı=kursAdi.Contains("C#");
Console.WriteLine("C# kelimesi var mı: "+varMı);

var degistir=kursAdi.Replace("Dili","Dersleri");
Console.WriteLine("Dili kelimesi Dersleri ile değiştirilmiş hali: "+degistir);*/
/*
DateTime tarih=DateTime.Now;
Console.WriteLine(tarih);
Console.WriteLine(tarih.Year);
Console.WriteLine(tarih.Month);
Console.WriteLine(tarih.Day);
Console.WriteLine(tarih.DayOfWeek);
Console.WriteLine(tarih.DayOfYear);

DateTime dt=new DateTime(2003,07,01);
Console.WriteLine(dt);*/

// var a=10;
// var b=5;

// Console.WriteLine(a+" "+b);
// // a=b++;
// // Console.WriteLine(a+" "+b);
// a=++b;
// Console.WriteLine(a+" "+b);
// Console.WriteLine(a+" "+b);

// int? a=null;
// int b=20;
// var sonuc=(a ?? 0)+b;
// Console.WriteLine(sonuc);

// Console.WriteLine("sayı: ");
// var sayi=Convert.ToInt32(Console.ReadLine());

// var sonuc=sayi>0 ? "Pozitif":"Negatif";
// Console.WriteLine(sonuc);

// Console.WriteLine("Yaşınız: ");
// var yas=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Ehliyet izini: ");
// Boolean izin= bool.Parse(Console.ReadLine());

// var kontrol=yas>=18 ? (izin==true ? "Alabilirsin" : "Alamazsın") : "Alamazsın";
// Console.WriteLine(kontrol);

// Console.WriteLine("Notunuz: ");
// var not= Convert.ToInt32(Console.ReadLine());

// var bilgi=not>=50 ? "Geçti" : "Kaldı";
// var bilgi1=not>100 ? "Doğru giriş yapmadınız" : "Geçerli not girişi yaptınız";

// Console.WriteLine(bilgi);

// Random rn=new Random();
// int sayi=rn.Next(1,100);
// Console.WriteLine(sayi);

// var rnd = new Random();
// int tutulan = rnd.Next(1, 100);
// int hak = 4;
// bool bulundu = false;


// while (hak > 0)
// {
//     Console.WriteLine("Tahmininizi giriniz: ");
//     int tahmin = Convert.ToInt32(Console.ReadLine());
//     hak--;

//     if (tahmin == tutulan)
//     {
//         Console.WriteLine("Tebrikler, doğru tahmin");
//     }
//     else
//     {
//         if (tahmin > tutulan)
//         {
//             Console.WriteLine("Daha küçük bir sayı giriniz");
//         }
//         else
//         {
//             Console.WriteLine("Daha büyük bir sayı giriniz");
//         }
//     }
// }
// if(!bulundu) {
//     Console.WriteLine("Hakkınız bitti. Tutulan sayı: " + tutulan);
// }

////DOSYA ISLEMLERI////

// // // // // StreamReader sr = File.OpenText("ip.txt");
// // // // // var s= "";

// // // // // while((s=sr.ReadLine())!=null){
// // // // //     Console.WriteLine(s);
// // // // // }

/*StreamReader sr= File.OpenText("ip.txt");
var s="";
while((s=sr.ReadLine())!=null){
    Console.WriteLine(s);
}*/

/*string [] sonuc=File.ReadAllLines("ip.txt");
Console.WriteLine(sonuc[0]);
*/
/*
string rootPath =Directory.GetCurrentDirectory();
string [] dirs= Directory.GetDirectories(rootPath,"*.txt",SearchOption.TopDirectoryOnly);
foreach(var dir in dirs){
    Console.WriteLine(dir);
}
*/


/*
string source_path ="C:/Users/mehme/Desktop/Yeni klasör";
string dest_path ="C:/Users/mehme/Desktop/Yeni klasör";

string[] files= Directory.GetFiles(source_path,"*", SearchOption.AllDirectories);

foreach(var file in files){
    Console.WriteLine(file);
    Console.WriteLine(Path.GetExtension(file));    
    Console.WriteLine(Path.GetFileNameWithoutExtension(file));   
    Console.WriteLine(Path.GetFileName(file));   

    var info = new FileInfo(file);
    Console.WriteLine("${Path.GetFileName(file)}: {info.length}");

    if(!Directory.Exists(dest_path)){
        Directory.CreateDirectory(dest_path);
    }


}
*/

/*using System.Collections;
using System.Data.Common;
using System;
using System.Collections.Generic;
//Arraylist
ArrayList liste= new ArrayList();
liste.Add(15);
liste.Add("10");


var liste2 =new ArrayList(){
    5,
    "Malatya",
    false,
    4.5,
    null
};*/

//Generic List
/*using System;
using System.Collections.Generic;

List <int> sayilar=new List<int>();
sayilar.Add(15);*/

/*
class Product{
    public int id {get;set;}
    public string title {get;set;}
    public int price{get;set;}   
    

    public Product(int id, string title, int price){
        this.id = id;
        this.title = title;
        this.price = price;
        }
}
class Program{
    static void Main(string[] args) {
        List<Product> urunler = new List<Product>();
        urunler.Add(new Product(1,"wrasf",456));
    }  
}
*/
// try catch ,hata fırlatma
/*          ////CASUAL HATALAR
try{
    Console.Write("1. sayi: ");
    int sayi1=Convert.ToInt32(Console.ReadLine());
    
    Console.Write("2. sayi: ");
    int sayi2=Convert.ToInt32(Console.ReadLine());


    var sonuc= sayi1/sayi2;

    Console.WriteLine(sonuc);
}
    catch(Exception ex){    
        Console.WriteLine("Bir hata oluştu");
        Console.WriteLine(ex.Message);
    }*/
            /// <summary>
            /// Kendi programına göre Hata Tanımlama
            /// </summary>
/*class Program{
    static void Main(string[] args)
    {
        int sayi=10;

        if (sayi>5){
            throw new Exception("sayı 5 den büyük olamaz");
        }
    }
}
*/          //////Debugging

class program{
    static void Main(string[] args){
            
    }
}






