using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DemoLog
{
    static class Program
    {
        /// <summary>
        /// ���ε{�����D�J�f�I�C
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogShow());
        }
    }
}
