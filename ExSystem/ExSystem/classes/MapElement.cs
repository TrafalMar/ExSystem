﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExSystem.classes
{
    public class MapElement
    {
        public TreeNode node { get; set; }
        public TreeNode parent { get; set; }
        public int position { get; set; }

        public MapElement(TreeNode node, int position,TreeNode parent) {
            this.node = node;
            this.position = position;
            this.parent = parent;
        }
    }
}