namespace income_tracker;

// TODO: Make settings working function. 
// TODO: Make income tracker for year functioning
// TODO: Make all previus months and year save to a JSON file

// LAST UPDATE: 22 Oct 2024

class Program
{
    public static int menuChoice;

    public static int expenseAmount;
    public static string expenseName;

    static void Main(string[] args)
    {
        Console.WriteLine("[1] Income tracker for month");
        Console.WriteLine("[2] Income tracker for year");
        Console.WriteLine("[3] Settings");

        try
        {
            menuChoice = int.Parse(Console.ReadLine());

        }
        catch(FormatException)
        {
            System.Console.WriteLine("Invalid input format! Please insert a number!");
        }
        catch(Exception ex)
        {
            System.Console.WriteLine("Error occured: " + ex.Message);
        }


        switch(menuChoice){
            case 1:
                System.Console.WriteLine("Enter all expenses this month");
                System.Console.Write("Expense name (workers salary, tools, software ect.): ");
                expenseName = Console.ReadLine();

                System.Console.Write("Expense ammount (in USD): ");
                expenseAmount = int.Parse(Console.ReadLine());

                Expense newExpense = new Expense{
                    _expenseName = expenseName,
                    _expenseAmmount = expenseAmount
                };

                break;
            
            case 2: 
                System.Console.WriteLine("Under construction..");
                break;

            case 3:
                System.Console.WriteLine("Under constrution....");
                break;

            default:
                System.Console.WriteLine("Invalid option!");
                break;
        }
    }
}


public class Expense(){
    public string _expenseName {get; set;}
    public int _expenseAmmount {get; set;}
}