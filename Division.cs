using System;

// Clase para la operación de división
public class Division : Operacion
{
    public override double RealizarOperacion(double operando1, double operando2)
    {
        if (operando2 == 0)
        {
            throw new DivideByZeroException("No se puede dividir entre cero.");
        }
        return operando1 / operando2;
    }
}