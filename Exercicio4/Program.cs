Console.WriteLine("Digite o valor do sarário: ");
var salario = double.Parse(Console.ReadLine());

int percentual;

if (salario <= 900){
  percentual = 0;
}
else if (salario <= 1500){
  percentual = 5;
}
else if (salario <= 2500){
  percentual = 10;
}
else {
  percentual = 20;
}

var imposto = salario / 100* percentual;

Console.WriteLine($"o valor do imposto será = R$ {imposto}");
