using System;

class HaloGeneric
{
    public void SapaUser<X>(X user)
    {
        Console.WriteLine("Halo user: " + user);
    }
}

class Utama
{
    static void Main(String[] args)
    {
        HaloGeneric input = new HaloGeneric();

        Console.WriteLine("Masukkan nama");
        String nama = Console.ReadLine();

        input.SapaUser<string>(nama);
    }
}