// 9.Um cliente deseja saber o total de suas compras em um supermercado. O aluno deve solicitar que o usuário insira o valor de cada compra até que ele digite 0. A soma dos valores das compras deve ser implementada usando as très estruturas de repetição. 

// usando while 

double totalCompras = 0;
double valorCompra;

Console.WriteLine("Digite o valor de cada compra. Digite 0 para encerrar.");

while (true)
{
    valorCompra = Convert.ToDouble(Console.ReadLine());
    if (valorCompra == 0) break;
    totalCompras += valorCompra;
}

Console.WriteLine($"Total das compras: R$ {totalCompras}");
