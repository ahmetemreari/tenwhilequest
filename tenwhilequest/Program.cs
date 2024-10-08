using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdır
        int count = 0;
        while (count < 10)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            count++;
        }

        // 2. 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
        int number = 1;
        while (number <= 20)
        {
            Console.WriteLine(number);
            number++;
        }

        // 3. 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
        int num = 1;
        while (num <= 20)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
            num++;
        }

        // 4. 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
        int sum = 0;
        int i = 50;
        while (i <= 150)
        {
            sum += i;
            i++;
        }
        Console.WriteLine("Toplam: " + sum);

        // 5. 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
        int oddSum = 0;
        int evenSum = 0;
        int j = 1;

        while (j <= 120)
        {
            if (j % 2 == 0)
            {
                evenSum += j;
            }
            else
            {
                oddSum += j;
            }
            j++;
        }

        Console.WriteLine("Tek sayıların toplamı: " + oddSum);
        Console.WriteLine("Çift sayıların toplamı: " + evenSum);
    }
}
