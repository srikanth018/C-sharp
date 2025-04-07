using System;

class Savings
{
    public delegate void ReachedThreshold(int currentAmount);
    public event ReachedThreshold? isReached;
    public event ReachedThreshold? isNotReached;

    public int currentSavings = 95;

    public void CalculateSavings(int amount){
        currentSavings += amount;
        if(currentSavings>=100){
            isReached?.Invoke(this.currentSavings);
            return;
        }
        isNotReached?.Invoke(this.currentSavings);
    }

    public void GreaterThanThreshold(int currentAmount){
        Console.WriteLine($"Congrats!!.. You have saved amount more than 100 and your current Amount is Rs.{currentAmount}");
    }

    public void LessThanThreshold(int currentAmount){
        Console.WriteLine($"Oops!!.. You haven't reached amount more than 100 and your current Amount is Rs.{currentAmount}");
    }
}
class Program
{
    public static void Main()
    {
        Savings save = new Savings();
        save.isReached += save.GreaterThanThreshold;
        save.isNotReached += save.LessThanThreshold;

        Console.WriteLine("Enter the amount you want to add to your savings:");
        int amount = Convert.ToInt32(Console.ReadLine());
        save.CalculateSavings(amount);
    }
}