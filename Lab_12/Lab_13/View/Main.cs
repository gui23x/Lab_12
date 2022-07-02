using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_13.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            string endereco = @"D:\senac\teste007.txt";

            try
            {
                if (!System.IO.File.Exists(endereco))
                {
                    throw new Exception(
                        "Arquivo teste007.txt não foi localizado."
                        );
                }

                string[] dados = new string[4];

                System.IO.StreamReader Leitor = new System.IO.StreamReader(endereco);

                lbxResultado.Items.Add(
                    "Código".PadRight(20) +
                    "Cliente".PadRight(27) +
                    "Cidade".PadRight(30) +
                    "País"
                    );
                lbxResultado.Items.Add(new string('-', 80));

                while (!Leitor.EndOfStream)
                {
                    dados = Leitor.ReadLine().Split(';');

                    lbxResultado.Items.Add(
                        dados[0].PadRight(25) +
                        dados[1].PadRight(27) +
                        dados[2].PadRight(28) +
                        dados[3]);
                }

                Leitor.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
