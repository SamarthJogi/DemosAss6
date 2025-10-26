namespace MetTours;

public class EconomyTours
{
    public double DaysRent(int days, int noPersons)
    {
        double rent = 500;
        if (days > 6)
            rent = rent - 100;
        if (noPersons >= 4)
            rent -= 100;
        return rent * noPersons;
    }

    public double DaysRentForCommon(int days, int noPersons)
    {
        double rent = 400;
        if (days > 6)
            rent = rent - 100;
        if (noPersons >= 4)
            rent -= 100;
        return rent * noPersons;
    }

     public double DaysRentForStudents(int days, int noPersons)
    {
        double rent = 350;
        if (days > 6)
            rent = rent - 100;
        if (noPersons >= 4)
            rent -= 100;
        return rent * noPersons;
    }
}