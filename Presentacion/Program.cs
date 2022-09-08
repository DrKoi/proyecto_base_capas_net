// See https://aka.ms/new-console-template for more information
using Logica;
ContactoBLL cbll = new ContactoBLL();

Persona persona1 = new Persona("Juanito", "Perez", 123456789);
Persona persona2 = new Persona("María", "González", 987654321);
Persona persona3 = new Persona("Armando", "Casas", 789456789);

cbll.Agregar(persona1);
cbll.Agregar(persona2);
cbll.Agregar(persona3);



foreach (Persona p in cbll.Listar())
{
    Console.WriteLine(p);
}