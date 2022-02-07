
namespace BiuroNaprawProjekt.Forms
{
    partial class JednostkiForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.jwID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jwName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddLokacjaButton = new System.Windows.Forms.Button();
            this.UpdateLokalizacjaButton = new System.Windows.Forms.Button();
            this.DeleteLokalizacjaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.jwID,
            this.jwName});
            this.listView1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F);
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 21);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(396, 733);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // jwID
            // 
            this.jwID.Text = "ID";
            this.jwID.Width = 62;
            // 
            // jwName
            // 
            this.jwName.Text = "Nazwa";
            this.jwName.Width = 316;
            // 
            // AddLokacjaButton
            // 
            this.AddLokacjaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLokacjaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(75)))), ((int)(((byte)(189)))));
            this.AddLokacjaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddLokacjaButton.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F);
            this.AddLokacjaButton.Location = new System.Drawing.Point(609, 67);
            this.AddLokacjaButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddLokacjaButton.Name = "AddLokacjaButton";
            this.AddLokacjaButton.Size = new System.Drawing.Size(273, 49);
            this.AddLokacjaButton.TabIndex = 4;
            this.AddLokacjaButton.Text = "Dodaj Lokalizajce";
            this.AddLokacjaButton.UseVisualStyleBackColor = false;
            this.AddLokacjaButton.Click += new System.EventHandler(this.AddLokacjaButton_Click);
            // 
            // UpdateLokalizacjaButton
            // 
            this.UpdateLokalizacjaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateLokalizacjaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(75)))), ((int)(((byte)(189)))));
            this.UpdateLokalizacjaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateLokalizacjaButton.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F);
            this.UpdateLokalizacjaButton.Location = new System.Drawing.Point(609, 124);
            this.UpdateLokalizacjaButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateLokalizacjaButton.Name = "UpdateLokalizacjaButton";
            this.UpdateLokalizacjaButton.Size = new System.Drawing.Size(273, 49);
            this.UpdateLokalizacjaButton.TabIndex = 5;
            this.UpdateLokalizacjaButton.Text = "Uaktualnij Lokalizacje";
            this.UpdateLokalizacjaButton.UseVisualStyleBackColor = false;
            this.UpdateLokalizacjaButton.Click += new System.EventHandler(this.UpdateLokalizacjaButton_Click);
            // 
            // DeleteLokalizacjaButton
            // 
            this.DeleteLokalizacjaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteLokalizacjaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(75)))), ((int)(((byte)(189)))));
            this.DeleteLokalizacjaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteLokalizacjaButton.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F);
            this.DeleteLokalizacjaButton.Location = new System.Drawing.Point(609, 181);
            this.DeleteLokalizacjaButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteLokalizacjaButton.Name = "DeleteLokalizacjaButton";
            this.DeleteLokalizacjaButton.Size = new System.Drawing.Size(273, 49);
            this.DeleteLokalizacjaButton.TabIndex = 6;
            this.DeleteLokalizacjaButton.Text = "Usuń Lokalizacje";
            this.DeleteLokalizacjaButton.UseVisualStyleBackColor = false;
            this.DeleteLokalizacjaButton.Click += new System.EventHandler(this.DeleteLokalizacjaButton_Click);
            // 
            // JednostkiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1073, 766);
            this.Controls.Add(this.DeleteLokalizacjaButton);
            this.Controls.Add(this.UpdateLokalizacjaButton);
            this.Controls.Add(this.AddLokacjaButton);
            this.Controls.Add(this.listView1);
            this.Name = "JednostkiForm";
            this.Text = "JednostkiForm";
            this.Load += new System.EventHandler(this.JednostkiForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader jwID;
        private System.Windows.Forms.ColumnHeader jwName;
        private System.Windows.Forms.Button AddLokacjaButton;
        private System.Windows.Forms.Button UpdateLokalizacjaButton;
        private System.Windows.Forms.Button DeleteLokalizacjaButton;
    }
}