

#region Yöntem 1
//int YaslarinEnBuyugu(int y1, int y2, int y3)
//{
//    return Math.Max(Math.Max(y1, y2), y3);
//}
#endregion

#region Yöntem 2
//int YaslarinEnBuyugu(int y1, int y2, int y3)
//{
//    if (y1 > y2)
//    {
//        if (y1 > y3)
//            return y1;
//        else
//            return y3;
//    }
//    else
//    {
//        if (y2 > y3)
//            return y2;
//        else
//            return y3;
//    }
//}
#endregion

#region Yöntem 3
//int YaslarinEnBuyugu(int y1, int y2, int y3)
//{
//    if (y1 > y2 && y1 > y3)
//        return y1;
//    else if (y2 > y3)
//        return y2;
//    else
//        return y3;
//}
#endregion

#region Yöntem 4
int YaslarinEnBuyugu(int y1, int y2, int y3)
{
    int enBuyuk = y1;
    if (y2 > enBuyuk) enBuyuk = y2;
    if (y3 > enBuyuk) enBuyuk = y3;
    return enBuyuk;
}
#endregion

Console.WriteLine(YaslarinEnBuyugu(15, 18, 14));

Console.ReadKey();