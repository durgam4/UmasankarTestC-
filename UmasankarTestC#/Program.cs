


using BethanysPieShopHRM.Logic;

using UmasankarTestC;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);


bethany.DisplayEmployeeDetails();
Console.WriteLine("--------------------\n");
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

double receivedWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");

bethany.FirstName = "John";
bethany.hourlyRate = 10;

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork(12);
bethany.PerformWork();
bethany.ReceiveWage();
bethany.CalculateWage();
    
    Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 39);

george.DisplayEmployeeDetails();
george.PerformWork();
george.PerformWork();
george.PerformWork(3);
george.PerformWork();
george.PerformWork(8);
george.GiveBonus();
var receivedWageGeorge = george.ReceiveWage(true);

Manager umasankar = new("Umasankar", "Durgam","durgam4@gmail.com", new DateTime(1984, 3, 28), 40);
umasankar.AttendManagementMeeting();
umasankar.AttendManagementMeeting();
umasankar.GiveBonus();
umasankar.PerformWork();
umasankar.PerformWork(5);

umasankar.CalculateWage();
umasankar.ReceiveWage();
//umasankar.CalculateBonus(5);
umasankar.CalculateBonusAndBonusTax(umasankar.CalculateBonus(5), out int bonusTax);
umasankar.GiveBonus();
umasankar.GiveCompliment();

umasankar.DisplayEmployeeDetails();





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


WorkTask task1 = new("Clean the Floor", 4);

task1.PerformWorkTask();

WorkTask task2 = new("Clean the toilet",2);
task2.PerformWorkTask();


Console.WriteLine("First Branch Testing Github");

//Console.ReadLine();


