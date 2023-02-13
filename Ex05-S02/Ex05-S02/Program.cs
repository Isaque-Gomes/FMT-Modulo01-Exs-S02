// Criar uma classe chamada Cobrar
using Ex05_S02;

decimal valor1;
decimal valor2;

Console.WriteLine("Digite o valor devido");
valor1 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Digite da multa devido");
valor2 = decimal.Parse(Console.ReadLine());

Cobrar cobrar = new Cobrar(valor1, valor2);
cobrar.Calcular();