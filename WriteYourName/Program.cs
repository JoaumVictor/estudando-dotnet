//ENTRADA DE DADOS
Console.WriteLine("Boas vindas ao programa 'Calcula Lâmpada'!");
Console.WriteLine("Informe o nome do cômodo: ");
string convenient = Console.ReadLine();

while (string.IsNullOrEmpty(convenient))
{
    Console.WriteLine("Entrada inválida. Informe um nome pro cômodo:");
    convenient = Console.ReadLine();
}

Console.WriteLine("Informe em metros a largura deste cômodo: ");
decimal width;
while (!decimal.TryParse(Console.ReadLine(), out width))
{
    Console.WriteLine("Entrada inválida. Informe um número válido para a largura:");
}

Console.WriteLine("Informe em metros o comprimento deste cômodo: ");
decimal length;
while (!decimal.TryParse(Console.ReadLine(), out length))
{
    Console.WriteLine("Entrada inválida. Informe um número válido para o comprimento:");
}

Console.WriteLine("Informe a potência em watts da lâmpada que será utilizada: ");
int power;
while (!int.TryParse(Console.ReadLine(), out power))
{
    Console.WriteLine("Entrada inválida. Informe um número válido para a potência:");
}

//PROCESSAMENTO
decimal squareMeter = width * length;
decimal quotientX = power / 18M;
decimal totalLightBulbs = squareMeter / quotientX;

//SAÍDA DE DADOS
Console.WriteLine("Para iluminar o cômodo: " + convenient + " com " + squareMeter.ToString("N2") + " metros quadrados " + "será necessário a instalação de " + totalLightBulbs.ToString("N2") + " lâmpada(s)");
