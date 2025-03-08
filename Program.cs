
using tpmodul4_103022300009;

namespace TPMOD4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contoh pertama :");
            KodePos kodepos = new KodePos();
            kodepos.setKodePost();
            kodepos.getKodePos();

            Console.WriteLine("\nContoh kedua :");
            KodePos01 kodepos1 = new KodePos01();
            kodepos1.getKodePos();

            Console.WriteLine("\nSoal ketiga :");
            DoorMachine.Run();
        }
    }
}
