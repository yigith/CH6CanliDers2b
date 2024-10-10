
#region Yaklaşım 1
// diziler konusundan sonra anlaşılacak
//int EnBuyuk(params int[] dizi)
//{
//	return dizi.Max();
//}

//Console.WriteLine(EnBuyuk(48, 483, 99, -50, 9999));
//Console.WriteLine(EnBuyuk(1, 3, 2)); 
#endregion

#region Yaklaşım 2
int EnBuyugu()
{
    int sayac = 1;
    int sayi;
    bool sonuc = true;
    int enBuyuk = int.MinValue;

    while (sonuc)
    {
        Console.Write($"Sayı {sayac++}: ");
        string cevap = Console.ReadLine();
        sonuc = int.TryParse(cevap, out sayi);

        if (sonuc)
        {
            enBuyuk = Math.Max(enBuyuk, sayi);
        }
    }

    return enBuyuk;
}
#endregion

int buyuk = EnBuyugu();
Console.WriteLine("En Büyük Sayı: " + buyuk);

Console.ReadKey();