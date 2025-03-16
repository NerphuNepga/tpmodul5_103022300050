// See https://aka.ms/new-console-template for more information
using tpmodul5_103022300050;

public class Program
{
    public static void Main()
    {
        HaloGeneric<string> haloGeneric = new HaloGeneric<string>();
        Console.Write("Masukkan nama Anda: ");
        String user = Console.ReadLine();
        haloGeneric.SapaUser(user);
    }
}
