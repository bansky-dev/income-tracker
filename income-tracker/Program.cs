namespace income_tracker;

// TODO: Make settings working function. 
// TODO: Make income tracker for year functioningthe code 
// Clean up 

// LAST UPDATE: 26 Oct 2024

class Program
{
    public static int menuChoice;

    public static int expenseAmount = 1;

    public static int finalExpenseAmount;
    public static string expenseName;

    public static string expenseNameObject;

    static void Main(string[] args)
    {
        List<Expense> expenses = new List<Expense>();  // List to store Expense objects


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
                

                while(expenseAmount > 0){
                    System.Console.Write("Expense name (workers salary, tools, software ect.): ");
                    expenseName = Console.ReadLine();

                    System.Console.Write("Expense ammount (in USD) (type 0 to exit): ");
                    expenseAmount = int.Parse(Console.ReadLine());

                    if(expenseAmount == 0)
                        break;

                    Expense expense = new Expense{
                        _expenseName = expenseName,
                        _expenseAmmount = expenseAmount

                        
                    };
                    expenses.Add(expense);


                }

                Console.WriteLine("\nList of all expenses:");
                foreach (var expense in expenses)
                {
                    Console.WriteLine($"Expense Name: {expense._expenseName}");
                }
                

                

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

    public static void objectCreatedCheck(){
        System.Console.WriteLine("Object created");
    }
}