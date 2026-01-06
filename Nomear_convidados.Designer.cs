namespace _4Linha
{
    partial class Nomear_convidados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nomear_convidados));
            this.label2 = new System.Windows.Forms.Label();
            this.lbConv1 = new System.Windows.Forms.Label();
            this.txtconv1 = new System.Windows.Forms.TextBox();
            this.txtconv2 = new System.Windows.Forms.TextBox();
            this.lbConv2 = new System.Windows.Forms.Label();
            this.txtconv3 = new System.Windows.Forms.TextBox();
            this.lbConv3 = new System.Windows.Forms.Label();
            this.btnDef = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbxConv = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(611, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quais serão o nome dos convidados";
            // 
            // lbConv1
            // 
            this.lbConv1.AutoSize = true;
            this.lbConv1.Location = new System.Drawing.Point(98, 160);
            this.lbConv1.Name = "lbConv1";
            this.lbConv1.Size = new System.Drawing.Size(119, 13);
            this.lbConv1.TabIndex = 10;
            this.lbConv1.Text = "Nome do 1º convidado:";
            // 
            // txtconv1
            // 
            this.txtconv1.Location = new System.Drawing.Point(98, 193);
            this.txtconv1.Name = "txtconv1";
            this.txtconv1.Size = new System.Drawing.Size(176, 20);
            this.txtconv1.TabIndex = 11;
            // 
            // txtconv2
            // 
            this.txtconv2.Location = new System.Drawing.Point(494, 193);
            this.txtconv2.Name = "txtconv2";
            this.txtconv2.Size = new System.Drawing.Size(176, 20);
            this.txtconv2.TabIndex = 13;
            // 
            // lbConv2
            // 
            this.lbConv2.AutoSize = true;
            this.lbConv2.Location = new System.Drawing.Point(494, 160);
            this.lbConv2.Name = "lbConv2";
            this.lbConv2.Size = new System.Drawing.Size(119, 13);
            this.lbConv2.TabIndex = 12;
            this.lbConv2.Text = "Nome do 2º convidado:";
            // 
            // txtconv3
            // 
            this.txtconv3.Location = new System.Drawing.Point(98, 287);
            this.txtconv3.Name = "txtconv3";
            this.txtconv3.Size = new System.Drawing.Size(176, 20);
            this.txtconv3.TabIndex = 15;
            // 
            // lbConv3
            // 
            this.lbConv3.AutoSize = true;
            this.lbConv3.Location = new System.Drawing.Point(98, 254);
            this.lbConv3.Name = "lbConv3";
            this.lbConv3.Size = new System.Drawing.Size(119, 13);
            this.lbConv3.TabIndex = 14;
            this.lbConv3.Text = "Nome do 3º convidado:";
            // 
            // btnDef
            // 
            this.btnDef.Location = new System.Drawing.Point(336, 327);
            this.btnDef.Name = "btnDef";
            this.btnDef.Size = new System.Drawing.Size(121, 38);
            this.btnDef.TabIndex = 16;
            this.btnDef.Text = "Defenir nome dos convidados";
            this.btnDef.UseVisualStyleBackColor = true;
            this.btnDef.Click += new System.EventHandler(this.btnDef_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(641, 411);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Numero de convidados:";
            // 
            // cbbxConv
            // 
            this.cbbxConv.FormattingEnabled = true;
            this.cbbxConv.Location = new System.Drawing.Point(221, 112);
            this.cbbxConv.Name = "cbbxConv";
            this.cbbxConv.Size = new System.Drawing.Size(121, 21);
            this.cbbxConv.TabIndex = 19;
            this.cbbxConv.SelectedIndexChanged += new System.EventHandler(this.cbbxConv_SelectedIndexChanged);
            // 
            // Nomear_convidados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.cbbxConv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDef);
            this.Controls.Add(this.txtconv3);
            this.Controls.Add(this.lbConv3);
            this.Controls.Add(this.txtconv2);
            this.Controls.Add(this.lbConv2);
            this.Controls.Add(this.txtconv1);
            this.Controls.Add(this.lbConv1);
            this.Controls.Add(this.label2);
            this.Name = "Nomear_convidados";
            this.Text = "Nomear_convidados";
            this.Load += new System.EventHandler(this.Nomear_convidados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbConv1;
        private System.Windows.Forms.TextBox txtconv1;
        private System.Windows.Forms.TextBox txtconv2;
        private System.Windows.Forms.Label lbConv2;
        private System.Windows.Forms.TextBox txtconv3;
        private System.Windows.Forms.Label lbConv3;
        private System.Windows.Forms.Button btnDef;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbxConv;
    }
}