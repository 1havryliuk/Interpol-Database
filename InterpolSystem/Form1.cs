using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InterpolSystem
{
    public partial class Form1 : Form
    {
        List<Criminal> criminals = new List<Criminal>();
        public Form1()
        {
            InitializeComponent();

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int height;

            if (!int.TryParse(textBoxHeight.Text, out height))
            {
                MessageBox.Show("Введіть правильний зріст!");
                return;
            }

            Criminal c = new Criminal
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Nickname = textBoxNickname.Text,
                Height = height
            };

            criminals.Add(c);

            MessageBox.Show("Злочинця додано!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNickname_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            Criminal c = new Criminal
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Nickname = textBoxNickname.Text,
                Height = int.Parse(textBoxHeight.Text)
            };

            criminals.Add(c);

            MessageBox.Show("Додано!");

        }


        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpenRegistry_Click(object sender, EventArgs e)
        {
            FormRegistry form = new FormRegistry(criminals);
            form.Show();
        }
    }

}