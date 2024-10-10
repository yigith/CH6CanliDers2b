
#region Yöntem 1
//bool CiftMi(int sayi) => sayi % 2 == 0; 
#endregion

#region Yöntem 2
bool CiftMi(int sayi)
{
    return sayi % 2 == 0;
}
#endregion

Console.Write("Bir sayı: ");
int sayi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CiftMi(sayi) ? "Çift" : "Tek");

Console.ReadKey();