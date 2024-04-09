using System;

// Clase para la operación de división
public class Division : Operacion
{
    public override double RealizarOperacion(double[] operandos)
    {
        if (operandos.Length != 2)
        {
            throw new ArgumentException("La operación de división solo acepta dos operandos.");
        }
        if (operandos[1] == 0)
        {
            throw new DivideByZeroException("No se puede dividir entre cero.");
        }
        return operandos[0] / operandos[1];
    }
}
