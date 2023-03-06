using System;

class Vector
{
    private double x;
    private double y;
    private double z;

    public Vector()
    {
        x = 0.0;
        y = 0.0;
        z = 0.0;
    }

    public Vector(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    public double Z
    {
        get { return z; }
        set { z = value; }
    }

    public override string ToString()
    {
        return x.ToString() + " " + y.ToString() + " " + z.ToString();
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
        double x = v1.X + v2.X;
        double y = v1.Y + v2.Y;
        double z = v1.Z + v2.Z;

        return new Vector(x, y, z);
    }

    public static Vector operator +(Vector v, double scalar)
    {
        double x = v.X + scalar;
        double y = v.Y + scalar;
        double z = v.Z + scalar;

        return new Vector(x, y, z);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector(1.0, 2.0, 3.0);
        Vector v2 = new Vector(4.0, 5.0, 6.0);

        Console.WriteLine("v1 = " + v1.ToString());
        Console.WriteLine("v2 = " + v2.ToString());

        Vector v3 = v1 + v2;
        Console.WriteLine("v3 = v1 + v2 = " + v3.ToString());

        Vector v4 = v1 + 2.0;
        Console.WriteLine("v4 = v1 + 2.0 = " + v4.ToString());

        Console.ReadKey();
    }
}
