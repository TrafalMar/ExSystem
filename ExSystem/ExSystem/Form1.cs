using ExSystem.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormControll controller = new FormControll();
            controller.controllFormButtons(close,size,hide,this);
            controller.dragForm(navPanel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
