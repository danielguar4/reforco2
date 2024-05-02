Console.WriteLine(" -- -- -- Formulario de Pessoa -- -- --");
Console.WriteLine("Qual é o seu nome: ");
string nome = Console.ReadLine()!;

Console.WriteLine("Qual é sua idade: ");
string resposta = Console.ReadLine()!;
int idade = 0;
if (!int.TryParse(resposta, out idade))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Aviso! Você colocou um texto!");
}

Console.WriteLine("Quantas pessoas tem em sua casa: ");
resposta = Console.ReadLine()!;
int pessoas = 0;
if (!int.TryParse(resposta, out pessoas))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Aviso! Você colocou um texto!");
}

Console.WriteLine("A média da energia gasta  : ");
resposta = Console.ReadLine()!;
double energiaGasta = 0;
if (!double.TryParse(resposta, out energiaGasta))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Aviso! Você colocou um texto!");
}

Console.ResetColor();