// See https://aka.ms/new-console-template for more information
using Garage_1._0.UI;
using Garage_1._0;

// Create a garage handler with an initial capacity
Console.WriteLine(  "Welcome to the Garage System! ");

Console.WriteLine("Enter the initial capacity for the garage: ");
int capacity = int.Parse(Console.ReadLine());

// Initialize GarageHandler with the user-defined capacity
GarageHandler garageHandler = new GarageHandler(capacity);

// Initialize ConsoleUI and pass the garage handler
ConsoleUI userInterface = new ConsoleUI (garageHandler);

// Display the menu to start interacting with the user
userInterface.DisplayMenu();

Console.WriteLine("Thank you for using the Garage System!");


    