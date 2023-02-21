Console.WriteLine("Digite o 1 lado do triangulo: ");
int lado1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o 2 lado do triangulo: ");
int lado2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o 3 lado do triangulo: ");
int lado3 = int.Parse(Console.ReadLine());

if(lado1 + lado2 > lado3 && lado3 + lado2 > lado1 && lado3 + lado1 > lado2){
  if(lado1 == lado2 && lado2 == lado3 && lado1 == lado3){
    Console.WriteLine("Triângulo Equilátero");
  }
  else if(lado1 == lado2 || lado2 == lado3 || lado1 == lado3){
    Console.WriteLine("Triângulo Isósceles");
  }
  else if(lado1 != lado2 && lado2 != lado3 && lado1 != lado3){
    Console.WriteLine("Triângulo Escaleno");
  }
}
else{
  Console.WriteLine("as medidas não formam um triângulo ");
}