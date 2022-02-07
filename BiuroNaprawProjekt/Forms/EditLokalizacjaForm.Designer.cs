
namespace BiuroNaprawProjekt.Forms
{
    partial class EditLokalizacjaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLokalizacjaForm));
            this.NazwaTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NazwaTextbox
            // 
            this.NazwaTextbox.Location = new System.Drawing.Point(258, 87);
            this.NazwaTextbox.Name = "NazwaTextbox";
            this.NazwaTextbox.Size = new System.Drawing.Size(340, 22);
            this.NazwaTextbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F);
            this.label1.Location = new System.Drawing.Point(69, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nazwa Lokalizacji";
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Location = new System.Drawing.Point(401, 170);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(120, 42);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Zamknij";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Location = new System.Drawing.Point(73, 170);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 42);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditLokalizacjaForm
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
            this.Name = "EditLokalizacjaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditLokalizacjaForm";
            this.Load += new System.EventHandler(this.EditLokalizacjaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NazwaTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveButton;
    }
}