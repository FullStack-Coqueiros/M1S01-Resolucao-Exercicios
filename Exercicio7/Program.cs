Console.WriteLine("Digite o nome do aluno:");
string nome = Console.ReadLine();


Console.WriteLine("Digite a quantidade de notas: ");
int quantidadeNotas;
while(!int.TryParse(Console.ReadLine(), out quantidadeNotas)){
   Console.WriteLine("Numero Invalido, por favor entre novamente com a nota");
}

double[] notas = new double[quantidadeNotas];

for(int i = 0; i < quantidadeNotas; i++){
  Console.WriteLine("Digite a " + (i +1) + " Nota:");
  notas[i] = double.Parse(Console.ReadLine());
}

double soma = 0;

Console.WriteLine($"O Boletin de Aluno: {nome} ");
for(int i = 0; i < quantidadeNotas; i++){
  Console.WriteLine($"N{(i+1)}: {notas[i]}");
  soma+= notas[i];
  //soma = soma +nota;
}
double media = soma / quantidadeNotas;

string status;
if (media >= 6 )
{
  status = "Aprovado"; 
}
else if (media >= 5 ){
  status = "Recuperação";
}
else{
  status = "Reprovado"; 
}


Console.WriteLine($"Média: {media} - {status}");