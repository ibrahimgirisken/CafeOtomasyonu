namespace CafeOtomasyonu.WinForms
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
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.btnMenuAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(12, 27);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(152, 20);
            this.txtMenuName.TabIndex = 0;
            // 
            // btnMenuAdd
            // 
            this.btnMenuAdd.Location = new System.Drawing.Point(12, 63);
            this.btnMenuAdd.Name = "btnMenuAdd";
            this.btnMenuAdd.Size = new System.Drawing.Size(152, 23);
            this.btnMenuAdd.TabIndex = 1;
            this.btnMenuAdd.Text = "Ekle";
            this.btnMenuAdd.UseVisualStyleBackColor = true;
            this.btnMenuAdd.Click += new System.EventHandler(this.btnMenuAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 132);
            this.Controls.Add(this.btnMenuAdd);
            this.Controls.Add(this.txtMenuName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu İşlemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.Button btnMenuAdd;
    }
}

