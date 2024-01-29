// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;

class PaintingDemo
{
    static void Main(string[] args)
    {
        // Instantiate an array of eight Room objects
        Room[] rooms = new Room[8];

        // Create rooms with different dimensions
        rooms[0] = new Room(12, 10, 9);
        rooms[1] = new Room(15, 12, 8);
        rooms[2] = new Room(10, 8, 8);
        rooms[3] = new Room(20, 10, 9);
        rooms[4] = new Room(14, 12, 9);
        rooms[5] = new Room(18, 10, 8);
        rooms[6] = new Room(12, 12, 9);
        rooms[7] = new Room(16, 14, 8);

        // Demonstrate the Room methods
        for (int i = 0; i < rooms.Length; i++)
        {
            Console.WriteLine("Room {0}:", i + 1);
            Console.WriteLine("Length: " + rooms[i].Length);
            Console.WriteLine("Width: " + rooms[i].Width);
            Console.WriteLine("Height: " + rooms[i].Height);
            Console.WriteLine("Wall Area: " + rooms[i].WallArea);
            Console.WriteLine("Gallons of Paint Needed: " + rooms[i].GallonsOfPaintNeeded);
            Console.WriteLine();
        }
    }
}

class Room
{
    private double length;
    private double width;
    private double height;

    public Room(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public double Length
    {
        get { return length; }
    }

    public double Width
    {
        get { return width; }
    }

    public double Height
    {
        get { return height; }
    }

    public double WallArea
    {
        get { return CalculateWallArea(); }
    }

    public double GallonsOfPaintNeeded
    {
        get { return CalculateGallonsOfPaintNeeded(); }
    }

    private double CalculateWallArea()
    {
        double wallArea = 2 * (length * height + width * height);
        return wallArea;
    }

    private double CalculateGallonsOfPaintNeeded()
    {
        double gallonsNeeded = WallArea / 350;
        gallonsNeeded = Math.Ceiling(gallonsNeeded);
        return gallonsNeeded;
    }
}
