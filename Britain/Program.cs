using BritainInterview.Service;

Console.Write("Input a string: ");

string s = Console.ReadLine();

var validation = new BracketValidation();

Console.WriteLine(validation.IsValid(s));
