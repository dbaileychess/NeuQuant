﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CSMSL;
using CSMSL.Analysis.ExperimentalDesign;
using CSMSL.Proteomics;
using WeifenLuo.WinFormsUI.Docking;
using CSMSL.Chemistry;

namespace NeuQuant
{
    public partial class QuantiativeLabelManagerForm : DockContent
    {
        public QuantiativeLabelManagerForm()
        {
            InitializeComponent();
            
            siteListBox.Items.AddRange(Enum.GetNames(typeof(ModificationSites)));
            siteListBox.Items.RemoveAt(0);
            siteListBox.Items.Remove(ModificationSites.All);

            modListBox.DataSource = NeuQuantForm.CurrentModifications;
            experimentsListBox.DataSource = NeuQuantForm.CurrentExperiments;
        }
     
        void removeButton_Click2(object sender, EventArgs e)
        {
            var b = sender as Button;
            if (b == null)
                return;

            b.Parent.Parent.Parent.Controls.Remove(b.Parent.Parent);
        }

        private void AddNewQuantitativeLabel(Control panel, QuantiativeLabelControl control)
        {
            if (control == null)
                return;
            control.removeButton.Click += removeButton_Click2;
            panel.Controls.Add(control);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var newControl = new QuantiativeLabelControl();
            newControl.NameTextBox.Text = "Channel " + flowLayoutPanel2.Controls.Count;
            AddNewQuantitativeLabel(flowLayoutPanel2, newControl);
        }

        private void createChannelButton_Click(object sender, EventArgs e)
        {
            string modName = modNameBox.Text;
            string formula = formulaBox.Text;
            var masterSites = ModificationSites.None;
            foreach (var item in siteListBox.CheckedItems)
            {
                var site = (ModificationSites)Enum.Parse(typeof(ModificationSites), item.ToString());
                masterSites |= site;
            }

            CreateNewMod(modName, formula, masterSites);
        }

        private void CreateNewMod(string modName, string formula, ModificationSites sites)
        {
            //logic to handle adding a channel included here
            if (string.IsNullOrEmpty(modName))
            {
                MessageBox.Show("Specify a Valid Modification Name");
                return;
            }

        
            var newMod = new ChemicalFormulaModification(formula, modName, sites);

            Reagents.AddModification(newMod);
        }

        private void SaveExperiment(string name)
        {
            ExperimentalSet experiment = new ExperimentalSet(name);
            foreach (var control in flowLayoutPanel2.Controls.Cast<QuantiativeLabelControl>())
            {
                experiment.Add(control.GetCondition());
            }
            Reagents.AddExperiment(experiment);
        }

        private void modListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMods();
        }

        private void UpdateMods()
        {
            var mod = modListBox.SelectedValue as ChemicalFormulaModification;

            if (mod == null)
                return;
          
            formulaBox.Text = mod.ChemicalFormula.ToString(" ");
                
            for (int i = 0; i < siteListBox.Items.Count; i++)
            {
                siteListBox.SetItemChecked(i, false);
            }
            foreach (var modSite in mod.Sites.GetActiveSites())
            {
                for (int i = 0; i < siteListBox.Items.Count; i++)
                {
                    var currentSite =
                        (ModificationSites) Enum.Parse(typeof (ModificationSites), siteListBox.Items[i].ToString());
                    if (currentSite == modSite)
                    {
                        siteListBox.SetItemChecked(i, true);
                    }
                }
            }
            modNameBox.Text = mod.Name;
        }

        private void isotopologueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateExperiments();
        }

        private void UpdateExperiments()
        {
            ExperimentalSet experiment = experimentsListBox.SelectedValue as ExperimentalSet;

            if (experiment == null)
                return;
           
            flowLayoutPanel2.Controls.Clear();
           
            foreach (var condition in experiment)
            {
                var newControl = new QuantiativeLabelControl(condition);
                newControl.removeButton.Click += removeButton_Click2;
                flowLayoutPanel2.Controls.Add(newControl);
            }
        }

        private void modListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
                return;

            var mod = modListBox.SelectedValue as Modification;

            if (mod == null)
                return;
             

            var isotopoglues = new List<ExperimentalSet>();

            foreach (ExperimentalSet experiment in Reagents.GetAllExperiments())
            {
                if (experiment.Contains(mod))
                {
                    isotopoglues.Add(experiment);
                }
            }

            if (isotopoglues.Count > 0)
            {
                string dependingIso = string.Join(",", isotopoglues.Select(iso => iso.Name));
                DialogResult result = MessageBox.Show("The following experiments depend on this mod:\n(" + dependingIso
                                                        + ")\nDeleting will also remove these experiments!", "Delete the " + mod.Name + " Modification?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    foreach(var iso in isotopoglues)
                    {
                        Reagents.RemoveExperiment(iso.Name);
                    }
                }
                else
                {
                    return;
                }
            }

            // Nothing depends on it, so remove it
            Reagents.RemoveModification(mod.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveExperiment(textBox1.Text);
        }

        private void modListBox_MouseDown(object sender, MouseEventArgs e)
        {
            var listbox = sender as ListBox;
            if (listbox == null || listbox.Items.Count == 0)
                return;

            int index = listbox.IndexFromPoint(e.X, e.Y);
            if (index < 0 || index > listbox.Items.Count - 1)
                return;

            var item = listbox.Items[index];
            if(item != null)
                DoDragDrop(item, DragDropEffects.All);
        }

        private void formulaBox_TextChanged(object sender, EventArgs e)
        {
            string formula = formulaBox.Text;
            if (ChemicalFormula.IsValidChemicalFormula(formula))
            {
                label1.ForeColor = Color.Black;
                textBox2.Text = new ChemicalFormula(formula).MonoisotopicMass.ToString("F5");
                createChannelButton.Enabled = true;
            }
            else
            {
                label1.ForeColor = Color.Red;
                textBox2.Text = "n/a";
                createChannelButton.Enabled = false;
            }
        }
    }
}
