namespace _4Linha
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn2J = new System.Windows.Forms.Button();
            this.btn3J = new System.Windows.Forms.Button();
            this.btn1J = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btn4J = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exprimente o ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "4 em Linha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade de jogadores";
            // 
            // btn2J
            // 
            this.btn2J.Location = new System.Drawing.Point(62, 210);
            this.btn2J.Name = "btn2J";
            this.btn2J.Size = new System.Drawing.Size(75, 23);
            this.btn2J.TabIndex = 4;
            this.btn2J.Text = "2 Jogadores";
            this.btn2J.UseVisualStyleBackColor = true;
            this.btn2J.Click += new System.EventHandler(this.btn2J_Click);
            // 
            // btn3J
            // 
            this.btn3J.Location = new System.Drawing.Point(62, 239);
            this.btn3J.Name = "btn3J";
            this.btn3J.Size = new System.Drawing.Size(75, 23);
            this.btn3J.TabIndex = 5;
            this.btn3J.Text = "3 Jogadores";
            this.btn3J.UseVisualStyleBackColor = true;
            this.btn3J.Click += new System.EventHandler(this.btn3J_Click);
            // 
            // btn1J
            // 
            this.btn1J.Location = new System.Drawing.Point(62, 181);
            this.btn1J.Name = "btn1J";
            this.btn1J.Size = new System.Drawing.Size(75, 23);
            this.btn1J.TabIndex = 6;
            this.btn1J.Text = "1 Jogador";
            this.btn1J.UseVisualStyleBackColor = true;
            this.btn1J.Click += new System.EventHandler(this.btn1J_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_4Linha.Properties.Resources.tabuleioMenu;
            this.pictureBox1.Location = new System.Drawing.Point(245, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(722, 418);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(66, 20);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btn4J
            // 
            this.btn4J.Location = new System.Drawing.Point(62, 268);
            this.btn4J.Name = "btn4J";
            this.btn4J.Size = new System.Drawing.Size(75, 23);
            this.btn4J.TabIndex = 8;
            this.btn4J.Text = "4 Jogadores";
            this.btn4J.UseVisualStyleBackColor = true;
            this.btn4J.Click += new System.EventHandler(this.btn4J_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn4J);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btn1J);
            this.Controls.Add(this.btn3J);
            this.Controls.Add(this.btn2J);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn2J;
        private System.Windows.Forms.Button btn3J;
        private System.Windows.Forms.Button btn1J;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btn4J;
    }
}

