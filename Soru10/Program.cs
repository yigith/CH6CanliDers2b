
string Cevap(bool c)
{
    return c ? "Evet" : "Hayır";
}

Console.WriteLine("Benimle C# yazar mısın : " + Cevap(true));
Console.WriteLine("Benimle köfte yer misin: " + Cevap(false));

Console.ReadKey();