// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");

public class Categorias
{
    public int id;
    public string? nombre;
}
public class Musicos
{
    public int id;
    public string? nombre;
    public decimal reproducciones;
    public bool grammy;
    public DateTime fechaSalida;
    public Categorias? categoria;

}