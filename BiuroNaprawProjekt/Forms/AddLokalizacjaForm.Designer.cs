
namespace BiuroNaprawProjekt.Forms
{
    partial class AddLokalizacjaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLokalizacjaForm));
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NazwaTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Location = new System.Drawing.Point(71, 168);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 42);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Location = new System.Drawing.Point(399, 168);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(120, 42);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Zamknij";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F);
            this.label1.Location = new System.Drawing.Point(67, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwa Lokalizacji";
            // 
            // NazwaTextbox
            // 
            this.NazwaTextbox.Location = new System.Drawing.Point(256, 85);
            this.NazwaTextbox.Name = "NazwaTextbox";
            this.NazwaTextbox.Size = new System.Drawing.Size(340, 22);
            this.NazwaTextbox.TabIndex = 4;
            // 
            // AddLokalizacjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(64)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(656, 297);
            this.Controls.Add(this.NazwaTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(150, 200);
            this.Name = "AddLokalizacjaForm";
            this.Text = "AddLokalizacjaForm";
            this.Load += new System.EventHandler(this.AddLokalizacjaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NazwaTextbox;
    }
}