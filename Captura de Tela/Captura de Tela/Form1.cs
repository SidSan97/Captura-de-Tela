using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Captura_de_Tela
{
    public partial class Form1 : Form
    {
        Graphics g;
        int TelaLargura = Screen.PrimaryScreen.Bounds.Width;
        int TelaAltura = Screen.PrimaryScreen.Bounds.Height;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            this.Hide();
           // timer1.Start();
           /* while (i < 2)
            {
                saveFileDialog1.ShowDialog();
                i++;
            }*/
           
        }
        private void Limpar_Tela_Click(object sender, EventArgs e)
        {         
             this.Hide();
             timer1.Start();                      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //armazena a imagem no bitmap
            Bitmap b = new Bitmap(TelaLargura, TelaAltura);
            //copia  a tela no bitmap
            g = Graphics.FromImage(b);
            g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.Bounds.Size);
            //atribui a imagem ao picturebox exibindo-a
            pictureBox1.Image = b;
            this.Show();
            //habilita o botão para salvar a tela
            Salvar_Tela.Enabled = true;
            //encerra o timer
            timer1.Stop();
        }
        private void Salvar_Tela_Click(object sender, EventArgs e)
        {          
            //abre a janela de dialogo SaveDialog para salvar o arquivo gerado na captura
            DialogResult res = saveFileDialog1.ShowDialog();

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Tela de captura está vazia");            
            }

            if (res == DialogResult.OK)
            {
                string path = System.IO.Directory.GetCurrentDirectory();

                //obtem a extensão do arquivo salvo
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                if (ext == ".jpg")
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                else if (ext == ".gif")
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                else if (ext == ".png")
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);              
            }
        }

        private void Encerrar_Click(object sender, EventArgs e)
        {           
            this.Close();      
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var fileName = Path.Combine(folder, "NomeFixoDoArquivo.cnf");

          //  File.WriteAllText(fileName, txtConfig.Text);
        }      

    }
}
