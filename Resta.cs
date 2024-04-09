// Clase para la operación de resta
public class Resta : Operacion
{
    public override double RealizarOperacion(double[] operandos)
    {
        double resultado = operandos[0];
        for (int i = 1; i < operandos.Length; i++)
        {
            resultado -= operandos[i];
        }
        return resultado;
    }
}
