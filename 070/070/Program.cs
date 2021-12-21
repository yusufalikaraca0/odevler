void ucgen(int uzunluk) {
    for (int satir = 1; satir <=uzunluk; satir++)
    {
        for (int bosluk = 0;bosluk < uzunluk-satir; bosluk++)
        {
            Console.Write(" ");
        }
        for (int govde = 1; govde <= satir; govde++)
        {
            Console.Write("* ");
        }
        Console.Write("\n");
    }
}
Console.WriteLine("uzunluğu ne kadar olsun ? ");
ucgen(int.Parse(Console.ReadLine()));

