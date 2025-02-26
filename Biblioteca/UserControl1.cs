using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            int cursorPosition = textBox1.SelectionStart;            
            textBox1.Text = new string(textBox1.Text.Where(char.IsDigit).ToArray());
            textBox1.SelectionStart = Math.Min(cursorPosition, textBox1.Text.Length);
        }
    }
}
