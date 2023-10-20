// Un postulante a un empleo, realiza un test de capacitación, se obtuvo la siguiente información:
// cantidad total de preguntas que se le realizaron y la cantidad de preguntas que contestó
// correctamente. Se pide confeccionar un programa que ingrese los dos datos por teclado e informe
// el nivel del mismo según el porcentaje de respuestas correctas que ha obtenido, y sabiendo que:

//Nivel máximo:	Porcentaje >= 90 %.

//Nivel medio:	Porcentaje >= 75 % y < 90 %.

//Nivel regular:	Porcentaje >= 50 % y < 75 %.
//Fuera de nivel:	Porcentaje < 50 %.


double preguntc = 0;
double preguntas = 0;

string linea = string.Empty;

Console.WriteLine(" Ingrese cantidad de preguntas ");
linea = Console.ReadLine();
preguntas = Convert.ToDouble(linea);

Console.WriteLine(" Ingrese cantidad de preguntas correctas ");
linea = Console.ReadLine();
preguntc = Convert.ToDouble(linea);

double porcentaje = preguntc / preguntas * 100;

Console.WriteLine(porcentaje);

if (porcentaje >= 90)
{
    Console.WriteLine(" El postulante alcanzo el nivel maximo");
}
else
{
    if (porcentaje >= 75 && porcentaje < 90)
        Console.WriteLine("El postulante alcazo el nivel medio ");
    else
    {
        if (porcentaje >= 50 && porcentaje < 75)
            Console.WriteLine(" El postulante alcanzo el nivel regular");
        else
        {
            Console.WriteLine(" El postulante esta fuera de nivel");
        }
    }
}
Console.ReadLine();
