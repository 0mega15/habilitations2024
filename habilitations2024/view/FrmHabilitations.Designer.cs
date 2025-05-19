namespace habilitations2024.view
{
    partial class FrmHabilitations
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.devGroup = new System.Windows.Forms.GroupBox();
            this.changPwdBtn = new System.Windows.Forms.Button();
            this.supprBtn = new System.Windows.Forms.Button();
            this.modifBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addDevBox = new System.Windows.Forms.GroupBox();
            this.profilLabel = new System.Windows.Forms.Label();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.telLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.profilListBox = new System.Windows.Forms.ListBox();
            this.saveButtonAdDev = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.modifPwdGroupBox = new System.Windows.Forms.GroupBox();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.confBtn = new System.Windows.Forms.Label();
            this.confTextBox = new System.Windows.Forms.TextBox();
            this.saveBtnChangPwd = new System.Windows.Forms.Button();
            this.cancelBtnChangPwd = new System.Windows.Forms.Button();
            this.devGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addDevBox.SuspendLayout();
            this.modifPwdGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // devGroup
            // 
            this.devGroup.Controls.Add(this.changPwdBtn);
            this.devGroup.Controls.Add(this.supprBtn);
            this.devGroup.Controls.Add(this.modifBtn);
            this.devGroup.Controls.Add(this.dataGridView1);
            this.devGroup.Location = new System.Drawing.Point(38, 44);
            this.devGroup.Name = "devGroup";
            this.devGroup.Size = new System.Drawing.Size(957, 289);
            this.devGroup.TabIndex = 0;
            this.devGroup.TabStop = false;
            this.devGroup.Text = "les développeurs";
            // 
            // changPwdBtn
            // 
            this.changPwdBtn.Location = new System.Drawing.Point(230, 239);
            this.changPwdBtn.Name = "changPwdBtn";
            this.changPwdBtn.Size = new System.Drawing.Size(105, 32);
            this.changPwdBtn.TabIndex = 3;
            this.changPwdBtn.Text = "changer pwd";
            this.changPwdBtn.UseVisualStyleBackColor = true;
            // 
            // supprBtn
            // 
            this.supprBtn.Location = new System.Drawing.Point(120, 239);
            this.supprBtn.Name = "supprBtn";
            this.supprBtn.Size = new System.Drawing.Size(104, 32);
            this.supprBtn.TabIndex = 2;
            this.supprBtn.Text = "supprimer";
            this.supprBtn.UseVisualStyleBackColor = true;
            // 
            // modifBtn
            // 
            this.modifBtn.Location = new System.Drawing.Point(8, 239);
            this.modifBtn.Name = "modifBtn";
            this.modifBtn.Size = new System.Drawing.Size(106, 32);
            this.modifBtn.TabIndex = 1;
            this.modifBtn.Text = "modifier";
            this.modifBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(926, 212);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addDevBox
            // 
            this.addDevBox.Controls.Add(this.cancelBtn);
            this.addDevBox.Controls.Add(this.saveButtonAdDev);
            this.addDevBox.Controls.Add(this.profilListBox);
            this.addDevBox.Controls.Add(this.profilLabel);
            this.addDevBox.Controls.Add(this.telTextBox);
            this.addDevBox.Controls.Add(this.mailTextBox);
            this.addDevBox.Controls.Add(this.telLabel);
            this.addDevBox.Controls.Add(this.mailLabel);
            this.addDevBox.Controls.Add(this.textBox1);
            this.addDevBox.Controls.Add(this.prenomLabel);
            this.addDevBox.Controls.Add(this.nomLabel);
            this.addDevBox.Controls.Add(this.nomTextBox);
            this.addDevBox.Location = new System.Drawing.Point(38, 345);
            this.addDevBox.Name = "addDevBox";
            this.addDevBox.Size = new System.Drawing.Size(956, 166);
            this.addDevBox.TabIndex = 1;
            this.addDevBox.TabStop = false;
            this.addDevBox.Text = "ajouter un développeur";
            // 
            // profilLabel
            // 
            this.profilLabel.AutoSize = true;
            this.profilLabel.Location = new System.Drawing.Point(398, 88);
            this.profilLabel.Name = "profilLabel";
            this.profilLabel.Size = new System.Drawing.Size(36, 16);
            this.profilLabel.TabIndex = 8;
            this.profilLabel.Text = "profil";
            this.profilLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(481, 55);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(201, 22);
            this.telTextBox.TabIndex = 7;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(481, 24);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(315, 22);
            this.mailTextBox.TabIndex = 6;
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Location = new System.Drawing.Point(398, 58);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(21, 16);
            this.telLabel.TabIndex = 5;
            this.telLabel.Text = "tel";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(398, 30);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(32, 16);
            this.mailLabel.TabIndex = 4;
            this.mailLabel.Text = "mail";
            this.mailLabel.Click += new System.EventHandler(this.mailLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 22);
            this.textBox1.TabIndex = 3;
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(6, 58);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(53, 16);
            this.prenomLabel.TabIndex = 2;
            this.prenomLabel.Text = "prenom";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(6, 30);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(33, 16);
            this.nomLabel.TabIndex = 1;
            this.nomLabel.Text = "nom";
            this.nomLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(66, 24);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(322, 22);
            this.nomTextBox.TabIndex = 0;
            // 
            // profilListBox
            // 
            this.profilListBox.FormattingEnabled = true;
            this.profilListBox.ItemHeight = 16;
            this.profilListBox.Location = new System.Drawing.Point(481, 88);
            this.profilListBox.Name = "profilListBox";
            this.profilListBox.Size = new System.Drawing.Size(201, 20);
            this.profilListBox.TabIndex = 9;
            // 
            // saveButtonAdDev
            // 
            this.saveButtonAdDev.Location = new System.Drawing.Point(8, 129);
            this.saveButtonAdDev.Name = "saveButtonAdDev";
            this.saveButtonAdDev.Size = new System.Drawing.Size(106, 30);
            this.saveButtonAdDev.TabIndex = 10;
            this.saveButtonAdDev.Text = "enregistrer";
            this.saveButtonAdDev.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(120, 129);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(104, 30);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "annuler";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // modifPwdGroupBox
            // 
            this.modifPwdGroupBox.Controls.Add(this.cancelBtnChangPwd);
            this.modifPwdGroupBox.Controls.Add(this.saveBtnChangPwd);
            this.modifPwdGroupBox.Controls.Add(this.confTextBox);
            this.modifPwdGroupBox.Controls.Add(this.confBtn);
            this.modifPwdGroupBox.Controls.Add(this.pwdTextBox);
            this.modifPwdGroupBox.Controls.Add(this.pwdLabel);
            this.modifPwdGroupBox.Location = new System.Drawing.Point(39, 535);
            this.modifPwdGroupBox.Name = "modifPwdGroupBox";
            this.modifPwdGroupBox.Size = new System.Drawing.Size(954, 105);
            this.modifPwdGroupBox.TabIndex = 2;
            this.modifPwdGroupBox.TabStop = false;
            this.modifPwdGroupBox.Text = "changer le mot de passe";
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Location = new System.Drawing.Point(5, 29);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(32, 16);
            this.pwdLabel.TabIndex = 0;
            this.pwdLabel.Text = "pwd";
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Location = new System.Drawing.Point(65, 29);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.Size = new System.Drawing.Size(322, 22);
            this.pwdTextBox.TabIndex = 1;
            // 
            // confBtn
            // 
            this.confBtn.AutoSize = true;
            this.confBtn.Location = new System.Drawing.Point(397, 29);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(79, 16);
            this.confBtn.TabIndex = 2;
            this.confBtn.Text = "confirmation";
            // 
            // confTextBox
            // 
            this.confTextBox.Location = new System.Drawing.Point(480, 29);
            this.confTextBox.Name = "confTextBox";
            this.confTextBox.Size = new System.Drawing.Size(322, 22);
            this.confTextBox.TabIndex = 3;
            // 
            // saveBtnChangPwd
            // 
            this.saveBtnChangPwd.Location = new System.Drawing.Point(8, 69);
            this.saveBtnChangPwd.Name = "saveBtnChangPwd";
            this.saveBtnChangPwd.Size = new System.Drawing.Size(106, 30);
            this.saveBtnChangPwd.TabIndex = 11;
            this.saveBtnChangPwd.Text = "enregistrer";
            this.saveBtnChangPwd.UseVisualStyleBackColor = true;
            // 
            // cancelBtnChangPwd
            // 
            this.cancelBtnChangPwd.Location = new System.Drawing.Point(120, 69);
            this.cancelBtnChangPwd.Name = "cancelBtnChangPwd";
            this.cancelBtnChangPwd.Size = new System.Drawing.Size(104, 30);
            this.cancelBtnChangPwd.TabIndex = 12;
            this.cancelBtnChangPwd.Text = "annuler";
            this.cancelBtnChangPwd.UseVisualStyleBackColor = true;
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 676);
            this.Controls.Add(this.modifPwdGroupBox);
            this.Controls.Add(this.addDevBox);
            this.Controls.Add(this.devGroup);
            this.Name = "FrmHabilitations";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmHabilitations_Load);
            this.devGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addDevBox.ResumeLayout(false);
            this.addDevBox.PerformLayout();
            this.modifPwdGroupBox.ResumeLayout(false);
            this.modifPwdGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox devGroup;
        private System.Windows.Forms.Button changPwdBtn;
        private System.Windows.Forms.Button supprBtn;
        private System.Windows.Forms.Button modifBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox addDevBox;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.Label profilLabel;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.ListBox profilListBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveButtonAdDev;
        private System.Windows.Forms.GroupBox modifPwdGroupBox;
        private System.Windows.Forms.TextBox confTextBox;
        private System.Windows.Forms.Label confBtn;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.Button cancelBtnChangPwd;
        private System.Windows.Forms.Button saveBtnChangPwd;
    }
}

