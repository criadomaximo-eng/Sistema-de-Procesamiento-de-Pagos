using System;

public abstract class Pago
{
    private string titular;
    private double monto;

    public Pago(string titular, double monto)
    {
        this.titular = titular;
        this.monto = monto;
    }

    public string Titular
    {
        get { return titular; }
        set { titular = value; }
    }

    public double Monto
    {
        get { return monto; }
        set { monto = value; }
    }

    public abstract double CalcularComision();

    public virtual void ProcesarPago()
    {
        double comision = CalcularComision();
        double montoFinal = monto + comision;

        Console.WriteLine("Titular: " + titular);
        Console.WriteLine("Monto original: $" + monto);
        Console.WriteLine("Procesando pago...");
        Console.WriteLine("Comisión aplicada: $" + comision);
        Console.WriteLine("Monto final: $" + montoFinal);
        Console.WriteLine("Pago realizado correctamente.");
        Console.WriteLine("===========================");
    }
}