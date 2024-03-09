Console.WriteLine("Escreva sua altura em metros :");
float altura = float.Parse(Console.ReadLine());
Console.WriteLine("Escreva seu peso em Kg : ");
int peso = int.Parse(Console.ReadLine());

float IMC = peso / (altura * altura);

Console.WriteLine($"Seu IMC é de : {IMC} KG/m²");