﻿using System.Linq;
using CSMSL.Analysis.ExperimentalDesign;
using CSMSL.Proteomics;
using System.Windows.Forms;

namespace NeuQuant
{
    public partial class QuantiativeLabelControl : UserControl
    {
        public QuantiativeLabelControl()
        {
            InitializeComponent();
        }

        public QuantiativeLabelControl(ExperimentalCondition condition)
            : this()
        {
            NameTextBox.Text = condition.Name;
            foreach (var mod in condition.Modifications)
            {
                listBox1.Items.Add(mod);
            }
        }

        public ExperimentalCondition GetCondition()
        {
            ExperimentalCondition condition = new ExperimentalCondition(NameTextBox.Text);
            foreach (Modification mod in listBox1.Items.Cast<Modification>())
            {
                condition.AddModification(mod);
            }
            return condition;
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {


            // Odd, but this answers it: http://stackoverflow.com/questions/2731425/c-sharp-drag-and-drop-e-data-getdata-using-a-base-class
            var mod = e.Data.GetData(typeof(ChemicalFormulaModification));
            if (mod == null)
                return;

            if(!listBox1.Items.Contains(mod))
                listBox1.Items.Add(mod);
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
                return;

            var mod = listBox1.SelectedItem;
            listBox1.Items.Remove(mod);
        }

      
    }
}
