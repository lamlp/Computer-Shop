using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_j
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
            //Application.Run(new KhachHang());
            //Application.Run(new SanPham());
            //Application.Run(new TimeBaseDisplay());
            //Application.Run(new TimeRule());
            //Application.Run(new Recommendation());
            //Application.Run(new Category());
            //Application.Run(new DonHang());
        }
    }
}
