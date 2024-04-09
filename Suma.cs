// Clase para la operación de suma
public class Suma : Operacion
{
    public override double RealizarOperacion(double[] operandos)
    {
        double resultado = 0;
        foreach (double operando in operandos)
        {
            resultado += operando;
        }
        return resultado;
    }
}