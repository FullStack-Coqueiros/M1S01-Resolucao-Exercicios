Console.WriteLine("Digite a altura do triangulo");
double altura = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a Base do triangulo");
double baseTriangulo = double.Parse(Console.ReadLine());

double area = baseTriangulo*altura/2;

Console.WriteLine($"A área do triângulo é {area}"); 
