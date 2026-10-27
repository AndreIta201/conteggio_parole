namespace conteggio_parole
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
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.btn_verifica = new System.Windows.Forms.Button();
            this.lbl_spazio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(232, 9);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(296, 37);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "Inserire una frase:";
            // 
            // txt_n1
            // 
            this.txt_n1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n1.Location = new System.Drawing.Point(239, 70);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(261, 35);
            this.txt_n1.TabIndex = 1;
            // 
            // btn_verifica
            // 
            this.btn_verifica.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verifica.Location = new System.Drawing.Point(316, 128);
            this.btn_verifica.Name = "btn_verifica";
            this.btn_verifica.Size = new System.Drawing.Size(106, 66);
            this.btn_verifica.TabIndex = 2;
            this.btn_verifica.Text = "Verifica";
            this.btn_verifica.UseVisualStyleBackColor = true;
            this.btn_verifica.Click += new System.EventHandler(this.btn_verifica_Click);
            // 
            // lbl_spazio
            // 
            this.lbl_spazio.AutoSize = true;
            this.lbl_spazio.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spazio.Location = new System.Drawing.Point(199, 209);
            this.lbl_spazio.Name = "lbl_spazio";
            this.lbl_spazio.Size = new System.Drawing.Size(0, 25);
            this.lbl_spazio.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 459);
            this.Controls.Add(this.lbl_spazio);
            this.Controls.Add(this.btn_verifica);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Button btn_verifica;
        private System.Windows.Forms.Label lbl_spazio;
    }
}

