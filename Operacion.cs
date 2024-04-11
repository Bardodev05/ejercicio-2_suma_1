using System;

// Definición de la clase base Operacion
public class Operacion
{
    public virtual double RealizarOperacion(double operando1, double operando2)
    {
        return 0; // La clase base no realiza ninguna operación
    }
}