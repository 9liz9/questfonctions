namespace S02_fonctions;

class Program
{
    static void Main(string[] args)
    {
       while (true)
        {
            Console.Write("Premier nombre : ");
            float operand1 = float.Parse(Console.ReadLine());

            Console.Write("Deuxième nombre : ");
            float operand2 = float.Parse(Console.ReadLine());

            Console.Write("Choisir une opération (add, subtract, multiply, divide, modulo) : ");
            string operation = Console.ReadLine();

            float result = 0;

            if (operation == "add")
            {
                result = Add(operand1, operand2);
            }
            else if (operation == "subtract")
            {
                result = Subtract(operand1, operand2);
            }
            else if (operation == "multiply")
            {
                result = Multiply(operand1, operand2);
            }
            else if (operation == "divide")
            {
                result = Divide(operand1, operand2);
            }
            else if (operation == "modulo")
            {
                result = Modulo((int)operand1, (int)operand2);
            }
            else
            {
                Console.WriteLine("Opération inconnue.");
                continue;
            }

            Console.WriteLine($"{operand1} {GetOperationSymbol(operation)} {operand2} = {result}");
            Console.WriteLine();
        }
    }

    static float Add(float operand1, float operand2)
    {
        return operand1 + operand2;
    }

    static float Subtract(float operand1, float operand2)
    {
        return operand1 - operand2;
    }

    static float Multiply(float operand1, float operand2)
    {
        return operand1 * operand2;
    }

    static float Divide(float operand1, float operand2)
    {
        return operand1 / operand2;
    }

    static int Modulo(int operand1, int operand2)
    {
        return operand1 % operand2;
    }

    static string GetOperationSymbol(string operation)
    {
        if (operation == "add")
        {
            return "+";
        }
        else if (operation == "subtract")
        {
            return "-";
        }
        else if (operation == "multiply")
        {
            return "x";
        }
        else if (operation == "divide")
        {
            return "/";
        }
        else if (operation == "modulo")
        {
            return "%";
        }
        else
        {
            return "";
        }
    }
}
