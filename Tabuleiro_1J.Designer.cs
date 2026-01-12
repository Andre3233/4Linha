namespace _4Linha
{
    partial class Tabuleiro_1J
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabuleiro_1J));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lbJogador = new System.Windows.Forms.Label();
            this.lbBot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_4Linha.Properties.Resources.tabuleiro;
            this.pictureBox1.Location = new System.Drawing.Point(136, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(735, 456);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(53, 20);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lbJogador
            // 
            this.lbJogador.AutoSize = true;
            this.lbJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJogador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbJogador.Location = new System.Drawing.Point(99, 19);
            this.lbJogador.Name = "lbJogador";
            this.lbJogador.Size = new System.Drawing.Size(50, 16);
            this.lbJogador.TabIndex = 7;
            this.lbJogador.Text = "label1";
            // 
            // lbBot
            // 
            this.lbBot.AutoSize = true;
            this.lbBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBot.Location = new System.Drawing.Point(681, 19);
            this.lbBot.Name = "lbBot";
            this.lbBot.Size = new System.Drawing.Size(30, 16);
            this.lbBot.TabIndex = 8;
            this.lbBot.Text = "Bot";
            // 
            // Tabuleiro_1J
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.lbBot);
            this.Controls.Add(this.lbJogador);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Tabuleiro_1J";
            this.Text = "Tabuleiro_1J";
            this.Load += new System.EventHandler(this.Tabuleiro_1J_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lbJogador;
        private System.Windows.Forms.Label lbBot;
    }
}