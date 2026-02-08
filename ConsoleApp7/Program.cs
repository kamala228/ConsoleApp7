Random rnd = new Random();

Console.WriteLine("Enter userCount: ");
int.TryParse(Console.ReadLine(), out int userCount);

int[] mss1 = new int[userCount];
int[] mss2 = new int[userCount];
int[] mss3 = new int[userCount];

Console.WriteLine("Enter min: ");
int.TryParse(Console.ReadLine(), out int userMin);

Console.WriteLine("Enter max: ");
int.TryParse(Console.ReadLine(), out int userMax);

if (userMin > userMax)
{
    int tmp = userMin;
    userMin = userMax;
    userMax = tmp;
}

for (int i = 0; i < mss1.Length; i++)
{
    int tmpRand = rnd.Next(userMin, userMax);
    mss1[i] = tmpRand;

    if (tmpRand % 2 == 0)
    {
        mss2[i] = tmpRand;
    }
    else
    {
        mss3[i] = tmpRand;
    }
}

for (int i = 0; i < mss1.Length; i++)
{
    Console.Write(mss1[i] + " ");
}
Console.WriteLine(" ");

for (int i = 0; i < mss2.Length; i++)
{
    if (mss2[i] == 0) { }
    else { Console.Write(mss2[i] + " "); }
}
Console.WriteLine(" ");

for (int i = 0; i < mss3.Length; i++)
{
    if (mss3[i] == 0) { }
    else { Console.Write(mss3[i] + " "); }
}
Console.WriteLine(" ");