string metin = "    Selamlar   ";
metin = metin.Trim();
Console.WriteLine(metin);

Console.ReadKey();

// string türü immutable bir türdür. hiç bir string metodu o stringi değiştiremez, peki ne yapar: yeni bir string üretip onu döndürür.

// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#immutability-of-strings