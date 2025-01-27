// 5. Um gerente de loja quer saber quantos produtos estão em estoque. O aluno deve solicitar que o usuário insira a quantidade de produtos recebidos e vendidos até que ele digite 0. Depois disso, o programa deve calcular a quantidade total de produtos em estoque, utilizando as três estruturas de repetição. 

// while 

/*int TotalEstoque = 0;
int recebidos, vendidos;

Console.WriteLine("Digite a quantidade de produtos recebidos e vendidos.(Digite 0 para sair.)");

while (true)
{
    Console.Write("Recebidos: ");
    recebidos = Convert.ToInt32(Console.ReadLine());
    if (recebidos == 0) break;
    Console.Write("Vendidos: ");
    vendidos = Convert.ToInt32(Console.ReadLine());
    TotalEstoque += recebidos - vendidos;
}

Console.WriteLine($"Total de produtos em estoque: {TotalEstoque}");*/

// do while 

/*int TotalEstoque = 0;
int recebidos, vendidos;

do
{
    Console.WriteLine("Digite a quantidade de produtos recebidos e vendidos.(Digite 0 para sair.)");
    Console.Write("Recebidos: ");
    recebidos = Convert.ToInt32(Console.ReadLine());
    if (recebidos == 0) break;
    Console.Write("Vendidos: ");
    vendidos = Convert.ToInt32(Console.ReadLine());
    TotalEstoque += recebidos - vendidos;
} while (true);

Console.WriteLine($"Total de produtos em estoque: {TotalEstoque}");*/

// for 

/*int TotalEstoque = 0;
int recebidos, vendidos;

for (; ; )
{
    Console.WriteLine("Digite a quantidade de produtos recebidos e vendidos.(Digite 0 para sair.)");
    Console.Write("Recebidos: ");
    recebidos = Convert.ToInt32(Console.ReadLine());
    if (recebidos == 0) break;
    Console.Write("Produtos vendidos: ");
    vendidos = Convert.ToInt32(Console.ReadLine());
    TotalEstoque += recebidos - vendidos;
}
Console.WriteLine($"Total de produtos em estoque: {TotalEstoque}");*/
