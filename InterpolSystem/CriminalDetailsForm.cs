using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InterpolSystem
{
    public partial class CriminalDetailsForm : Form
    {
        private readonly Criminal _criminal;
        private readonly List<Criminal> _allCriminals;

        public CriminalDetailsForm(Criminal criminal, List<Criminal> allCriminals)
        {
            InitializeComponent();

            _criminal = criminal;

            _allCriminals = allCriminals;

            LoadCriminalData();
        }

        public CriminalDetailsForm(List<Criminal> allCriminals)
        {
            InitializeComponent();

            _criminal = new Criminal();

            _allCriminals = allCriminals;

            LoadCriminalData();
        }


        private void LoadCriminalData()
        {
            txtFirstName.Text = _criminal.FirstName;
            txtLastName.Text = _criminal.LastName;
            txtNickname.Text = _criminal.Nickname;
            txtHeight.Text = _criminal.Height.ToString();
            txtHair.Text = _criminal.HairColor;
            txtEyes.Text = _criminal.EyeColor;
            txtSpecialSigns.Text = _criminal.SpecialSigns;
            txtCitizenship.Text = _criminal.Citizenship;
            txtBirthPlace.Text = _criminal.BirthPlace;
            dtpBirthDate.Value = _criminal.BirthDate == DateTime.MinValue ? DateTime.Today : _criminal.BirthDate;
            txtLastResidence.Text = _criminal.LastResidence;
            txtLanguages.Text = _criminal.Languages;
            txtCrimeProfession.Text = _criminal.CrimeProfession;
            txtLastCase.Text = _criminal.LastCase;
            txtGang.Text = _criminal.Gang;

            chkArchived.Checked = _criminal.IsArchived;
            chkDead.Checked = _criminal.IsDead;
            btnDelete.Enabled = _criminal.IsDead;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_allCriminals.Contains(_criminal))
            {
                _allCriminals.Add(_criminal);
            }

            _criminal.FirstName = txtFirstName.Text.Trim();
            _criminal.LastName = txtLastName.Text.Trim();
            _criminal.Nickname = txtNickname.Text.Trim();
            _criminal.Height = int.TryParse(txtHeight.Text, out int h) ? h : 0;
            _criminal.HairColor = txtHair.Text.Trim();
            _criminal.EyeColor = txtEyes.Text.Trim();
            _criminal.SpecialSigns = txtSpecialSigns.Text.Trim();
            _criminal.Citizenship = txtCitizenship.Text.Trim();
            _criminal.BirthPlace = txtBirthPlace.Text.Trim();
            _criminal.BirthDate = dtpBirthDate.Value;
            _criminal.LastResidence = txtLastResidence.Text.Trim();
            _criminal.Languages = txtLanguages.Text.Trim();
            _criminal.CrimeProfession = txtCrimeProfession.Text.Trim();
            _criminal.LastCase = txtLastCase.Text.Trim();
            _criminal.Gang = txtGang.Text.Trim();

            _criminal.IsArchived = chkArchived.Checked;
            _criminal.IsDead = chkDead.Checked;

            MessageBox.Show(
                "Дані збережено!",
                "Успіх",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;

            Close();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            _criminal.IsArchived = true;
            MessageBox.Show("Злочинця архівовано!", "Архів");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnMarkDead_Click(object sender, EventArgs e)
        {
            _criminal.IsDead = true;
            chkDead.Checked = true;
            btnDelete.Enabled = true;
            MessageBox.Show("Позначено померлим", "Готово");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!_criminal.IsDead)
            {
                MessageBox.Show("Видалення можливе тільки після позначки 'Помер'!", "Помилка");
                return;
            }

            if (MessageBox.Show("Видалити злочинця назавжди?", "Підтвердження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _allCriminals.Remove(_criminal);
                MessageBox.Show("Злочинця видалено");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void txtLastResidence_TextChanged(object sender, EventArgs e)
        {

        }
    }
}