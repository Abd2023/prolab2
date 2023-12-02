using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prolab2_projeee
{
    internal class Program
    {
        static void Main()
        {
            System.Windows.Forms.Application.Run(new Rezervasiyon_Sistemi());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Rezervasiyon_Sistemi());
        }


    }
}
