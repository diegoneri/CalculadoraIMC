double peso, altura, imc;
string situacao = "";
ConsoleColor corResultado = ConsoleColor.White;

Console.WriteLine("-- Calculadora de IMC --");

Console.Write("\nDigite seu peso em kg...: ");
bool pesoEhValido = Double.TryParse(Console.ReadLine(), out peso);
if (!pesoEhValido || peso < 0 || peso > 600)
{
    Console.WriteLine("Peso inválido");
    return;
}

Console.Write("Digite sua altura em m..: ");
altura = Convert.ToDouble(Console.ReadLine());
if (altura < 0 || altura > 2.5)
{
    Console.WriteLine("Altura inválida");
}

imc = peso / Math.Pow(altura, 2);

/*
-inf     17   18,49          +inf
|--------|------|------------|
*/

if (imc < 17)
{
    situacao = "Muito abaixo do peso";
    corResultado = ConsoleColor.DarkYellow;
}
else if (imc >= 17 && imc <= 18.49)
{
    situacao = "Abaixo do peso";
    corResultado = ConsoleColor.DarkYellow;
}
else if (imc >= 18.5 && imc <= 24.99)
{
    situacao = "Peso normal";
    corResultado = ConsoleColor.DarkGreen;
}
else if (imc >= 25 && imc <= 29.99)
{
    situacao = "Acima do peso";
    corResultado = ConsoleColor.DarkYellow;
}
else if (imc >= 30 && imc <= 34.99)
{
    situacao = "Obesidade I";
    corResultado = ConsoleColor.DarkRed;
}
else if (imc >= 35 && imc <= 39.99)
{
    situacao = "Obesidade II (severa)";
    corResultado = ConsoleColor.DarkRed;
}
else if (imc > 40)
{
    situacao = "Obesidade III (mórbida)";
    corResultado = ConsoleColor.DarkRed;
}

Console.WriteLine($"Seu IMC é {imc:N2} kg/m².");

Console.ForegroundColor = corResultado;
Console.WriteLine($"Diagnóstico: {situacao}");

Console.ResetColor();