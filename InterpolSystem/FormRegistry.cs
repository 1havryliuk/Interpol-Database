using System;
using System.Collections.Generic;
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

            dataGridView1.DataSource = criminals;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}