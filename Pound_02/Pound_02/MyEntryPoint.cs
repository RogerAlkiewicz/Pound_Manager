using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pound_02
{
    class MyEntryPoint
    {
        [STAThread]
        static void Main()
        {
            App application = new App();
            application.InitializeComponent();
            application.Run();
        }
    }
}
