

namespace EjercicioHerencia
{
    public class Calculadora : Operaciones
    {

       public double Radio {  get; set; }
       public double Lado {  get; set; }
        
       public void imprimir()
        {
            Console.WriteLine($"El area de un circulo es: {AreaCirculo(Radio)}cm2");
            Console.WriteLine($"El volumen de un cubo es: {VolumenCubo(Lado)}cm3");
            Console.WriteLine($"La Longitud de un circulo es: {CirculoLongitud(Radio)}cms");
        }      

    }
}
