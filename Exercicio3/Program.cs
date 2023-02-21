
Console.WriteLine("Digite a 1 Nota:");
var nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a 2 Nota:");
var nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a 3 Nota:");
var nota3 = double.Parse(Console.ReadLine());


double media = (nota1 + nota2 + nota3) / 3;

if (media >= 6 )
{
  Console.WriteLine($"Aluno Aprovado com média {media} ");
}
else if (media >= 5 ){
  Console.WriteLine($"Aluno em Recuperação com média {media} ");
}
else{
  Console.WriteLine($"Aluno Reprovado com média {media} ");
}