// 9.Um cliente deseja saber o total de suas compras em um supermercado. O aluno deve solicitar que o usuário insira o valor de cada compra até que ele digite 0. A soma dos valores das compras deve ser implementada usando as très estruturas de repetição. 

// usando while 
/*
double valorCompra;
double totalCompras = 0;

Console.WriteLine("Digite o valor de cada compra. Digite 0 para sair.");

while (true)
{
    valorCompra = Convert.ToDouble(Console.ReadLine());
    if (valorCompra == 0) break;
    totalCompras += valorCompra;
}

Console.WriteLine($"Total das compras: R$ {totalCompras}"); */

// usando do while 
/*
double valorCompra;
double totalCompras = 0;

do
{
    Console.WriteLine("Digite o valor de cada compra. Digite 0 para sair.");
    valorCompra = Convert.ToDouble(Console.ReadLine());
    if (valorCompra != 0) totalCompras += valorCompra;
} while (valorCompra != 0);

Console.WriteLine($"Total das compras: R$ {totalCompras}"); */

// usando for 
/*
double valorCompra;
double totalCompras = 0;

for (; ;)
{
    Console.WriteLine("Digite o valor de cada compra. Digite 0 para sair.");
    valorCompra = Convert.ToDouble(Console.ReadLine());
    if (valorCompra == 0) break;
    totalCompras += valorCompra;
}

Console.WriteLine($"Total das compras: R$ {totalCompras}"); */
