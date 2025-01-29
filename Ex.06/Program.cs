// 6.Durante uma eleição, um mesário deve contar os votos. O aluno deverá pedir ao usuário para inserir os votos (1 para candidato A, 2 para candidato B) até que ele digite 0. O programa deve contar quantos votos cada candidato recebeu, implementando a solução com while, do while e for. 

// usando while 
/*
int votosA = 0, votosB = 0;
int voto;

Console.WriteLine("Digite os votos (1 para Candidato A, 2 para Candidato B, 0 para encerrar):");

while (true)
{
    voto = Convert.ToInt32(Console.ReadLine());

    if (voto == 0) break;  // Encerra o loop se o voto for 0
    if (voto == 1) votosA++;
    else if (voto == 2) votosB++;
    else Console.WriteLine("Número não aceito");
}

Console.WriteLine($"Candidato A recebeu {votosA} votos, Candidato B recebeu {votosB} votos."); */

// usando do while
/*
int votosA = 0;
int votosB = 0;
int voto;

do
{
    Console.WriteLine("Digite os votos (1 para Candidato A, 2 para Candidato B, 0 para encerrar):");
    voto = Convert.ToInt32(Console.ReadLine());
    if (voto == 1) votosA++;
    else if (voto == 2) votosB++;
    else Console.WriteLine("Número não aceito");

} while (voto != 0);

Console.WriteLine($"Candidato A recebeu {votosA} votos, Candidato B recebeu {votosB} votos."); */

// usando for
/*
int votosA = 0;
int votosB = 0;
int voto;

for (;;)
{
    Console.WriteLine("Digite os votos (1 para Candidato A, 2 para Candidato B, 0 para encerrar):");
    voto = Convert.ToInt32(Console.ReadLine());
    if (voto == 0) break;  
    if (voto == 1) votosA++;
    else if (voto == 2) votosB++;
    else Console.WriteLine("Número não aceito");
}

Console.WriteLine($"Candidato A recebeu {votosA} votos, Candidato B recebeu {votosB} votos."); */







