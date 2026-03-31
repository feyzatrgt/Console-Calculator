Console.WriteLine("- CALCULATOR -");
Console.WriteLine();

int num1, num2, total, diff, prod, quot, calc;

Console.WriteLine("Please select an action...");
Console.WriteLine();
Console.WriteLine("If you want to perform an addition operation, press 1.");
Console.WriteLine("If you want to perform a subtractionn operation, press 2.");
Console.WriteLine("If you want to perform a multiplication operation, press 3.");
Console.WriteLine("If you want to perform a division operation, press 4.");
calc = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Please enter the first number: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the second number:");
num2 = int.Parse(Console.ReadLine());

total = num1 + num2;
diff = num1 - num2;
prod = num1 * num2;
quot = num1 / num2;

if (calc == 1) {
    Console.WriteLine(num1 + "+" + num2 + "=" + total);
} else if (calc == 2) {
    Console.WriteLine(num1 + "-" + num2 + "=" + diff);
} else if (calc == 3) {
    Console.WriteLine(num1 + "*" + num2 + "=" + prod);
} else if (calc == 4) {
    Console.WriteLine(num1 + "/" + num2 + "=" + quot);
} else {
    Console.WriteLine("A wrong key was pressed. Please try again...");
}




Thread.Sleep(3000); 