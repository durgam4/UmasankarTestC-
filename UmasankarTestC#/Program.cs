

using HR;
using BethanysPieShopHRM.Logic;

using UmasankarTestC;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);


bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

double receivedWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");

bethany.firstName = "John";
bethany.hourlyRate = 10;

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork(12);
bethany.PerformWork();
bethany.ReceiveWage();
bethany.CalculateWage();
    
    Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);

george.DisplayEmployeeDetails();
george.PerformWork();
george.PerformWork();
george.PerformWork(3);
george.PerformWork();
george.PerformWork(8);

var receivedWageGeorge = george.ReceiveWage(true);


Console.WriteLine("Welcome to Bethany's Pie Shop HRM");


int amount = 10;
int months = 12;
int bonus = 1000;

int yearlyWage = Utilities.CalculateYearlyWage(amount, months);
int yearlyWageWithBonus = Utilities.CalculateYearlyWage(amount, months, bonus);

Console.WriteLine($"Yearly wage: {yearlyWage}");


//double amountDouble = 1500.0;
//double monthsDouble = 12;
//double bonusDouble = 1000;

//double yearlyWageWithBonusDouble = Utilities.CalculateYearlyWage(amountDouble, monthsDouble, bonusDouble);

//Utilities.UsingOptionalParameters();

//Utilities.UsingNamedArguments();

//Utilities.ManipulatingStrings();

//Utilities.UsingEscapeCharacters();

//Utilities.UsingStringEquality();

//Utilities.ParsingStrings();

WorkTask task; 
task.description = "Clean the floor";
task.hours = 4;
task.PerformWorkTask();

WorkTask task2 = new WorkTask("Clean the toilet", 2);
var x2 = task2.PerformWorkTask();
Console.WriteLine(x2);

Console.WriteLine("First Branch Testing Github");

//Console.ReadLine();


