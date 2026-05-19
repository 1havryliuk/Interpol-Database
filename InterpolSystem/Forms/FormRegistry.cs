using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using InterpolSystem.Models;

namespace InterpolSystem
{
    public partial class FormRegistry : Form
    {
        private List<Criminal> criminals;

        private MainForm _owner;

        public FormRegistry(List<Criminal> list, MainForm owner)
        {
            InitializeComponent();

            criminals = list;

            _owner = owner;

            LoadTable();
        }

        private void LoadTable()
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource =
                criminals.Where(c => !c.IsArchived).ToList();

            // Ховаємо зайві поля
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

            // Назви колонок
            if (dataGridView1.Columns["FirstName"] != null)
                dataGridView1.Columns["FirstName"].HeaderText = "Ім'я";

            if (dataGridView1.Columns["LastName"] != null)
                dataGridView1.Columns["LastName"].HeaderText = "Прізвище";

            if (dataGridView1.Columns["Nickname"] != null)
                dataGridView1.Columns["Nickname"].HeaderText = "Кличка";

            if (dataGridView1.Columns["Gang"] != null)
                dataGridView1.Columns["Gang"].HeaderText = "Угруповання";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Criminal criminal =
                (Criminal)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            CriminalDetailsForm form =
                new CriminalDetailsForm(criminal, criminals);

            form.ShowDialog();

            LoadTable();
            _owner.SaveData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            this.Hide();

            ArchiveForm form = new ArchiveForm(criminals);

            form.ShowDialog();

            this.Show();
            
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CriminalDetailsForm form =
                new CriminalDetailsForm(criminals);

            form.ShowDialog();

            LoadTable();
            _owner.SaveData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();

            var filtered = criminals.Where(c =>

                !c.IsArchived &&

                (
                    c.FirstName.ToLower().Contains(search)
                    ||

                    c.LastName.ToLower().Contains(search)
                    ||

                    c.Nickname.ToLower().Contains(search)
                    ||

                   (
                    c.Gang != null &&
                    c.Gang.Name.ToLower().Contains(search)
                   )
                )

            ).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filtered;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            LoadTable();
        }
    }
}