Console.Write("Enter movie title: ");
string? title = Console.ReadLine();

Console.Write("Number of tickets: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Price per ticket: ");
double price = Convert.ToDouble(Console.ReadLine());

Console.Write("Duration of Movie in hours: ");
int duration = int.Parse(Console.ReadLine());

Console.Write("Screen Number: ");
int screenNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("First Letter of Seat Row: ");
string? seatRow = Console.ReadLine();

Console.Write("Is 3D Movie [true/false]: ");
bool is3D = Convert.ToBoolean(Console.ReadLine());

double totalCost = number * price;

Console.WriteLine("--------------------------------------------------");
Console.WriteLine($"Movie Title: {title}");
Console.WriteLine($"Tickets: {number} | Total Cost: ${totalCost:F2}");
Console.WriteLine($"Screen: {screenNumber} | Seat Row: {seatRow}");
Console.WriteLine($"Duration: {duration} hours");
Console.WriteLine($"3D Experience: {(is3D ? "Yes" : "No")}");