﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DataBaseTools;

namespace DataBaseToolsCheck
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Connector connector = new Connector();
            dataGridView.DataSource = connector.Select("*", "Students");
        }
        [DllImport("kernal32.dll")]
        public static extern bool AllocConsole();
        //[DllImport("kernal32.dll")]
        //public static extern bool FreeConsole();
    }
}
