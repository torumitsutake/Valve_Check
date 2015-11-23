using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialChecker
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        public void changeBox(String str)
        {
            LogBox.AppendText(str);
        }


        public string getText()
        {
            return LogBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
