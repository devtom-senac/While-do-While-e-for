// 10.Um vendedor de passagens deseja saber quantas passagens ele vendeu em um dia. O aluno deve pedir ao usuário para inserir o valor das passagens vendidas até que ele digite um valor negativo. O total de passagens vendidas deve ser calculado e apresentado utilizando while, do while e for.

// usando while
/*
double valor;
double valorTotal = 0;

while (true)
{
    Console.WriteLine("Digite o valor da passagem (valor negativo para finalizar)");
    valor = Convert.ToDouble(Console.ReadLine());
    if (valor < 0) break;
    valorTotal += valor;
}

Console.WriteLine($"O valor total das passagens é R$ {valorTotal}"); */

// usando do while 

//double valor;
/*
double valor;
double valorTotal = 0;

do
{
    Console.WriteLine("Digite o valor da passagem (valor negativo para finalizar)");
    valor = Convert.ToDouble(Console.ReadLine());
    if (valor >= 0) valorTotal += valor;
} while (valor >= 0);

Console.WriteLine($"O valor total das passagens é R$ {valorTotal}"); */

// usando for 
/*
double valor;
double valorTotal = 0;

for (;;)
{
    Console.WriteLine("Digite o valor da passagem (valor negativo para finalizar)");
    valor = Convert.ToDouble(Console.ReadLine());
    if (valor < 0) break;
    valorTotal += valor; 
} 

Console.WriteLine($"O valor total das passagens é R$ {valorTotal}"); */