int sayac = 0;


while (sayac < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    sayac++;
}

// 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.



int i = 0;
while (i <= 20)
{
    Console.WriteLine(i);
    i++;


}

// 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int b = 0;
while (b <= 20)
{
    if (b % 2 == 0)
    {
        Console.WriteLine(b);

    }
    b++;
}


//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız

int t = 50;
int toplam = 0;

while (t <= 150)
{
    Console.WriteLine(t);
    toplam += t;
    t++;

}
Console.WriteLine("sayıların toplamı" + toplam);


//1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int evenSum = 0;
int oddSum = 0;
int i = 1;

while (i <= 120)
{
    if (i % 2 == 0)
    {
        evenSum += i;
    }
    else
    {
        oddSum += i;
    }
    i++;
}

Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + evenSum);
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + oddSum);
    }
} 

