// Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

int yas;

Console.Write("Yaşınız: ");
yas = Convert.ToInt32(Console.ReadLine());

// koşul ? doğruysa : yanlışsa
Console.WriteLine(yas >= 18 ? "+" : "-");

Console.ReadKey();