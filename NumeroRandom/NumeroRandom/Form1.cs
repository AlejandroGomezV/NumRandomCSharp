using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroRandom
{
    public partial class Form1 : Form
    {
        private List<int> listanumerosbloquedos;

        public Form1()
        {
            InitializeComponent();
            listanumerosbloquedos = new List<int>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 65; i < 80; i++)
            {
                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = Convert.ToChar(i).ToString();
                columna.Width = 50;
                columna.ReadOnly = true;

                dataGridView1.Columns.Add(columna);
            }

            int cont = 1;
            for (int i = 1; i < 26; i++)
            {
                int index = dataGridView1.Rows.Add();
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (cont <= 365)
                    {
                        dataGridView1.Rows[index].Cells[j].Value = cont;
                        cont++;
                    }
                    else
                    {
                        dataGridView1.Rows[index].Cells[j].Value = 0;
                    }
                }
            }
        }

        private void btnrandom_Click(object sender, EventArgs e)
        {
            generarRandom();
        }

        private void generarRandom()
        {
            Random myObject = new Random();
            int ranNum = myObject.Next(1, 365);

            if (listanumerosbloquedos.Count > 0)
            {
                while (listanumerosbloquedos.Contains(ranNum))
                {
                    ranNum = myObject.Next(1, 365);
                }
            }

            var result = MessageBox.Show("Numero generado: " + ranNum + "\nSi: Aceptar\nNo: Generar Nuevo", "Numero generado",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString() == ranNum.ToString())
                            {
                                dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Green;
                                listanumerosbloquedos.Add(ranNum);
                                listGenerados.Items.Add(ranNum.ToString());
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (result == DialogResult.No)
            {
                generarRandom();
            }
        }

        private void btnbloquear_Click(object sender, EventArgs e)
        {
            int numerobloqueado = int.Parse(txtNum.Text);

            if (listanumerosbloquedos.Contains(numerobloqueado))
            {
                MessageBox.Show("Ingrese otro numero", "Numero repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum.Text = "";
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString() == numerobloqueado.ToString())
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                            listanumerosbloquedos.Add(numerobloqueado);
                            listBloqueados.Items.Add(numerobloqueado.ToString());
                            break;
                        }
                    }
                }
            }
        }
    }
}