using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a string que deseja inverter: ");
        string stringDigitada = Console.ReadLine();
        string stringInvertida = InverterString(stringDigitada);
        Console.WriteLine("String invertida: " + stringInvertida);
    }
    static string InverterString(string stringDigitada)
    {
        char[] charArray = stringDigitada.ToCharArray();
        int tamanho = charArray.Length;
        for (int i = 0; i < tamanho / 2; i++)
        {
            // Inverte a String
            char temp = charArray[i];
            charArray[i] = charArray[tamanho - 1 - i];
            charArray[tamanho - 1 - i] = temp;
        }
        return new string(charArray);
    }
}
