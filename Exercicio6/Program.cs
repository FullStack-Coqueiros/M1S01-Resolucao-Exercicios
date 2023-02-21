Console.WriteLine("Digite um numero para calcular a tabuada ");
int numero = int.Parse(Console.ReadLine());

for (int i = 0; i<= 10; i++){
  Console.WriteLine($"{numero} X {i} = {numero *i}");
}

