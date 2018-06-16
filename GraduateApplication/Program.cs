using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;

namespace GraduateApplication
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Cartable cartable = new Cartable();
            Thread t = new Thread(new ThreadStart(cartable.daily_run));
            t.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
