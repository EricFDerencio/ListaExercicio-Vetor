// 2- Faça um programa que leia 5 numeros inteiros e grave em um vetor este vetor deve ser copiado,
// para um novo na sequencia inversa.
// Faça o mesmo copiando para um novo vetor de numeros pares e outro de numeros impares

int[] lista = new int[5];
int[] listainversa = new int[5];
int[] listaPar = new int[5];
int[] listaImpar = new int[5];

void GravaVetor()
{
    for (int i = 0; i < lista.Length; i++)
    {
        Console.Write($"Digite o {i + 1}º Numero: ");

        lista[i] = int.Parse(Console.ReadLine());
    }
}
void ConverteVetorInvertido()
{
    if (lista is null)
        throw new InvalidOperationException("O vetor lista não foi inicializado.");


    for (int i = 0; i < lista.Length; i++)
    {
        listainversa[i] = lista[lista.Length - 1 - i];
    }
}
void SepararVetorPar()
{
    int aux = 0;
    for(int i = 0;i < lista.Length; i++)
    {
        if (lista[i] % 2 == 0)
        {
            listaPar[aux] = lista[i];
            aux++;
        }
    }
}
void SepararVetorImpar()
{
    {
        int aux = 0;
        for (int i = 0; i < lista.Length; i++)
        {
            if (lista[i] % 2 != 0)
            {
                listaImpar[aux] = lista[i];
                aux++;
            }
        }
    }
}

void ExibirVetor(int[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.Write($"[{vetor[i]}] ");
    }
    Console.WriteLine();
}

GravaVetor();
ConverteVetorInvertido();
SepararVetorImpar();
SepararVetorPar();

Console.WriteLine("Números informados:");
ExibirVetor(lista);
Console.WriteLine("Números na ordem inversa:");
ExibirVetor(listainversa);
Console.WriteLine("Números pares:");
ExibirVetor(listaPar);
Console.WriteLine("Números ímpares:");
ExibirVetor(listaImpar);