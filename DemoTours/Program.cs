using MetTours;
using System.Reflection;
class Program
{
    static void Main(string[] args)
    {
        int days = int.Parse(args[0]);
        int noofperson = int.Parse(args[1]);
        Type t = Type.GetType($"MetTours.{args[2]},Assignment", true);
        object policy = Activator.CreateInstance(t); //dynamic activation
        MethodInfo scheme = t.GetMethod(args[3]);
        double daysRent = (double)scheme.Invoke(policy, [days, noofperson]);

        double totalTourExpense = daysRent * days;

        Console.WriteLine("Total tour expense is {0} For {1}", totalTourExpense, t.Name);
    }
}