// 8. Um atendente de suporte técnico deseja contar quantas chamadas atendeu em um dia. O aluno deverá pedir ao usuário que insira o tempo de duração de cada chamada em minutos até que ele digite 0. O programa deve calcular o total de minutos atendidos, utilizando while, do while e for. 

// usando while
 
/*int totalChamadas = 0;
int duracao;

Console.WriteLine("Digite o tempo de duração de cada chamada em minutos (0 para encerrar.):");

while (true)
{
    duracao = Convert.ToInt32(Console.ReadLine());
    if (duracao == 0) break;
    totalChamadas += duracao;
}

Console.WriteLine($"Total de minutos atendidos é: {totalChamadas} minutos.");*/

//usando do while 

/*int totalChamadas = 0;
int duracao;

do
{
    Console.WriteLine("Digite o tempo de duração de cada chamada em minutos (0 para encerrar.):");
    duracao = Convert.ToInt32(Console.ReadLine());
    if (duracao != 0) totalChamadas += duracao;
} while (duracao != 0);

Console.WriteLine($"Total de minutos atendidos é: {totalChamadas} minutos.");*/

// usando for 

/*int totalChamadas = 0;
int duracao;

for (; ; )
{
    Console.WriteLine("Digite o tempo de duração de cada chamada em minutos (0 para encerrar.):");
    duracao = Convert.ToInt32(Console.ReadLine());
    if (duracao == 0) break;
    totalChamadas += duracao;
}

Console.WriteLine($"Total de minutos atendidos é: {totalChamadas} minutos.");*/
