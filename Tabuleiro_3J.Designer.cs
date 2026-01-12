namespace _4Linha
{
    partial class Tabuleiro_3J
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabuleiro_3J));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lbConv1 = new System.Windows.Forms.Label();
            this.lbJogador = new System.Windows.Forms.Label();
            this.lbConv2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_4Linha.Properties.Resources.tabuleiro;
            this.pictureBox1.Location = new System.Drawing.Point(128, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(735, 456);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(53, 20);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lbConv1
            // 
            this.lbConv1.AutoSize = true;
            this.lbConv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConv1.Location = new System.Drawing.Point(375, 22);
            this.lbConv1.Name = "lbConv1";
            this.lbConv1.Size = new System.Drawing.Size(50, 16);
            this.lbConv1.TabIndex = 10;
            this.lbConv1.Text = "label2";
            // 
            // lbJogador
            // 
            this.lbJogador.AutoSize = true;
            this.lbJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJogador.Location = new System.Drawing.Point(125, 22);
            this.lbJogador.Name = "lbJogador";
            this.lbJogador.Size = new System.Drawing.Size(50, 16);
            this.lbJogador.TabIndex = 9;
            this.lbJogador.Text = "label1";
            // 
            // lbConv2
            // 
            this.lbConv2.AutoSize = true;
            this.lbConv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConv2.Location = new System.Drawing.Point(617, 22);
            this.lbConv2.Name = "lbConv2";
            this.lbConv2.Size = new System.Drawing.Size(50, 16);
            this.lbConv2.TabIndex = 11;
            this.lbConv2.Text = "label2";
            // 
            // Tabuleiro_3J
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.lbConv2);
            this.Controls.Add(this.lbConv1);
            this.Controls.Add(this.lbJogador);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Tabuleiro_3J";
            this.Text = "Tabuleiro_3J";
            this.Load += new System.EventHandler(this.Tabuleiro_3J_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lbConv1;
        private System.Windows.Forms.Label lbJogador;
        private System.Windows.Forms.Label lbConv2;
    }
}