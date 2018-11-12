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
        TreeView node;
        private void Form1_Load(object sender, EventArgs e)
        {
            labels.AddRange(new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6 });
            node = treeView1;

            foreach (RadioButton label in labels)
            {
                label.Text = "";
            }
            labels[0].Select();
            treeView1.CheckBoxes = true;
            int i = 0;
            clear();
            foreach (TreeNode o in node.Nodes)
            {
                labels[i].Text = o.Text;
                labels[i].Visible = true;
                i++;
            }
            
        }

        TreeNodeCollection currentNodes;
        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton selectedRadio;
            if (currentNodes == null) {
                currentNodes = node.Nodes;
            }
            foreach (RadioButton radio in labels)
            {
                if (radio.Checked)
                {
                    selectedRadio = radio;
                    foreach (TreeNode o in currentNodes)
                    {
                        if (o.Text.Equals(selectedRadio.Text))
                        {
                            o.Checked = true;
                            o.Expand();
                            int i = 0;
                            currentNodes = o.Nodes;
                            clear();
                            foreach (TreeNode nd in currentNodes)
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

        public void clear() {
            foreach (RadioButton label in labels)
            {
                label.Visible = false;
            }
        }
    }
}
