
//1 topshiriq

int i=1;
int sum=0;

while(i<=1000)
{
    if(i % 2 == 0)
    {
        i++;
    }
    else
    {
        sum +=i;
        i++;
    }
}
System.Console.WriteLine($"Toq sonlar yigindisi: {sum}");

//2 topshiriq

int[] arrayAdd = {4,7,10,3,2};
int maxNumber = arrayAdd[0];
int minNumber = arrayAdd[0];

for (int i = 0; i < arrayAdd.Length; i++)
{
    if(arrayAdd[i] > maxNumber)
    {
        maxNumber=arrayAdd[i];
    }    
}
System.Console.WriteLine($"kattasi: {maxNumber}");

for (int i = 0; i < arrayAdd.Length; i++)
{
    if(arrayAdd[i]<minNumber)
    {
        minNumber=arrayAdd[i];
    }    
}
System.Console.WriteLine($"kichigi: {minNumber}");
System.Console.WriteLine($"Ko\'paytmasi: {maxNumber * minNumber}");

//3 topshiriq

System.Console.WriteLine("N sonini kiriting: ");

int nSoni = Convert.ToInt32(Console.ReadLine());
int sonFactorial=1;

for(int i=1; i<=nSoni; i++)
{
    sonFactorial *=i;
}
System.Console.WriteLine($"N factorial: {sonFactorial}");