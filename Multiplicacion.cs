// Clase para la operación de multiplicación
public class Multiplicacion : Operacion
{
    public override double RealizarOperacion(double[] operandos)
    {
        double resultado = 1;
        foreach (double operando in operandos)
        {
            resultado *= operando;
        }
        return resultado;
    }
}
