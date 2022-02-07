
namespace BiuroNaprawProjekt
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.SidemenuPanel = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.Button();
            this.JwButton = new System.Windows.Forms.Button();
            this.SystemTelButton = new System.Windows.Forms.Button();
            this.EmptySpaceButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SidemenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidemenuPanel
            // 
            this.SidemenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(47)))), ((int)(((byte)(117)))));
            this.SidemenuPanel.Controls.Add(this.AboutButton);
            this.SidemenuPanel.Controls.Add(this.JwButton);
            this.SidemenuPanel.Controls.Add(this.SystemTelButton);
            this.SidemenuPanel.Controls.Add(this.EmptySpaceButton);
            this.SidemenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidemenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SidemenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidemenuPanel.Name = "SidemenuPanel";
            this.SidemenuPanel.Size = new System.Drawing.Size(284, 814);
            this.SidemenuPanel.TabIndex = 0;
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(47)))), ((int)(((byte)(117)))));
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.AboutButton.Location = new System.Drawing.Point(0, 198);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(4);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(284, 66);
            this.AboutButton.TabIndex = 4;
            this.AboutButton.Text = "O programie";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // JwButton
            // 
            this.JwButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(47)))), ((int)(((byte)(117)))));
            this.JwButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.JwButton.FlatAppearance.BorderSize = 0;
            this.JwButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JwButton.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JwButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.JwButton.Location = new System.Drawing.Point(0, 132);
            this.JwButton.Margin = new System.Windows.Forms.Padding(4);
            this.JwButton.Name = "JwButton";
            this.JwButton.Size = new System.Drawing.Size(284, 66);
            this.JwButton.TabIndex = 2;
            this.JwButton.Text = "Jednostki";
            this.JwButton.UseVisualStyleBackColor = false;
            this.JwButton.Click += new System.EventHandler(this.JwButton_Click);
            // 
            // SystemTelButton
            // 
            this.SystemTelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(47)))), ((int)(((byte)(117)))));
            this.SystemTelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SystemTelButton.FlatAppearance.BorderSize = 0;
            this.SystemTelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemTelButton.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemTelButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.SystemTelButton.Location = new System.Drawing.Point(0, 66);
            this.SystemTelButton.Margin = new System.Windows.Forms.Padding(4);
            this.SystemTelButton.Name = "SystemTelButton";
            this.SystemTelButton.Size = new System.Drawing.Size(284, 66);
            this.SystemTelButton.TabIndex = 1;
            this.SystemTelButton.Text = "System Telefoniczny";
            this.SystemTelButton.UseVisualStyleBackColor = false;
            this.SystemTelButton.Click += new System.EventHandler(this.SystemTelButton_Click);
            // 
            // EmptySpaceButton
            // 
            this.EmptySpaceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(47)))), ((int)(((byte)(117)))));
            this.EmptySpaceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmptySpaceButton.Enabled = false;
            this.EmptySpaceButton.FlatAppearance.BorderSize = 0;
            this.EmptySpaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmptySpaceButton.Location = new System.Drawing.Point(0, 0);
            this.EmptySpaceButton.Margin = new System.Windows.Forms.Padding(4);
            this.EmptySpaceButton.Name = "EmptySpaceButton";
            this.EmptySpaceButton.Size = new System.Drawing.Size(284, 66);
            this.EmptySpaceButton.TabIndex = 0;
            this.EmptySpaceButton.UseVisualStyleBackColor = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(112)))));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(284, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1095, 814);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 814);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SidemenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Biuro Napraw";
            this.SidemenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidemenuPanel;
        private System.Windows.Forms.Button EmptySpaceButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button JwButton;
        private System.Windows.Forms.Button SystemTelButton;
        private System.Windows.Forms.Panel MainPanel;
    }
}

