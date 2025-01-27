// 2. Um usuário quer calcular suas despesas mensais. O exercício consiste em solicitar ao usuário que insira suas despesas até que ele digite um valor negativo, sinalizando o fim da entrada. O aluno deve somar as despesas e apresentar o total, utilizando while, do while e for. 

/*while
double despesas = 0;
double despesa;

Console.WriteLine("Digite suas despesas (Insira um valor negatico para sair)");

while (true)
{
    despesa = Convert.ToDouble(Console.ReadLine());
    if (despesa < 0) break;
    despesas += despesa;
}
Console.WriteLine($"Total de despesas: {despesas}");*/

/*do while 
double despesas = 0;
double despesa;

do
{
    Console.WriteLine("Digite suas despesas (Insira um valor negatico para sair)");
    despesa = Convert.ToDouble(Console.ReadLine());
    if (despesa >= 0) despesas += despesa;
} while (despesa >= 0);
Console.WriteLine($"Total de despesas: {despesas}");*/

//for 
double despesas = 0;
double despesa;

for (;;)
{
    Console.WriteLine("Digite suas despesas (Insira um valor negatico para sair)");
    despesa = Convert.ToDouble(Console.ReadLine());
    if (despesa < 0) break;
    despesas += despesa;
}
Console.WriteLine($"Total de despesas: {despesas}");

