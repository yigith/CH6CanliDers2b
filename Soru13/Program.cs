void Degistir(ref string a, ref string b)
{
    string yedek = a;
    a = b;
    b = yedek;
}

Console.Write("Ad 1: ");
string ad1 = Console.ReadLine();

Console.Write("Ad 2: ");
string ad2 = Console.ReadLine();

Console.WriteLine("Önce : {0} {1}", ad1, ad2);
Degistir(ref ad1, ref ad2);
Console.WriteLine("Sonra: {0} {1}", ad1, ad2);

Console.ReadKey();