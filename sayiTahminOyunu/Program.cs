var rand= new Random(0); 
int tutulan= rand.Next();
int hak = 3;

while (hak > 0)
{
    Console.WriteLine(tutulan);
    Console.WriteLine("SAYI:");
    int sayi = Convert.ToInt32(Console.ReadLine());

    hak--;
    if (sayi == tutulan)
    {
        Console.WriteLine("tebrikler bildiniz");
        break;
    }
    else
    {
        if (hak == 0)
        {
            Console.WriteLine("Hakkınız bitti");
            break;
        }
        if (sayi > tutulan) { Console.WriteLine("aşağı in"); }
        else { Console.WriteLine("yukarı çık"); }
    }
}