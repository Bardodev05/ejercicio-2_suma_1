using System;

// Definición de la clase base Operacion
public class Operacion
{
    public virtual double RealizarOperacion(double[] operandos)
    {
        return 0; // La clase base no realiza ninguna operación
    }
}