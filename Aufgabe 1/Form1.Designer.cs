namespace Aufgabe_1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGreetingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNameBox
            // 
            this.txtNameBox.Location = new System.Drawing.Point(23, 180);
            this.txtNameBox.Name = "txtNameBox";
            this.txtNameBox.Size = new System.Drawing.Size(502, 31);
            this.txtNameBox.TabIndex = 0;
            this.txtNameBox.TextChanged += new System.EventHandler(this.txtNameTextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(502, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Eingabe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnEingabe);
            // 
            // lblGreetingLabel
            // 
            this.lblGreetingLabel.AutoSize = true;
            this.lblGreetingLabel.Location = new System.Drawing.Point(238, 88);
            this.lblGreetingLabel.Name = "lblGreetingLabel";
            this.lblGreetingLabel.Size = new System.Drawing.Size(0, 25);
            this.lblGreetingLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 543);
            this.Controls.Add(this.lblGreetingLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblGreetingLabel;
    }
}

