namespace _4Linha
{
    partial class Modo_Jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modo_Jogo));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Vpessoas = new System.Windows.Forms.Button();
            this.btnSozinho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Escolha qual sera o modo de jogo";
            // 
            // btn_Vpessoas
            // 
            this.btn_Vpessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vpessoas.Location = new System.Drawing.Point(429, 163);
            this.btn_Vpessoas.Name = "btn_Vpessoas";
            this.btn_Vpessoas.Size = new System.Drawing.Size(178, 110);
            this.btn_Vpessoas.TabIndex = 11;
            this.btn_Vpessoas.Text = "Varia pessoas";
            this.btn_Vpessoas.UseVisualStyleBackColor = true;
            this.btn_Vpessoas.Click += new System.EventHandler(this.btn_Vpessoas_Click);
            // 
            // btnSozinho
            // 
            this.btnSozinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSozinho.Location = new System.Drawing.Point(118, 163);
            this.btnSozinho.Name = "btnSozinho";
            this.btnSozinho.Size = new System.Drawing.Size(178, 110);
            this.btnSozinho.TabIndex = 12;
            this.btnSozinho.Text = "Sozinho";
            this.btnSozinho.UseVisualStyleBackColor = true;
            this.btnSozinho.Click += new System.EventHandler(this.btnSozinho_Click);
            // 
            // Modo_Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.btnSozinho);
            this.Controls.Add(this.btn_Vpessoas);
            this.Controls.Add(this.label1);
            this.Name = "Modo_Jogo";
            this.Text = "Modo_Jogo";
            this.Load += new System.EventHandler(this.Modo_Jogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Vpessoas;
        private System.Windows.Forms.Button btnSozinho;
    }
}