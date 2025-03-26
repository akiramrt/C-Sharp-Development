// ======================================AULA 18-03==========================================

using System.Globalization;

// ==========================================================================================

// string user = "eduardo.muarata";
// DateTime lastLogin = DateTime.Now;
// Console.WriteLine($"User: {user}");
// Console.WriteLine($"Last Login: {lastLogin}");

// ==========================================================================================

// Console.Write("Enter your date of birth: ");
// string input = Console.ReadLine();

// if (DateOnly.TryParseExact( input, 
//                             "dd/MM/yyyy", 
//                             CultureInfo.InvariantCulture, 
//                             DateTimeStyles.None, 
//                             out DateOnly dateBirth)) 
// {
//     Console.WriteLine($"Date of birth: {dateBirth}");
//     DateOnly today = DateOnly.FromDateTime(DateTime.Now);

//     int age = today.Year - dateBirth.Year;

//     if (today < dateBirth.AddYears(age))
//         age--;

//     Console.WriteLine($"User age: {age}.");
//     Console.WriteLine(age >= 18 ? "Registration Permitted." : "Registration Denied.");

// } else {
//     Console.WriteLine("Invalid date format. Please use dd/MM/yyyy.");
// }

// ==========================================================================================

// TimeOnly open = new TimeOnly(10, 30);
// TimeOnly close = new TimeOnly(16, 00);    

// Console.WriteLine($"Restaurant opens at: {open}");
// Console.WriteLine($"Restaurant closes at: {close}");

// DateTime currentTime = DateTime.Now;
// TimeOnly orderTime = TimeOnly.FromDateTime(currentTime);

// bool opening = orderTime >= open && orderTime < close;
// Console.WriteLine($"Restaurant opens at: {orderTime}? {opening}");

// ==========================================================================================

// TimeOnly open = new TimeOnly(10, 30);
// TimeOnly close = new TimeOnly(17, 30);

// Console.WriteLine($"Restaurant opens at: {open}");
// Console.WriteLine($"Restaurant closes at: {close}");

// TimeSpan durationWork = new TimeSpan();
// durationWork = close - open;

// Console.WriteLine($"Total hours worked in the day: {durationWork}");

// ==========================================================================================

// Console.Write("Enter your date of birth (dd/MM/yyyy): ");
// string input = Console.ReadLine();

// if (DateOnly.TryParseExact( input, 
//                             "dd/MM/yyyy", 
//                             CultureInfo.InvariantCulture, 
//                             DateTimeStyles.None, 
//                             out DateOnly dateBirth)) 
// {
//     Console.WriteLine($"Registered date of birth: {dateBirth}");
//     DateOnly today = DateOnly.FromDateTime(DateTime.Now);
// }

// ==========================================================================================

// DateTimeOffset orderDate = DateTimeOffset.Now;
// Console.WriteLine($"Order time (local): {orderDate}");

// ==========================================================================================

// DateTimeOffset currentTime = DateTimeOffset.Now;
// TimeSpan displacement = currentTime.Offset;

// TimeZoneInfo localTimeZona = TimeZoneInfo.Local;
// Console.WriteLine($"Local Date and Time: {currentTime}");
// Console.WriteLine($"System Time Zone (UTC Offset): {displacement}");
// Console.WriteLine($"Time Zone Name: {localTimeZona.StandardName}");

// ==========================================================================================

Console.WriteLine("===== CALCULATION OF DUE DATE AND INVOICE PAYMENT =====");
Console.Write("Enter the due date (dd/MM/yyyy): ");
string inputDue = Console.ReadLine();

if (!DateOnly.TryParseExact( inputDue, 
                            "dd/MM/yyyy", 
                            CultureInfo.InvariantCulture, 
                            DateTimeStyles.None, 
                            out DateOnly dueDate)) 
{
    Console.WriteLine("Erro: Invalid date format! Please use dd/MM/yyyy format.");
    return;
}

DateOnly currentTime = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine("You have already made the payment? (Y/N): ");
string answer = Console.ReadLine().Trim().ToUpper();

if (answer == "Y")
{
    Console.Write("Enter the due date (dd/MM/yyyy): ");
    string inputPayment = Console.ReadLine();

    if (!DateOnly.TryParseExact( inputPayment, 
                                "dd/MM/yyyy", 
                                CultureInfo.InvariantCulture, 
                                DateTimeStyles.None, 
                                out DateOnly paymentDate)) 
    {
        Console.WriteLine("Erro: Invalid date format! Please use dd/MM/yyyy format.");
        return;
    }

    if (paymentDate <= dueDate)
    {
        Console.WriteLine($"Payment made on {paymentDate}. Invoice paid on time!");
    } else {
        int daysLate = paymentDate.DayNumber - dueDate.DayNumber;
        Console.WriteLine($"Payment made on {paymentDate}. Invoice overdue by {daysLate} days!");
    }
}