// Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

int sayi = new Random().Next(100);
Console.WriteLine("Rastgele bir sayı: {0}{2}Üçe bölümden kalan: {1}", 
    sayi, 
    sayi % 3, 
    Environment.NewLine);

Console.ReadKey();