using System;

namespace SegundosFábrica
{
    class Program
    {
        public static string calculaHora(int segundos)
        {
            double hora= segundos / 3600;
            double minutos = (segundos%3600)/60;
            double segundosHora = (segundos%3600) %60;
            string horaFinal = $"Tempo total: {hora.ToString("F2")} horas : {minutos.ToString("F2")} minútos : {segundosHora.ToString("F2")} segundos.";
            return (horaFinal);
        }
        static void Main(string[] args)
        {
            int segundos;
            Console.WriteLine("Transformador de segundos para hora, minútos e segundos.");
            Console.WriteLine("digite a quantidade de segundos.");
            segundos = int.Parse(Console.ReadLine());
            string converte = calculaHora(segundos);
            Console.WriteLine(converte);
        }
    }
}
