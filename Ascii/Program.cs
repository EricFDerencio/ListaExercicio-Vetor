// 4- Faça um programa que cria um vetor de String de 10 posições,
// Cada posição tem uma letra,
// copie para um novo vetor cada uma das posições adicionando na proxima o valor da tabela ascii de cada character

char[] letras = new char[10];
string[] ascii = new string[20];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite a {i + 1}ª letra: ");
    letras[i] = char.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    ascii[2 * i] = letras[i].ToString();
    ascii[2 * i + 1] = ((int)letras[i]).ToString();

    Console.WriteLine($"| [{ascii[2 * i]}] [{ascii[2 * i + 1]}] |");
}