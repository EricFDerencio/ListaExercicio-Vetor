// 4- Faça um programa que cria um vetor de 10 posições,Cada posição tem uma letra,
// copie para um novo vetor cada uma das posições adicionando na proxima o valor da tabela ascii de cada character

const int TAMANHO = 10;
char[] letras = new char[TAMANHO];
string[] ascii = new string[TAMANHO*2];


char[] PopularVetor(char[] vetor)
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Digite a {i + 1}ª letra: ");
        vetor[i] = char.Parse(Console.ReadLine()); 
    }
    return vetor;
}

int ConverterAscii(char letra)
{
    return (int)letra;
}

string[] CriarVetorAscii(char[] vetor)
{
    string[] vetorAscii = new string[vetor.Length*2];
    for(int i = 0;i < vetor.Length; i++)
    {
        vetorAscii[2 * i] = vetor[i].ToString();
        vetorAscii[2 * i + 1] = ConverterAscii(vetor[i]).ToString();
    }
    return vetorAscii;
}

void ExibirVetor(string[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.Write($"[{vetor[i]}] ");
    }
    Console.WriteLine();
}

letras = PopularVetor(letras);
ascii = CriarVetorAscii(letras);
ExibirVetor(ascii);