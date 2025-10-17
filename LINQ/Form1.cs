using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AllocConsole();
            //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/query-keywords
            int[] arr = { 3, 5, 8, 13, 21, 34, 55 };
            IEnumerable<int> FibonacciQuery =
                from i in arr
                where i > 20
                orderby i descending
                select i;
            foreach(int i in FibonacciQuery)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
            //////////////////////////////////////////////
            Console.WriteLine((from i in arr select i).Count());
            Console.WriteLine((from i in arr select i).Sum());
            //List<int> i_list = (from i in arr select i).To

        }
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();

    }
   
}
