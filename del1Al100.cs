//Variable para asignar la cantidad de veces que se repetira el bucle.
int cantidadNumero = 100;
//Variable para saber cuantas veces se ha realizado el bucle.
int contador = 0;
//Variable a la cual mostrara el resultado final.
string salida = "";

for (int i = 0; i < cantidadNumero; i++)
{
    contador++;
    if (contador % 3 == 0)
        salida += "cyber";
    else if (contador % 5 == 0)
        salida += "click";
    else if (contador % 5 == 0 && contador % 3 == 0)
        salida += "cyberclick";
    else
        salida += contador;
}
Console.WriteLine(salida);