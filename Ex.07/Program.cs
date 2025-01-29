// 7.Um ciclista deseja saber a distância total que percorreu. Para isso, o aluno deve solicitar que o usuário insira as distâncias percorridas em cada dia até que um valor negativo seja digitado. A soma das distâncias deve ser calculada e exibida utilizando as três estruturas de repetição. 

// usando while 

/*double distanciaTotal = 0;
double distancia;

Console.WriteLine("Digite as distâncias percorridas a cada dia.  (valor negativo para encerrar.)");

while (true)
{
    distancia = Convert.ToDouble(Console.ReadLine());
    if (distancia < 0) break; 
    distanciaTotal += distancia;
}

Console.WriteLine($"Distância total percorrida: {distanciaTotal} km");*/

// usando do while 

/*double distanciaTotal = 0;
double distancia;

do
{
    Console.WriteLine("Digite as distâncias percorridas a cada dia.  (valor negativo para encerrar.)");
    distancia = Convert.ToDouble(Console.ReadLine());
    if (distancia >= 0) distanciaTotal += distancia;
} while (distancia >= 0);

Console.WriteLine($"Distância total percorrida: {distanciaTotal} km");*/

// usando for 

/*double distanciaTotal = 0;
double distancia;

for (;;)
{
    Console.WriteLine("Digite as distâncias percorridas a cada dia.  (valor negativo para encerrar.)");
    distancia = Convert.ToDouble(Console.ReadLine());
    if (distancia < 0) break;
    distanciaTotal += distancia;
}
Console.WriteLine($"Distância total percorrida: {distanciaTotal} km");*/

