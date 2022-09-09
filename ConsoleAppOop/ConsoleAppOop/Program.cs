// See https://aka.ms/new-console-template for more information
interface IColor
{
    void GetColor();
}
public class Car
{
    public Car()
    { }

    public int speed = 2;
    public string color = "black";
    //public int height = 4;
    public int GetSpeed()
    {
        return speed;
    }

    public virtual string Height()
    {
        return "Height in Car";
    }
}
public class Bike : Car, IColor
{

    public int ElectricBike(int a)
    {
        Console.WriteLine("int" + a);
        return a;
    }
    public string ElectricBike(string a)
    {
        Console.WriteLine("string" + a);
        return a;
    }

    public override string Height()
    {
        return "height in Bike";
    }

    public void GetColor()
    {
        Console.WriteLine("this color");
    }

}


public class Program
{
    public static void Main()
    {
        Car car = new Car();
        Bike bike = new Bike();
        //Console.WriteLine(car.GetSpeed());
        //Console.WriteLine(bike.GetSpeed());

        //string a = "22";
        //bike.ElectricBike(a);

        // Console.WriteLine(bike.Height());

        bike.GetColor();

    }
}
