using ExSystem.classes;
using MetroFramework.Controls;
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
        List<MetroRadioButton> _radioButtonGroup = new List<MetroRadioButton>();
        TreeView tree;
        TreeView editorTree;
        List<MapElement> list;
        private void Form1_Load(object sender, EventArgs e)
        {
            labels.AddRange(new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6 });
            _radioButtonGroup.AddRange(new MetroRadioButton[] { root_radio, child_radio });
            tree = treeView1;
            editorTree = treeView2;
            list = treeToList(editorTree);

            foreach (MapElement nd in list)
            {
                if (nd.parent == null)
                {
                    tree.Nodes.Add(nd.node.Text);
                }
                else
                {
                    foreach (TreeNode node in Collect(tree.Nodes))
                    {
                        if (node.Text == nd.parent.Text)
                        {
                            node.Nodes.Add(nd.node.Text);
                        }
                    }
                }
            }

            foreach (RadioButton label in labels)
            {
                label.Text = "";
            }

            labels[0].Select();
            treeView1.CheckBoxes = true;
            int i = 0;
            clear();
            foreach (TreeNode o in tree.Nodes)
            {
                labels[i].Text = o.Text;
                labels[i].Visible = true;
                i++;
            }

            //css

        }


        TreeNodeCollection currentNodes;
        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton selectedRadio;
            if (currentNodes == null)
            {
                currentNodes = tree.Nodes;
            }
            foreach (RadioButton radio in labels)
            {
                if (radio.Checked)
                {
                    selectedRadio = radio;
                    foreach (TreeNode o in currentNodes)
                    {
                        if (o.Text.Equals(selectedRadio.Text) && selectedRadio.Enabled == true)
                        {
                            o.Checked = true;
                            o.Expand();
                            labels[0].Select();
                            int i = 0;
                            currentNodes = o.Nodes;
                            clear();
                            int listCount = 0;
                            foreach (TreeNode nd in currentNodes)
                            {
                                labels[i].Text = nd.Text;
                                labels[i].Visible = true;
                                if (nd.Nodes.Count == 0)
                                {
                                    labels[i].Enabled = false;
                                    labels[i].Visible = false;
                                    listCount++;
                                    labels[i].Text = listCount + ". " + labels[i].Text;
                                    tabControl1.SelectedTab.Controls.Add(changeToLabel(labels[i]));
                                }
                                i++;
                            }
                        }
                    }
                }
            }


        }

        public void clear()
        {
            foreach (RadioButton label in labels)
            {
                label.Visible = false;
                label.Enabled = true;
            }
            foreach (Label lab in this.Controls.Find("Answer", true))
            {
                lab.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentNodes = null;
            clear();
            int i = 0;
            foreach (TreeNode o in tree.Nodes)
            {
                labels[i].Text = o.Text;
                labels[i].Visible = true;
                o.Collapse();
                i++;
            }
            foreach (var unchecker in Collect(tree.Nodes))
            {
                unchecker.Checked = false;
                // you will see every child node here
            }
        }

        IEnumerable<TreeNode> Collect(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                yield return node;

                foreach (var child in Collect(node.Nodes))
                    yield return child;
            }
        }

        public Label changeToLabel(RadioButton radio)
        {
            Label label = new Label();
            label.Name = "Answer";
            label.Left = radio.Left;
            label.Text = radio.Text;
            label.Top = radio.Top;
            label.Font = new Font("Arial", 10);
            label.AutoSize = true;
            label.Visible = true;

            return label;
        }

        IEnumerable<MapElement> treeToMap(TreeNodeCollection nodes)
        {
            int position = 0;

            foreach (TreeNode node in nodes)
            {
                MapElement map = new MapElement(node, position, node.Parent);
                yield return map;
                foreach (var child in treeToMap(node.Nodes))
                {
                    int curPosition = child.position + 1;
                    map = new MapElement(child.node, curPosition, child.node.Parent);
                    yield return map;
                }
            }
        }

        public List<MapElement> treeToList(TreeView treeView)
        {
            List<MapElement> list = new List<MapElement>();
            foreach (MapElement lister in treeToMap(treeView.Nodes))
            {
                list.Add(lister);
            }

            return list;
        }

        //supervisor
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                foreach (RadioButton other in _radioButtonGroup)
                {
                    if (other == rb)
                    {
                        continue;
                    }
                    other.Checked = false;
                }
            }
        }

      

        private void onBorderPaint(object sender, MetroFramework.Drawing.MetroPaintEventArgs e)
        {
            MetroPanel panel = sender as MetroPanel;
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.LightBlue, ButtonBorderStyle.Solid);
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tree = sender as TreeView;
            metroTextBox2.Text = tree.SelectedNode.Text;
            l1.Text = "Кількість синів: " + tree.SelectedNode.Nodes.Count;
            l2.Text = "Значення: " + (tree.SelectedNode.Nodes.Count != 0 ? "Гілка" : "Рішення");
            l3.Text = "Розгорнута: " + (tree.SelectedNode.IsExpanded ? "Так" : "Ні");
        }

        private void treeView2_AfterExpand(object sender, TreeViewEventArgs e)
        {
            TreeView tree = sender as TreeView;
            if (tree.SelectedNode != null)
            l3.Text = "Розгорнута: " + (tree.SelectedNode.IsExpanded ? "Так" : "Ні");
        }

        private void treeView2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!e.Node.IsExpanded)
            {
                e.Node.Expand();
            }
            else
            {
                e.Node.Collapse();
            }
        }
    }

}
