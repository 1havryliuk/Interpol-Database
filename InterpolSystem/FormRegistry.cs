using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InterpolSystem
{
    public partial class FormRegistry : Form
    {
        List<Criminal> criminals;

        public FormRegistry(List<Criminal> list)
        {
            InitializeComponent();

            criminals = list;

            dataGridView1.DataSource =
                criminals.Where(c => !c.IsArchived).ToList();
            dataGridView1.Columns["Height"]!.Visible = false;
            dataGridView1.Columns["HairColor"]!.Visible = false;
            dataGridView1.Columns["EyeColor"]!.Visible = false;
            dataGridView1.Columns["SpecialSigns"]!.Visible = false;
            dataGridView1.Columns["Citizenship"]!.Visible = false;
            dataGridView1.Columns["BirthPlace"]!.Visible = false;
            dataGridView1.Columns["BirthDate"]!.Visible = false;
            dataGridView1.Columns["LastResidence"]!.Visible = false;
            dataGridView1.Columns["Languages"]!.Visible = false;
            dataGridView1.Columns["CrimeProfession"]!.Visible = false;
            dataGridView1.Columns["LastCase"]!.Visible = false;
            dataGridView1.Columns["IsArchived"]!.Visible = false;
            dataGridView1.Columns["IsDead"]!.Visible = false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}