using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Never make a new line. ")
        Console.WriteLine("Second text: This not in new line, but output after this will display in new line")
        Console.WriteLine("Last line in new line")

	string name = "Yukie muhammad billal"
	string address = "indonesia" , print_var = "You event can print a variabel"
	int age = 19
	double height = 155.5
	float f_height = 155.5f // user less memory, postfix f
	decimal d_height = 155.5m // user high memory, postfix m
	char first_letter = 'a', last_letter = '1'
	bool isLife = true, kekkon = false, kanojo = false

	Console.WriteLine(print_var)

	int x = 2, y = 4. z = 9, result
	
	result = x + 1
	Console.WriteLine(result)

	result = y - 2
	Console.WriteLine(result)
	
	result = z *  2
	Console.WriteLine(result)

	result = z / 3
	Console.WriteLine(result)
	
	result = y % 2
	Console.WriteLine(result)

	x += 6 // 10
	Console.WriteLine(x)

	y -= 1 // 3
	Console.WriteLine(y)

	z /= y // 3
	Console.WriteLine(z)

	y *= x // 30
	Console.WriteLine(y)

	Console.WriteLine("Inrement & decrement")
	Console.WriteLine(x++) // 10	
	Console.WriteLine(x) // 11
	
	Console.WriteLine(x--) // 11	
	Console.WriteLine(x) // 10

	Console.WriteLine(++x) // 11
	Console.WriteLine(x) // 11

	Console.WriteLine(--x) // 10	
	Console.WriteLine(x) // 10

	string user_input = Console.ReadLine()
	Console.WriteLine(user_input)

	int input_int = Convert.ToInt32(Console.ReadLine())
	Console.WriteLine(input_int)
    }
}
