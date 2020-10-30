namespace RegisztracioAlkalmazas
{
    partial class Form1
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_szulD = new System.Windows.Forms.Label();
            this.label_nem = new System.Windows.Forms.Label();
            this.label_UjHobbi = new System.Windows.Forms.Label();
            this.label_hobbi = new System.Windows.Forms.Label();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.radioButtonN = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSzulDatum = new System.Windows.Forms.TextBox();
            this.textBoxNewHobby = new System.Windows.Forms.TextBox();
            this.listBoxHobbik = new System.Windows.Forms.ListBox();
            this.buttonHozzaAd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBe = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(30, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Név:";
            // 
            // label_szulD
            // 
            this.label_szulD.AutoSize = true;
            this.label_szulD.Location = new System.Drawing.Point(12, 38);
            this.label_szulD.Name = "label_szulD";
            this.label_szulD.Size = new System.Drawing.Size(67, 13);
            this.label_szulD.TabIndex = 1;
            this.label_szulD.Text = "Szül. Dátum:";
            // 
            // label_nem
            // 
            this.label_nem.AutoSize = true;
            this.label_nem.Location = new System.Drawing.Point(12, 70);
            this.label_nem.Name = "label_nem";
            this.label_nem.Size = new System.Drawing.Size(32, 13);
            this.label_nem.TabIndex = 2;
            this.label_nem.Text = "Nem:";
            // 
            // label_UjHobbi
            // 
            this.label_UjHobbi.AutoSize = true;
            this.label_UjHobbi.Location = new System.Drawing.Point(12, 96);
            this.label_UjHobbi.Name = "label_UjHobbi";
            this.label_UjHobbi.Size = new System.Drawing.Size(49, 13);
            this.label_UjHobbi.TabIndex = 3;
            this.label_UjHobbi.Text = "Új hobbi:";
            // 
            // label_hobbi
            // 
            this.label_hobbi.AutoSize = true;
            this.label_hobbi.Location = new System.Drawing.Point(215, 12);
            this.label_hobbi.Name = "label_hobbi";
            this.label_hobbi.Size = new System.Drawing.Size(82, 13);
            this.label_hobbi.TabIndex = 4;
            this.label_hobbi.Text = "Kedvenc hobbi:";
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(82, 68);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(31, 17);
            this.radioButtonF.TabIndex = 5;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "F";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // radioButtonN
            // 
            this.radioButtonN.AutoSize = true;
            this.radioButtonN.Location = new System.Drawing.Point(152, 68);
            this.radioButtonN.Name = "radioButtonN";
            this.radioButtonN.Size = new System.Drawing.Size(33, 17);
            this.radioButtonN.TabIndex = 6;
            this.radioButtonN.TabStop = true;
            this.radioButtonN.Text = "N";
            this.radioButtonN.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(82, 9);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(103, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxSzulDatum
            // 
            this.textBoxSzulDatum.Location = new System.Drawing.Point(79, 35);
            this.textBoxSzulDatum.Name = "textBoxSzulDatum";
            this.textBoxSzulDatum.Size = new System.Drawing.Size(106, 20);
            this.textBoxSzulDatum.TabIndex = 2;
            this.textBoxSzulDatum.Visible = false;
            // 
            // textBoxNewHobby
            // 
            this.textBoxNewHobby.Location = new System.Drawing.Point(82, 93);
            this.textBoxNewHobby.Name = "textBoxNewHobby";
            this.textBoxNewHobby.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewHobby.TabIndex = 9;
            // 
            // listBoxHobbik
            // 
            this.listBoxHobbik.FormattingEnabled = true;
            this.listBoxHobbik.Items.AddRange(new object[] {
            "Uszás",
            "Horgászat",
            "Futás"});
            this.listBoxHobbik.Location = new System.Drawing.Point(303, 9);
            this.listBoxHobbik.Name = "listBoxHobbik";
            this.listBoxHobbik.Size = new System.Drawing.Size(150, 121);
            this.listBoxHobbik.TabIndex = 10;
            // 
            // buttonHozzaAd
            // 
            this.buttonHozzaAd.Location = new System.Drawing.Point(28, 162);
            this.buttonHozzaAd.Name = "buttonHozzaAd";
            this.buttonHozzaAd.Size = new System.Drawing.Size(104, 45);
            this.buttonHozzaAd.TabIndex = 11;
            this.buttonHozzaAd.Text = "Hozzáad";
            this.buttonHozzaAd.UseVisualStyleBackColor = true;
            this.buttonHozzaAd.Click += new System.EventHandler(this.buttonHozzaAd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(183, 162);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(104, 45);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Mentés";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBe
            // 
            this.buttonBe.Location = new System.Drawing.Point(349, 162);
            this.buttonBe.Name = "buttonBe";
            this.buttonBe.Size = new System.Drawing.Size(104, 45);
            this.buttonBe.TabIndex = 13;
            this.buttonBe.Text = "Betöltés";
            this.buttonBe.UseVisualStyleBackColor = true;
            this.buttonBe.Click += new System.EventHandler(this.buttonBe_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Szöveges fájlok (*.txt)|*.txt|CSV fájlok (*.csv)|*.csv|Minden fájl (*.*)|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 213);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonBe);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonHozzaAd);
            this.Controls.Add(this.listBoxHobbik);
            this.Controls.Add(this.textBoxNewHobby);
            this.Controls.Add(this.textBoxSzulDatum);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.radioButtonN);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.label_hobbi);
            this.Controls.Add(this.label_UjHobbi);
            this.Controls.Add(this.label_nem);
            this.Controls.Add(this.label_szulD);
            this.Controls.Add(this.label_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_szulD;
        private System.Windows.Forms.Label label_nem;
        private System.Windows.Forms.Label label_UjHobbi;
        private System.Windows.Forms.Label label_hobbi;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.RadioButton radioButtonN;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSzulDatum;
        private System.Windows.Forms.TextBox textBoxNewHobby;
        private System.Windows.Forms.ListBox listBoxHobbik;
        private System.Windows.Forms.Button buttonHozzaAd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBe;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

