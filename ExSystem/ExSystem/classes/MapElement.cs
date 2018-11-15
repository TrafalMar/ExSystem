using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ExSystem.classes
{
    [Serializable]
    public class MapElement
    {
        //public TreeNode node { get; set; }
        //public TreeNode parent { get; set; }
        public string node { get; set; }
        public string parent { get; set; }
        public int position { get; set; }

        public MapElement() { }
        public MapElement(string node, int position,string parent) {
            this.node = node;
            this.position = position;
            this.parent = parent;
        }
    }
}