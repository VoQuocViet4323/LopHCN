internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Nhập chiều rộng: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine($"Nhập chiều dài: ");
        double height = double.Parse(Console.ReadLine());
        HCN hcn = new HCN(width, height);
        Console.WriteLine(hcn.Display());
        Console.WriteLine($"Chu vi hình chữ nhật: {hcn.getPerimeter()}");
        Console.WriteLine($"Diện tích hình chữ nhật: {hcn.getArea()}");
        
    }
}