// Ejercicio 1 - If
//Escribe un programa que:
//Pida datos a un cliente: Nombre, email, cupón.
//Determine si un cliente tiene un cupon descuento.
//Muestre un precio rebajado en función del descuento.
//Muestre el precio de un producto sin descuento si no hay cupón.

Console.WriteLine("Ejercicio 1: ");
void Discount(string name, string email, bool cupon) { 
    if (cupon == true)
    {
        Console.WriteLine($"Nombre: {name}, Email: {email}, Precio: $15");
    } else
    {
        Console.WriteLine($"Nombre: {name}, Email: {email}, Precio: $30");
    }
}

Discount("Leo Messi","messi10@email.com",true);
Discount("Neymar Jr","ney@email.com",false);

//Ejercicio 2 - Switch
//Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++.
//Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c.
//Presenta el resultado en consola.
//Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.

Console.WriteLine("Ejercicio 2: ");

List<string> languages = new List<string>() { "JS", "C#", "Java", "Python" };

Console.WriteLine("Lenguajes de Programacion: ");
foreach (var item in languages)
{
    Console.WriteLine(item);
}

Console.WriteLine("Escoge un lenguaje ingresando su posición en la lista: ");
int posicion = Convert.ToInt32(Console.ReadLine());

switch (posicion)
{
    case 1: 
        Console.WriteLine("Has elegido el lenguaje JavaScript!");
        break;
    case 2:
        Console.WriteLine("Hola Mundo!");
        break;
    case 3:
        Console.WriteLine("Has elegido el lenguaje Java!");
        break;
    case 4:
        Console.WriteLine("Has elegido el lenguaje Python!");
        break;

    default: Console.WriteLine("La opción elegida no se encuentra en la lista.");
        break;
}