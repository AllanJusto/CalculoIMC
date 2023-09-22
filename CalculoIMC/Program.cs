using System;

class CalculadoraIMC
{
    static void Main()
    {
        Console.WriteLine("Calculadora de IMC (Índice de Massa Corporal)");
        Console.Write("Digite o seu peso (em kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a sua altura (em metros): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        // Cálculo do IMC
        double imc = CalcularIMC(peso, altura);

        // Exibição do resultado
        Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

        // Interpretando o IMC
        InterpretarIMC(imc);

        Console.ReadLine(); // Aguarda uma tecla ser pressionada para encerrar o programa
    }

    // Função para calcular o IMC
    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    // Função para interpretar o IMC
    static void InterpretarIMC(double imc)
    {
        Console.Write("Classificação: ");
        if (imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (imc < 24.9)
        {
            Console.WriteLine("Peso normal");
        }
        else if (imc < 29.9)
        {
            Console.WriteLine("Sobrepeso");
        }
        else if (imc < 34.9)
        {
            Console.WriteLine("Obesidade Grau I");
        }
        else if (imc < 39.9)
        {
            Console.WriteLine("Obesidade Grau II");
        }
        else
        {
            Console.WriteLine("Obesidade Grau III");
        }
    }
}
