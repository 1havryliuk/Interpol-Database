namespace InterpolSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxFirstName = new TextBox();
            textBoxHeight = new TextBox();
            textBoxLastName = new TextBox();
            textBoxNickname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonAdd = new Button();
            buttonOpenRegistry = new Button();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(415, 178);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(169, 27);
            textBoxFirstName.TabIndex = 0;
            textBoxFirstName.TextChanged += textBox1_TextChanged;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(415, 277);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(169, 27);
            textBoxHeight.TabIndex = 1;
            textBoxHeight.TextChanged += textBoxHeight_TextChanged;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(415, 211);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(169, 27);
            textBoxLastName.TabIndex = 2;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // textBoxNickname
            // 
            textBoxNickname.Location = new Point(415, 244);
            textBoxNickname.Name = "textBoxNickname";
            textBoxNickname.Size = new Size(169, 27);
            textBoxNickname.TabIndex = 3;
            textBoxNickname.TextChanged += textBoxNickname_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 178);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 4;
            label1.Text = "Ім'я:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 214);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 5;
            label2.Text = "Прізвище:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 244);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 6;
            label3.Text = "Кличка:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 277);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Зріст:";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(348, 327);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(103, 29);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click_1;
            // 
            // buttonOpenRegistry
            // 
            buttonOpenRegistry.Location = new Point(478, 327);
            buttonOpenRegistry.Name = "buttonOpenRegistry";
            buttonOpenRegistry.Size = new Size(106, 29);
            buttonOpenRegistry.TabIndex = 9;
            buttonOpenRegistry.Text = "Реєстр";
            buttonOpenRegistry.UseVisualStyleBackColor = true;
            buttonOpenRegistry.Click += buttonOpenRegistry_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 642);
            Controls.Add(buttonOpenRegistry);
            Controls.Add(buttonAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNickname);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxFirstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstName;
        private TextBox textBoxHeight;
        private TextBox textBoxLastName;
        private TextBox textBoxNickname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonAdd;
        private Button buttonOpenRegistry;
    }
}
