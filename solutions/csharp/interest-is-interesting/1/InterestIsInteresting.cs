static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        return balance switch
        {
            < 0 => 3.213f,
            < 1000 => 0.5f,
            >= 1000 and < 5000 => 1.621f,
            _ => 2.475f
        };
    }

    public static decimal Interest(decimal balance)
    {
        var interestRate = InterestRate(balance);

        return balance * ((decimal)interestRate / 100);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        var interest = Interest(balance);
        
        return balance + interest;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        var years = 0;

        if (balance >= targetBalance) return years;
        
        var currentBalance = balance;
        do
        {
            currentBalance = AnnualBalanceUpdate(currentBalance);
            years++;
        } while (currentBalance < targetBalance);

        return years;
    }
}
