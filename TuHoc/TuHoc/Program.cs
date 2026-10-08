


class DongVat
{
    public int CanNang;
    public int ChieuCao;

    public void Info()
    {
        Console.WriteLine("Can Nang: {0}, Chieu Cao: {1}",CanNang, ChieuCao);
    }
}

class Program 
{
    static void Main(string[] args)
    {
        DongVat Cat = new DongVat();
        Cat.CanNang = 5;
        Cat.ChieuCao = 27;

        Cat.Info();








    }
}
