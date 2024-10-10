// Rastgele bir sayı üretip , ekrana yazdırınız.
Random rnd = new Random();

int sayi = rnd.Next(1, 101);
Console.WriteLine("1-100 aralığında rastgele bir sayı: " + sayi);

Console.ReadKey();