using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InterpolSystem
{
    public partial class ArchiveForm : Form
    {
        private List<Criminal> criminals;

        public ArchiveForm(List<Criminal> list)
        {
            InitializeComponent();

            criminals = list;

            LoadArchive();
        }

        private void LoadArchive()
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource =
                criminals.Where(c => c.IsArchived).ToList();

            string[] hiddenColumns =
            {
                "Height",
                "HairColor",
                "EyeColor",
                "SpecialSigns",
                "Citizenship",
                "BirthPlace",
                "BirthDate",
                "LastResidence",
                "Languages",
                "CrimeProfession",
                "LastCase",
                "IsArchived",
                "IsDead"
            };

            foreach (string col in hiddenColumns)
            {
                var column = dataGridView1.Columns[col];

                if (column != null)
                {
                    column.Visible = false;
                }
            }

            if (dataGridView1.Columns["FirstName"] != null)
                dataGridView1.Columns["FirstName"].HeaderText = "Ім'я";

            if (dataGridView1.Columns["LastName"] != null)
                dataGridView1.Columns["LastName"].HeaderText = "Прізвище";

            if (dataGridView1.Columns["Nickname"] != null)
                dataGridView1.Columns["Nickname"].HeaderText = "Кличка";

            if (dataGridView1.Columns["Gang"] != null)
                dataGridView1.Columns["Gang"].HeaderText = "Угруповання";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ArchiveForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Criminal criminal =
                (Criminal)dataGridView1
                .Rows[e.RowIndex]
                .DataBoundItem;

            criminal.IsArchived = false;

            MessageBox.Show(
                "Злочинця розархівовано!");

            LoadArchive();
        }
    }
}