// See https://aka.ms/new-console-template for more information
Console.WriteLine("Holaaaaaaaa, como tas!");



static string SegundosAHora(int totalSegundos)
{
    int horas = totalSegundos / 3600;
    int minutos = (totalSegundos % 3600) / 60;
    int segundos = totalSegundos % 60;

    return $"{horas:D2}:{minutos:D2}:{segundos:D2}";
}

int segundos = 3661;
segundos = segundos;
string tiempoFormateado = SegundosAHora(segundos);
Console.WriteLine($"Tiempo formateado: {tiempoFormateado}");

Console.Write("Ingrese los segundos: ");
int segundos = int.Parse(Console.ReadLine());

string tiempoFormateado = SegundosAHora(segundos);
Console.WriteLine($"Tiempo formateado: {tiempoFormateado}");