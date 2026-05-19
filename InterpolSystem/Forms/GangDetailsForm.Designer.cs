namespace InterpolSystem
{
    partial class GangDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            labelCountry = new Label();
            labelMembers = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(54, 39);
            labelName.Name = "labelName";
            labelName.Size = new Size(54, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Назва:";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(54, 73);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(59, 20);
            labelCountry.TabIndex = 1;
            labelCountry.Text = "Країна:";
            // 
            // labelMembers
            // 
            labelMembers.AutoSize = true;
            labelMembers.Location = new Point(54, 109);
            labelMembers.Name = "labelMembers";
            labelMembers.Size = new Size(81, 20);
            labelMembers.TabIndex = 2;
            labelMembers.Text = "Учасників:";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(336, 186);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "Закрити";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // GangDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClose);
            Controls.Add(labelMembers);
            Controls.Add(labelCountry);
            Controls.Add(labelName);
            Name = "GangDetailsForm";
            Text = "GangDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelCountry;
        private Label labelMembers;
        private Button buttonClose;
    }
}