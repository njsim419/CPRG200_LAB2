using CustomerData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG200_Lab1_nick_sim
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Form1.CustomerInformation = FileManager.DeserializeObject<Dictionary<int, Customer>>(Form1.path);
            }
            catch (FileNotFoundException)
            {
                Form1.CustomerInformation = new Dictionary<int, Customer>();
            }
          
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(FormClosing);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }

        static void FormClosing(object sender, EventArgs e)
        {
            FileManager.SerializeObject(Form1.CustomerInformation, Form1.path);
        }
    }
}
