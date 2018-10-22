using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PastasEFicheiros
{
    public partial class Form1 : Form
    {
        //string pasta_trabalho = @"C:\Users\josiel.alves\Desktop\trabalho\docs";

        //string pasta_config = @"C:\Users\josiel.alves\Desktop\config\";
        string pasta_config;
        string ficheiro_config = "config.dat";

        public Form1()
        {
            InitializeComponent();

            pasta_config = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\config\";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //determinar se uma pasta existe
            //if (Directory.Exists(@"C:\Users\josiel.alves\Desktop\temp")) {
            //    MessageBox.Show("Existe");
            //} else {
            //    MessageBox.Show("Não existe");
            //}
            //if (!Directory.Exists(@"C:\Users\josiel.alves\Desktop\trabalho")) {
            //    Directory.CreateDirectory(pasta_trabalho);
            //}

            GravarConfiguracoes();

            MessageBox.Show("Configurações gravadas com sucesso.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //verifica se o ficheiro config.dat existe
            if(!File.Exists(pasta_config + ficheiro_config)) {
                GravarConfiguracoes();
            } else { 
                //carregamento das configurações
                StreamReader ficheiro = new StreamReader(pasta_config + ficheiro_config, Encoding.Default);
                text_nome.Text = ficheiro.ReadLine();
                data_hora.Value = Convert.ToDateTime(ficheiro.ReadLine());
                ficheiro.Dispose();
            }
        }

        private void GravarConfiguracoes()
        {
            //verifica se existe a pasta config
            //se não existir, cria a pasta
            if (!Directory.Exists(pasta_config)) {
                Directory.CreateDirectory(pasta_config);
            }

            StreamWriter ficheiro = new StreamWriter(pasta_config + ficheiro_config, false, Encoding.Default);
            ficheiro.WriteLine(text_nome.Text);
            ficheiro.WriteLine(data_hora.Value.ToShortDateString());
            ficheiro.Dispose();
        }
    }
}
