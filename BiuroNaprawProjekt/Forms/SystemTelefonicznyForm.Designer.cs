
namespace BiuroNaprawProjekt.Forms
{
    partial class SystemTelefonicznyForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stacyjna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Koncentrator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Liniowa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JW = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ograniczenia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trasa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Komentarz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EditButton = new System.Windows.Forms.Button();
            this.SearchGroupbox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OgraniczeniaNumeric = new System.Windows.Forms.NumericUpDown();
            this.UwagiTextbox = new System.Windows.Forms.TextBox();
            this.TrasaTextbox = new System.Windows.Forms.TextBox();
            this.AdresTextbox = new System.Windows.Forms.TextBox();
            this.NazwaTextBox = new System.Windows.Forms.TextBox();
            this.LokacjaCombobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Liniowa2Numeric = new System.Windows.Forms.NumericUpDown();
            this.Liniowa1Numeric = new System.Windows.Forms.NumericUpDown();
            this.KoncentratorNumeric = new System.Windows.Forms.NumericUpDown();
            this.Stacyjna2Numeric = new System.Windows.Forms.NumericUpDown();
            this.Stacyjna3Numeric = new System.Windows.Forms.NumericUpDown();
            this.Stacyjna1Numeric = new System.Windows.Forms.NumericUpDown();
            this.NumerNumeric = new System.Windows.Forms.NumericUpDown();
            this.SearchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OgraniczeniaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liniowa2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liniowa1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KoncentratorNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stacyjna2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stacyjna3Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stacyjna1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumerNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(75)))), ((int)(((byte)(189)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F);
            this.AddButton.Location = new System.Drawing.Point(18, 215);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 49);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Dodaj numer";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(89)))), ((int)(((byte)(179)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Stacyjna,
            this.Koncentrator,
            this.Liniowa,
            this.JW,
            this.Nazwa,
            this.Adres,
            this.Ograniczenia,
            this.Trasa,
            this.Komentarz});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F);
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView1.Location = new System.Drawing.Point(0, 283);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(1073, 483);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // Number
            // 
            this.Number.Text = "Numer";
            // 
            // Stacyjna
            // 
            this.Stacyjna.Text = "Stacyjna";
            this.Stacyjna.Width = 81;
            // 
            // Koncentrator
            // 
            this.Koncentrator.Text = "Koncentrator";
            this.Koncentrator.Width = 109;
            // 
            // Liniowa
            // 
            this.Liniowa.Text = "Liniowa";
            // 
            // JW
            // 
            this.JW.Text = "Przydział Służbowy";
            this.JW.Width = 133;
            // 
            // Nazwa
            // 
            this.Nazwa.Text = "Nazwa";
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            // 
            // Ograniczenia
            // 
            this.Ograniczenia.Text = "Ograniczenia";
            this.Ograniczenia.Width = 107;
            // 
            // Trasa
            // 
            this.Trasa.Text = "Trasa";
            // 
            // Komentarz
            // 
            this.Komentarz.Text = "Komentarz";
            this.Komentarz.Width = 258;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(75)))), ((int)(((byte)(189)))));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditButton.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F);
            this.EditButton.Location = new System.Drawing.Point(163, 215);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(121, 49);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edytuj Numer";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SearchGroupbox
            // 
            this.SearchGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchGroupbox.Controls.Add(this.label10);
            this.SearchGroupbox.Controls.Add(this.label11);
            this.SearchGroupbox.Controls.Add(this.label12);
            this.SearchGroupbox.Controls.Add(this.label13);
            this.SearchGroupbox.Controls.Add(this.label9);
            this.SearchGroupbox.Controls.Add(this.OgraniczeniaNumeric);
            this.SearchGroupbox.Controls.Add(this.UwagiTextbox);
            this.SearchGroupbox.Controls.Add(this.TrasaTextbox);
            this.SearchGroupbox.Controls.Add(this.AdresTextbox);
            this.SearchGroupbox.Controls.Add(this.NazwaTextBox);
            this.SearchGroupbox.Controls.Add(this.LokacjaCombobox);
            this.SearchGroupbox.Controls.Add(this.label8);
            this.SearchGroupbox.Controls.Add(this.label7);
            this.SearchGroupbox.Controls.Add(this.label6);
            this.SearchGroupbox.Controls.Add(this.label5);
            this.SearchGroupbox.Controls.Add(this.label4);
            this.SearchGroupbox.Controls.Add(this.label3);
            this.SearchGroupbox.Controls.Add(this.label2);
            this.SearchGroupbox.Controls.Add(this.label1);
            this.SearchGroupbox.Controls.Add(this.Liniowa2Numeric);
            this.SearchGroupbox.Controls.Add(this.Liniowa1Numeric);
            this.SearchGroupbox.Controls.Add(this.KoncentratorNumeric);
            this.SearchGroupbox.Controls.Add(this.Stacyjna2Numeric);
            this.SearchGroupbox.Controls.Add(this.Stacyjna3Numeric);
            this.SearchGroupbox.Controls.Add(this.Stacyjna1Numeric);
            this.SearchGroupbox.Controls.Add(this.NumerNumeric);
            this.SearchGroupbox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F);
            this.SearchGroupbox.Location = new System.Drawing.Point(16, 12);
            this.SearchGroupbox.Name = "SearchGroupbox";
            this.SearchGroupbox.Size = new System.Drawing.Size(1034, 196);
            this.SearchGroupbox.TabIndex = 3;
            this.SearchGroupbox.TabStop = false;
            this.SearchGroupbox.Text = "Wyszukiwanie";
            this.SearchGroupbox.Enter += new System.EventHandler(this.SearchGroupbox_Enter);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(852, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 21);
            this.label10.TabIndex = 25;
            this.label10.Text = "Przydział służbowy";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(676, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 21);
            this.label11.TabIndex = 24;
            this.label11.Text = "Linowa";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "Stacyjna";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 21);
            this.label13.TabIndex = 22;
            this.label13.Text = "Numer";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ograniczenia";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // OgraniczeniaNumeric
            // 
            this.OgraniczeniaNumeric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OgraniczeniaNumeric.Location = new System.Drawing.Point(489, 151);
            this.OgraniczeniaNumeric.Name = "OgraniczeniaNumeric";
            this.OgraniczeniaNumeric.Size = new System.Drawing.Size(56, 28);
            this.OgraniczeniaNumeric.TabIndex = 20;
            this.OgraniczeniaNumeric.ValueChanged += new System.EventHandler(this.numericUpDown8_ValueChanged);
            // 
            // UwagiTextbox
            // 
            this.UwagiTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UwagiTextbox.Location = new System.Drawing.Point(814, 151);
            this.UwagiTextbox.Name = "UwagiTextbox";
            this.UwagiTextbox.Size = new System.Drawing.Size(214, 28);
            this.UwagiTextbox.TabIndex = 19;
            this.UwagiTextbox.TextChanged += new System.EventHandler(this.UwagiTextbox_TextChanged);
            // 
            // TrasaTextbox
            // 
            this.TrasaTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TrasaTextbox.Location = new System.Drawing.Point(632, 151);
            this.TrasaTextbox.Name = "TrasaTextbox";
            this.TrasaTextbox.Size = new System.Drawing.Size(141, 28);
            this.TrasaTextbox.TabIndex = 18;
            this.TrasaTextbox.TextChanged += new System.EventHandler(this.TrasaTextbox_TextChanged);
            // 
            // AdresTextbox
            // 
            this.AdresTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AdresTextbox.Location = new System.Drawing.Point(232, 151);
            this.AdresTextbox.Name = "AdresTextbox";
            this.AdresTextbox.Size = new System.Drawing.Size(188, 28);
            this.AdresTextbox.TabIndex = 17;
            this.AdresTextbox.TextChanged += new System.EventHandler(this.AdresTextbox_TextChanged);
            // 
            // NazwaTextBox
            // 
            this.NazwaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NazwaTextBox.Location = new System.Drawing.Point(6, 151);
            this.NazwaTextBox.Name = "NazwaTextBox";
            this.NazwaTextBox.Size = new System.Drawing.Size(157, 28);
            this.NazwaTextBox.TabIndex = 16;
            this.NazwaTextBox.TextChanged += new System.EventHandler(this.NazwaTextBox_TextChanged);
            // 
            // LokacjaCombobox
            // 
            this.LokacjaCombobox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LokacjaCombobox.FormattingEnabled = true;
            this.LokacjaCombobox.Location = new System.Drawing.Point(814, 68);
            this.LokacjaCombobox.Name = "LokacjaCombobox";
            this.LokacjaCombobox.Size = new System.Drawing.Size(214, 29);
            this.LokacjaCombobox.TabIndex = 15;
            this.LokacjaCombobox.SelectedIndexChanged += new System.EventHandler(this.LokacjaCombobox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(897, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Uwagi";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Koncentrator";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Trasa";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(694, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "-";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "-";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adres";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nazwa";
            // 
            // Liniowa2Numeric
            // 
            this.Liniowa2Numeric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Liniowa2Numeric.Location = new System.Drawing.Point(717, 66);
            this.Liniowa2Numeric.Name = "Liniowa2Numeric";
            this.Liniowa2Numeric.Size = new System.Drawing.Size(56, 28);
            this.Liniowa2Numeric.TabIndex = 6;
            this.Liniowa2Numeric.ValueChanged += new System.EventHandler(this.Liniowa2Numeric_ValueChanged);
            // 
            // Liniowa1Numeric
            // 
            this.Liniowa1Numeric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Liniowa1Numeric.Location = new System.Drawing.Point(632, 66);
            this.Liniowa1Numeric.Name = "Liniowa1Numeric";
            this.Liniowa1Numeric.Size = new System.Drawing.Size(56, 28);
            this.Liniowa1Numeric.TabIndex = 5;
            this.Liniowa1Numeric.ValueChanged += new System.EventHandler(this.Liniowa1Numeric_ValueChanged);
            // 
            // KoncentratorNumeric
            // 
            this.KoncentratorNumeric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KoncentratorNumeric.Location = new System.Drawing.Point(489, 66);
            this.KoncentratorNumeric.Name = "KoncentratorNumeric";
            this.KoncentratorNumeric.Size = new System.Drawing.Size(56, 28);
            this.KoncentratorNumeric.TabIndex = 4;
            this.KoncentratorNumeric.ValueChanged += new System.EventHandler(this.KoncentratorNumeric_ValueChanged);
            // 
            // Stacyjna2Numeric
            // 
            this.Stacyjna2Numeric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Stacyjna2Numeric.Location = new System.Drawing.Point(287, 66);
            this.Stacyjna2Numeric.Name = "Stacyjna2Numeric";
            this.Stacyjna2Numeric.Size = new System.Drawing.Size(56, 28);
            this.Stacyjna2Numeric.TabIndex = 3;
            this.Stacyjna2Numeric.ValueChanged += new System.EventHandler(this.Stacyjna2Numeric_ValueChanged);
            // 
            // Stacyjna3Numeric
            // 
            this.Stacyjna3Numeric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Stacyjna3Numeric.Location = new System.Drawing.Point(376, 66);
            this.Stacyjna3Numeric.Name = "Stacyjna3Numeric";
            this.Stacyjna3Numeric.Size = new System.Drawing.Size(56, 28);
            this.Stacyjna3Numeric.TabIndex = 2;
            this.Stacyjna3Numeric.ValueChanged += new System.EventHandler(this.Stacyjna3Numeric_ValueChanged);
            // 
            // Stacyjna1Numeric
            // 
            this.Stacyjna1Numeric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Stacyjna1Numeric.Location = new System.Drawing.Point(200, 66);
            this.Stacyjna1Numeric.Name = "Stacyjna1Numeric";
            this.Stacyjna1Numeric.Size = new System.Drawing.Size(56, 28);
            this.Stacyjna1Numeric.TabIndex = 1;
            this.Stacyjna1Numeric.ValueChanged += new System.EventHandler(this.Stacyjna1Numeric_ValueChanged);
            // 
            // NumerNumeric
            // 
            this.NumerNumeric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumerNumeric.Location = new System.Drawing.Point(28, 66);
            this.NumerNumeric.Maximum = new decimal(new int[] {
            322000,
            0,
            0,
            0});
            this.NumerNumeric.Name = "NumerNumeric";
            this.NumerNumeric.Size = new System.Drawing.Size(116, 28);
            this.NumerNumeric.TabIndex = 0;
            this.NumerNumeric.ValueChanged += new System.EventHandler(this.NumerNumeric_ValueChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(75)))), ((int)(((byte)(189)))));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F);
            this.SearchButton.Location = new System.Drawing.Point(905, 215);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(145, 49);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Wyszukaj Numer";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(75)))), ((int)(((byte)(189)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F);
            this.button1.Location = new System.Drawing.Point(648, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Wyczyść Wyszukiwanie";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SystemTelefonicznyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1073, 766);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchGroupbox);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SystemTelefonicznyForm";
            this.Activated += new System.EventHandler(this.SystemTelefonicznyForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SystemTelefonicznyForm_FormClosed);
            this.Load += new System.EventHandler(this.SystemTelefonicznyForm_Load);
            this.Shown += new System.EventHandler(this.SystemTelefonicznyForm_Shown);
            this.Enter += new System.EventHandler(this.SystemTelefonicznyForm_Activated);
            this.SearchGroupbox.ResumeLayout(false);
            this.SearchGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OgraniczeniaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liniowa2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liniowa1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KoncentratorNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stacyjna2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stacyjna3Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stacyjna1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumerNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Stacyjna;
        private System.Windows.Forms.ColumnHeader Koncentrator;
        private System.Windows.Forms.ColumnHeader Liniowa;
        private System.Windows.Forms.ColumnHeader JW;
        private System.Windows.Forms.ColumnHeader Nazwa;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.ColumnHeader Ograniczenia;
        private System.Windows.Forms.ColumnHeader Trasa;
        private System.Windows.Forms.ColumnHeader Komentarz;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.GroupBox SearchGroupbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Liniowa2Numeric;
        private System.Windows.Forms.NumericUpDown Liniowa1Numeric;
        private System.Windows.Forms.NumericUpDown KoncentratorNumeric;
        private System.Windows.Forms.NumericUpDown Stacyjna2Numeric;
        private System.Windows.Forms.NumericUpDown Stacyjna3Numeric;
        private System.Windows.Forms.NumericUpDown Stacyjna1Numeric;
        private System.Windows.Forms.NumericUpDown NumerNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown OgraniczeniaNumeric;
        private System.Windows.Forms.TextBox UwagiTextbox;
        private System.Windows.Forms.TextBox TrasaTextbox;
        private System.Windows.Forms.TextBox AdresTextbox;
        private System.Windows.Forms.TextBox NazwaTextBox;
        private System.Windows.Forms.ComboBox LokacjaCombobox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button button1;
    }
}