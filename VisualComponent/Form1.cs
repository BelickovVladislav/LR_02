using ComponentDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileSystem.FileSystem;

namespace VisualComponent
{
    public partial class Form1 : Form
    {
        static void Message(string str)
        {
            MessageBox.Show(str);
        }
        public Form1()
        {
            InitializeComponent();
            setup();
        }

        private void setup()
        {
            MyFileSystem myFileSystem = new MyFileSystem() ;
            myFileSystem.logCallHardCodeMethod = Message;
            myFileSystem.openFile("log.txt");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
