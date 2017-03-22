public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        if ((IsDivisbleByFour(year) 
            && !IsDivisbleByOneHundred(year))
            || IsDivisbleByFourHundred(year))
        {
            return true;
        }

        return false;
    }

    private static bool IsDivisbleByFour(int year)
    {
        return year % 4 == 0;
    }

    private static bool IsDivisbleByOneHundred(int year)
    {
        return year % 100 == 0;
    }

    private static bool IsDivisbleByFourHundred(int year)
    {
        return year % 400 == 0;
    }
}