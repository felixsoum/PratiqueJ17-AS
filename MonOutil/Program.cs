// See https://aka.ms/new-console-template for more information

// 1) demander le nom de l'utilisateur et l'accueilir
// ex: bienvenue ___ à l'application MonOutil
Console.WriteLine("What is your name");

// string interpolation, interpolation de chaine
string line = Console.ReadLine();
Console.WriteLine($"Welcome {line} to the application!!");

// 2) demander l'utilisateur d'entrer une température en Celsius
Console.WriteLine($"Enter your temperature in Celsius!");
double temperatureEnCelcius = Convert.ToDouble(Console.ReadLine());
double temperatureEnFahrenheit = temperatureEnCelcius * 9 / 5 + 32;

// convertir la température en Fahrenheit et mettre le résultat
// dans la console
Console.WriteLine($"Your temperature in Fahrenheit is {temperatureEnFahrenheit}");