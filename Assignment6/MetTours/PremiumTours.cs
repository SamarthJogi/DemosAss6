namespace MetTours;

public class PremiumTours
{
    public double DaysRent(int days, int noPersons)
    {
        double rent = 1200;
        if (days > 6)
            rent = rent - 100;
        if (noPersons >= 4)
            rent -= 100;
        return rent * noPersons;
    }

    public double DaysRentForCommon(int days, int noPersons)
    {
        double rent = 1200;
        if (days > 6)
            rent = rent - 100;
        if (noPersons >= 4)
            rent -= 100;
        return rent * noPersons;
    }

    public double DaysRentForStudents(int days, int noPersons)
    {
        double rent = 750;
        if (days > 6)
            rent = rent - 100;
        if (noPersons >= 4)
            rent -= 100;
        return rent * noPersons;
    }


    public double DaysRentForWomen(int days, int noPersons)
    {
       double rent = 1200;
        if (days > 6)
            rent = rent - 200;
        if (noPersons >= 4)
            rent -= 200;
        return( rent-200) * noPersons;
    }


    public double DaysRentForSeniors(int days, int noPersons)
    {
        double rent = 1200;
        if (days > 6)
            rent = rent - 100;
        if (noPersons >= 4)
            rent -= 100;
        return (rent-100) * noPersons;
    }
    
    
}