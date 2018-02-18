using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTING_Form
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         MessageBox.Show("أهلا وسهلا ... مرحبا");
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void button1_ControlAdded(object sender, ControlEventArgs e)
      {

      }

      private void button1_MouseMove(object sender, MouseEventArgs e)
      {

      }
   }
}
