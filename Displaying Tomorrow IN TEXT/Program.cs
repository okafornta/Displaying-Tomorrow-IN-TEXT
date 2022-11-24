//TASK: I will write a program that displays tomorrow’s date.

// Today's date 
DateTime today = DateTime.Today;

// Tomorrow date
DateTime tomorrow = today.AddDays(1);

// Output 
Console.WriteLine("Today is " + today.ToLongDateString() + ".\n");

Console.WriteLine("I want to be good with C# before " + tomorrow.ToLongDateString() + ".");

// Waiting for Enter
Console.ReadLine();