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
        }

        List<RadioButton> labels = new List<RadioButton>();
        TreeNodeCollection node;
        private void Form1_Load(object sender, EventArgs e)
        {
            labels.AddRange(new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5 });
            node = treeView1.Nodes;

            foreach (RadioButton label in labels)
            {
                label.Text = "";
            }
            labels[0].Select();
            treeView1.CheckBoxes = true;
            int i = 0;
            foreach (TreeNode o in node)
            {
                labels[i].Text = o.Text;
                labels[i].Visible = true;
                i++;
            }
            foreach (RadioButton label in labels)
            {
                if (label.Text == "")
                {
                    label.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton selectedRadio;
            foreach (RadioButton radio in labels)
            {
                if (radio.Checked)
                {
                    selectedRadio = radio;
                    foreach (TreeNode o in node)
                    {
                        if (o.Text.Equals(selectedRadio.Text))
                        {
                            o.Checked = true;
                            o.Expand();
                            int i = 0;
                            TreeNode[] nodes = node.Find(o.Text,true);
                            foreach (TreeNode nd in nodes)
                            {
                                labels[i].Text = nd.Text;
                                labels[i].Visible = true;
                                i++;
                            }
                        }
                    }
                }
            }


        }
    }
}
