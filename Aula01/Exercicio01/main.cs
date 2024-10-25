using System;

class Program {
  public static void Main (string[] args) {

    //----- EXEMPLO 01 -----//
    Console.WriteLine ("Digite algo: ");

    //Capturando a entrada do usuário
    string entrada = Console.ReadLine();

    //Exibindo a entrada do usuário
    Console.WriteLine("Você digitou: " + entrada);

    //----- EXEMPLO 02 -----//
    Console.WriteLine("-----------------------");

    //Capturando o primeiro número
    Console.WriteLine("Digite o primeiro número: ");
    string valor1 = Console.ReadLine();
    int num1 = int.Parse(valor1);

    //Capturando o segundo número
    Console.WriteLine("Digite o segundo número: ");
    string valor2 = Console.ReadLine();
    int num2 = int.Parse(valor2);

    //Calculando SOMA
    Console.WriteLine("A soma dos números é: " + (num1 + num2));

    //MULTIPLICAÇÃO
    Console.WriteLine("A multiplicação dos números é: " + (num1 * num2));

    //DIVISÃO
    Console.WriteLine("A divisão dos números é: " + (num1 / num2));

    //SUBTRAÇÃO
    Console.WriteLine("A subtração dos números é: " + (num1 - num2));
  }
}
