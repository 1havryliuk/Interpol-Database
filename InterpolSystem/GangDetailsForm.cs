using System;
using System.Windows.Forms;

namespace InterpolSystem
{
    public partial class GangDetailsForm : Form
    {
        private Gang _gang;

        public GangDetailsForm(Gang gang)
        {
            InitializeComponent();

            _gang = gang;

            LoadGang();
        }

        private void LoadGang()
        {
            labelName.Text =
                "Назва: " + _gang.Name;

            labelCountry.Text =
                "Країна: " + _gang.Country;

            labelMembers.Text =
                "Учасників: " + _gang.MembersCount;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
