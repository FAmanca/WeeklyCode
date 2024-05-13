abstract class Bentuk
{
  public abstract double hitungLuas();
}

class Persegi : Bentuk
{
  private double sisi;

  public Persegi(double sisi)
  {
    this.sisi = sisi;
  }

  public override double hitungLuas()
  {
    return sisi * sisi;
  }
}

class Lingkaran : Bentuk
{
  private double radius;

  public Lingkaran(double radius)
  {
    this.radius = radius;
  }

  public override double hitungLuas()
  {
    return 3.14 * radius * radius;
  }
}

class Program
{
  static void Main(string[] args)
  {
    Bentuk bentuk1 = new Persegi(5);
    Console.WriteLine($"Luas Persegi: {bentuk1.hitungLuas()}");

    Bentuk bentuk2 = new Lingkaran(3);
    Console.WriteLine($"Luas Lingkaran: {bentuk2.hitungLuas()}");
  }
}
