

using System.Transactions;

namespace EjercicioHerencia
{
    public class Operaciones
    {
        //Calculo del area de un circulo
        public double AreaCirculo( double radio) {
            return Math.PI*Math.Pow(radio, 2);
        }
        //Calculo del volumen de un cubo
        public double VolumenCubo(double l1) {

            return Math.Pow(l1, 3);
        }
        //Calculo de la Long de Circulo
        public double CirculoLongitud(double radio) {
            return 2*Math.PI*radio;
        }
    }
}
