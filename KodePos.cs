using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300009
{
    class KodePos
    {
        public String kelurahan;
        public int kodepos;
        public List<KodePos> ListKodepost = new List<KodePos>();

        public KodePos(String a = "", int k = 0)
        {
            this.kelurahan = a;
            this.kodepos = k;
        }

        public void setKodePost()
        {
            this.ListKodepost.Add(new KodePos("Batununggal", 40266));
            this.ListKodepost.Add(new KodePos("Kujangsari", 40287));
            this.ListKodepost.Add(new KodePos("Mengger", 40267));
            this.ListKodepost.Add(new KodePos("Wates", 40256));
            this.ListKodepost.Add(new KodePos("Cijaura", 40287));
            this.ListKodepost.Add(new KodePos("Jatisari", 40286));
            this.ListKodepost.Add(new KodePos("Margasari", 40286));
            this.ListKodepost.Add(new KodePos("Sekejati", 40286));
            this.ListKodepost.Add(new KodePos("Kebonwaru", 40272));
            this.ListKodepost.Add(new KodePos("Maleer", 40274));
            this.ListKodepost.Add(new KodePos("Samoja", 40273));
        }

        public void getKodePos()
        {
            Console.WriteLine("kelurahan\tkode Pos");
            foreach (KodePos k in this.ListKodepost)
            {
                string kelPad = k.kelurahan.PadRight(15);
                Console.Write(kelPad + "\t" + k.kodepos);
                Console.WriteLine();
            }
        }
    }
}