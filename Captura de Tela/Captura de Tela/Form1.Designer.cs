namespace Captura_de_Tela
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Capturar_Tela = new System.Windows.Forms.Button();
            this.Salvar_Tela = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Encerrar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Capturar_Tela
            // 
            this.Capturar_Tela.Location = new System.Drawing.Point(13, 4);
            this.Capturar_Tela.Name = "Capturar_Tela";
            this.Capturar_Tela.Size = new System.Drawing.Size(103, 23);
            this.Capturar_Tela.TabIndex = 1;
            this.Capturar_Tela.Text = "Capturar Tela";
            this.Capturar_Tela.UseVisualStyleBackColor = true;
            this.Capturar_Tela.Click += new System.EventHandler(this.Limpar_Tela_Click);
            // 
            // Salvar_Tela
            // 
            this.Salvar_Tela.Location = new System.Drawing.Point(122, 4);
            this.Salvar_Tela.Name = "Salvar_Tela";
            this.Salvar_Tela.Size = new System.Drawing.Size(91, 23);
            this.Salvar_Tela.TabIndex = 2;
            this.Salvar_Tela.Text = "Salvar Tela";
            this.Salvar_Tela.UseVisualStyleBackColor = true;
            this.Salvar_Tela.Click += new System.EventHandler(this.Salvar_Tela_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(219, 4);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(75, 23);
            this.Limpar.TabIndex = 3;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Encerrar
            // 
            this.Encerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Encerrar.Location = new System.Drawing.Point(552, 4);
            this.Encerrar.Name = "Encerrar";
            this.Encerrar.Size = new System.Drawing.Size(75, 23);
            this.Encerrar.TabIndex = 4;
            this.Encerrar.Text = "Encerrar";
            this.Encerrar.UseVisualStyleBackColor = true;
            this.Encerrar.Click += new System.EventHandler(this.Encerrar_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPEG Files|*.jpg|GIF Files|*.gif|PNG Files|*.png";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 470);
            this.Controls.Add(this.Encerrar);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Salvar_Tela);
            this.Controls.Add(this.Capturar_Tela);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Capturar telas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Capturar_Tela;
        private System.Windows.Forms.Button Salvar_Tela;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Encerrar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

