// 1- Faça um programa que leia ATÉ 6 CHARacteres e grave em um vetor na ordem INSERIDA, imprima o vetor da PRIMEIRA até a ULTIMA posição e da ULTIMA até a PRIMEIRA posição.

char[] lista = new char[6];
int indexParada=0;


void GravaVetor()
{
    for (int i = 0; i < lista.Length; i++)
    {
        Console.Write($"Digite o {i + 1}º caractere ou pressione Enter para finalizar: ");

        string? entrada = Console.ReadLine();

        if (entrada == "")
        {
            indexParada = i;
            break;
        }

        if (entrada.Length != 1)
        {
            Console.WriteLine("Digite apenas um caractere.");
            i--;
            continue;
        }

        lista[i] = entrada[0];
        indexParada = i ;
    }
}

void ImprimeVetor()
{
    for (int i = 0; i < indexParada; i++)
    {
        Console.Write(lista[i]);
    }
}
void ImprimeVetorInvertido()
{
    for(int i = indexParada; i >= 0; i--)
    {
        Console.Write(lista[i]);
    }
}

void Executa()
{
    GravaVetor();
    ImprimeVetor();
    Console.WriteLine("");
    ImprimeVetorInvertido();
}

Executa();