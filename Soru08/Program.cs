
internal class Program
{
    private static void Main(string[] args)
    {

        // yazdığımız değer döndürmeyen bu metodu test edelim
        BenDegerDondurmem();

        Console.ReadKey();
    }

    static void BenDegerDondurmem()
    {
        Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
    }

}