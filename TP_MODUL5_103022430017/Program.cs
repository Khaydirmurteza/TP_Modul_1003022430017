using System;

class HaloGeneric
{
    public void SapaUser<X>(X user)
    {
        Console.WriteLine("Halo user: " + user);
    }
}

class DataGeneric<T>
{
    public T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void printData()
    {
        Console.WriteLine("Data yang tersimpan: " + data);
    }
}

class Utama
{
    static void Main(String[] args)
    {
        HaloGeneric input = new HaloGeneric();

        Console.WriteLine("Masukkan nama");
        Console.WriteLine("Masukkan NIM: ");
        String nama = Console.ReadLine();
        String nim = Console.ReadLine();
        input.SapaUser<string>(nama);

        DataGeneric<String> data = new DataGeneric<String>(nim);

        data.printData();
    }
}