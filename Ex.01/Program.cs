﻿// 1. Um funcionário deseja contar quantos dias de trabalho ele teve em um mês. Para isso, ele deve inserir os dias trabalhados (de 1 a 31) até que digite 0, que indica que terminou de informar os dias. O aluno deve implementar essa contagem utilizando as estruturas de repetição while, do while e for. 

// usando While 
/*
int diasTrabalhados = 0;
int dia;

Console.WriteLine("Para iniciar a contagem de dias trabalhados ,informe o dia trabalhado (digite 0 para concluir): ");

while (true)
{
    dia = Convert.ToInt32(Console.ReadLine());
    if (dia == 0) break;
    Console.WriteLine("Informe o próximo dia trabalhado: (Digite 0 para concluir");
    diasTrabalhados++;
}

Console.WriteLine($"Total de dias trabalhados: {diasTrabalhados}"); */

// usando do while
/*
int diasTrabalhados = 0;
int dia;

do
{
    Console.WriteLine("Para iniciar a contagem de dias trabalhados ,informe o dia trabalhado (digite 0 para concluir): ");
    dia = Convert.ToInt32(Console.ReadLine());
    if (dia != 0) diasTrabalhados++;
} while (dia != 0);

Console.WriteLine($"Total de dias trabalhados: {diasTrabalhados}"); */

// usando for
/*
int diasTrabalhados = 0;
int dia;

for (;;)
{
    Console.WriteLine("Para iniciar a contagem de dias trabalhados ,informe o dia trabalhado (digite 0 para concluir): ");
    dia = Convert.ToInt32(Console.ReadLine());
    if (dia == 0) break;
    diasTrabalhados++;  
}

Console.WriteLine($"Total de dias trabalhados: {diasTrabalhados}"); */