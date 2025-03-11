using System;
class Prgram {
  
  // Função para converter de Celsius para Fahrenheit
  static double CelsiusToFahrenheit(double celsius)
  {
    return (celsius * 9 / 5) + 32;
  }
  
  // Função para converter de Celsius para Kelvin
  static double CelsiusToKelvin(double celsius)
  {
    return celsius + 273.15;
  }
  
  // Função principal do programa
  static void Main()
  {
    Console.WriteLine("Bem-vindo ao Conversor de Temperaturas!");

    // Entrada do usuário para a temperatura
    Console.Write("Digite a temperatura em Celsius: ");
    double celsius = Convert.ToDouble(Console.ReadLine());

    // Realiza as conversões
    double fahrenheit = CelsiusToFahrenheit(celsius);
    double kelvin = CelsiusToKelvin(celsius);

     // Exibe o resultado
    Console.WriteLine($"{celsis}°C equivale a {fahrenheit}°F e {kelvin}°K.");
  }    
}
