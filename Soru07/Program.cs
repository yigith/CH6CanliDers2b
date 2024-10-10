Console.Write("Ad 1: ");
string ad1 = Console.ReadLine(); 

Console.Write("Ad 2: ");
string ad2 = Console.ReadLine();

Console.WriteLine($"Değişimden önce : {ad1} ve {ad2}");
string yedek = ad1;
ad1 = ad2;
ad2 = yedek;

Console.WriteLine($"Değişimden sonra: {ad1} ve {ad2}");

Console.ReadKey();