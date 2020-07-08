using System.ComponentModel;

namespace UI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.LegajoLBL = new System.Windows.Forms.Label();
            this.PasswordLBL = new System.Windows.Forms.Label();
            this.LegajoTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.IngresarBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LegajoLBL
            // 
            this.LegajoLBL.AutoSize = true;
            this.LegajoLBL.Location = new System.Drawing.Point(28, 29);
            this.LegajoLBL.Name = "LegajoLBL";
            this.LegajoLBL.Size = new System.Drawing.Size(42, 13);
            this.LegajoLBL.TabIndex = 0;
            this.LegajoLBL.Text = "Legajo:";
            // 
            // PasswordLBL
            // 
            this.PasswordLBL.AutoSize = true;
            this.PasswordLBL.Location = new System.Drawing.Point(6, 73);
            this.PasswordLBL.Name = "PasswordLBL";
            this.PasswordLBL.Size = new System.Drawing.Size(64, 13);
            this.PasswordLBL.TabIndex = 1;
            this.PasswordLBL.Text = "Contraseña:";
            // 
            // LegajoTB
            // 
            this.LegajoTB.Location = new System.Drawing.Point(81, 29);
            this.LegajoTB.Name = "LegajoTB";
            this.LegajoTB.Size = new System.Drawing.Size(228, 20);
            this.LegajoTB.TabIndex = 2;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(81, 66);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(228, 20);
            this.PasswordTB.TabIndex = 2;
            // 
            // IngresarBTN
            // 
            this.IngresarBTN.Location = new System.Drawing.Point(9, 104);
            this.IngresarBTN.Name = "IngresarBTN";
            this.IngresarBTN.Size = new System.Drawing.Size(297, 29);
            this.IngresarBTN.TabIndex = 3;
            this.IngresarBTN.Text = "Ingresar!";
            this.IngresarBTN.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 157);
            this.Controls.Add(this.IngresarBTN);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LegajoTB);
            this.Controls.Add(this.PasswordLBL);
            this.Controls.Add(this.LegajoLBL);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LegajoLBL;
        private System.Windows.Forms.Label PasswordLBL;
        private System.Windows.Forms.TextBox LegajoTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button IngresarBTN;
    }
}