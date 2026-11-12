// 3- Faça um programa que leia um numero inteiro usando esse numero crie um vetor com essa quantidade de posições,
// dentro deste vetor deve conter os itens da sequencia fibonacci até a posição informada.
int inputdoUsuario;

void Fibonacci(int numero, int[] vetor)
{
    int primeiro = 0, segundo = 1, proximo;

    for (int i = 0; i < numero; i++)
    {
        if (i <= 1)
            proximo = i;
        else
        {
            proximo = primeiro + segundo;
            primeiro = segundo;
            segundo = proximo;


        }
        vetor[i] = proximo;
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


Console.WriteLine("Digite o numero do fibonacci: ");
inputdoUsuario = int.Parse(Console.ReadLine());

int[] vetor = new int[inputdoUsuario];
Fibonacci(inputdoUsuario, vetor);
ExibirVetor(vetor);




