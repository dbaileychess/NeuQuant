﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using ZedGraph;

namespace NeuQuant
{
    public partial class GraphForm : DockContent, IDockContent
    {
        public GraphForm()
        {
            InitializeComponent();
            LinkedGraphForms = new List<GraphForm>();
            GraphControls = new HashSet<ZedGraphControl>() {GraphControl};
        }

        public HashSet<ZedGraphControl> GraphControls;

        public List<GraphForm> LinkedGraphForms;

        public void LinkForms(GraphForm form)
        {
            GraphControls.Add(form.GraphControl);
            form.GraphControls.Add(this.GraphControl);
            LinkedGraphForms.Add(form);
            form.LinkedGraphForms.Add(this);
        }
    }
}