using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroRandom
{
    public partial class Form1 : Form
    {
        private List<int> listanumerosbloquedos;
        private int meta;
        private int actual;
        private int diferencia;

        public Form1()
        {
            InitializeComponent();
            listanumerosbloquedos = new List<int>();
            meta = 0;
            actual = 0;
            diferencia = 0;
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
                        meta += cont;
                        cont++;
                    }
                    else
                    {
                        dataGridView1.Rows[index].Cells[j].Value = 0;
                    }
                }
            }

            leer_archivo();

            txtMeta.Text = meta.ToString();
            txtActual.Text = actual.ToString();
            diferencia = meta - actual;
            txtFaltante.Text = diferencia.ToString();
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
                                actual += ranNum;
                                txtActual.Text = actual.ToString();
                                diferencia = meta - actual;
                                txtFaltante.Text = diferencia.ToString();
                                guardar_archivo(2, ranNum);
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
                            actual += numerobloqueado;
                            txtActual.Text = actual.ToString();
                            diferencia = meta - actual;
                            txtFaltante.Text = diferencia.ToString();
                            guardar_archivo(2, numerobloqueado);
                            break;
                        }
                    }
                }
            }
        }

        private void leer_archivo()
        {
            string path = "randomnum_db.rdn";
            if (File.Exists(path))
            {
                List<string> agregados = new List<string>();
                List<string> bloqueados = new List<string>();
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (s.Contains("meta"))
                        {
                            meta = int.Parse(s.Split(":")[1]);
                        }
                        else if (s.Contains("actual"))
                        {
                            actual = int.Parse(s.Split(":")[1]);
                        }
                        else if (s.Contains("diferencia"))
                        {
                            diferencia = int.Parse(s.Split(":")[1]);
                        }
                        else if (s.Contains("agregados"))
                        {
                            agregados = s.Split(":")[1].Split(";").ToList();
                        }
                        else if (s.Contains("bloqueados"))
                        {
                            bloqueados = s.Split(":")[1].Split(";").ToList();
                        }
                    }
                }

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                    {
                        if (agregados.Count > 0)
                            foreach (string num in agregados)
                            {
                                if (dataGridView1.Rows[i].Cells[j].Value.ToString() == num)
                                {
                                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Green;
                                    listanumerosbloquedos.Add(int.Parse(num));
                                    listGenerados.Items.Add(num.ToString());
                                }
                            }

                        if (bloqueados.Count > 0)
                            foreach (string num in bloqueados)
                            {
                                if (dataGridView1.Rows[i].Cells[j].Value.ToString() == num)
                                {
                                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                                    listanumerosbloquedos.Add(int.Parse(num));
                                    listBloqueados.Items.Add(num.ToString());
                                }
                            }
                    }
                }
            }
        }

        private void guardar_archivo(int tipo, int valor)
        {
            string path = "randomnum_db.rdn";
            using (StreamWriter fs = File.CreateText(path))
            {
                fs.WriteLine("meta:" + meta);
                fs.WriteLine("actual:" + actual);
                fs.WriteLine("diferencia:" + diferencia);

                string generados = "";
                foreach (ListViewItem num in listGenerados.Items)
                {
                    generados += num.Text + ";";
                }
                generados.TrimEnd(';');
                fs.WriteLine("agregados:" + generados);

                string bloqueados = "";
                foreach (ListViewItem num in listBloqueados.Items)
                {
                    bloqueados += num.Text + ";";
                }
                bloqueados.TrimEnd(';');
                fs.WriteLine("bloqueados:" + bloqueados);
            }
        }
    }
}

/*
 Codigo respaldo

if (!File.Exists(path))
            {
                using (StreamWriter fs = File.CreateText(path))
                {
                    fs.WriteLine("meta:" + meta);
                    fs.WriteLine("actual:" + actual);
                    fs.WriteLine("diferencia:" + diferencia);
                }
            }
            else 



            else if (File.Exists(path))
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (s.Contains("meta"))
                        {
                            meta = int.Parse(s.Split(":")[1]);
                        }
                        else if (s.Contains("actual"))
                        {
                            actual = int.Parse(s.Split(":")[1]);
                        }
                        else if (s.Contains("diferencia"))
                        {
                            diferencia = int.Parse(s.Split(":")[1]);
                        }
                        else if (s.Contains("agregados"))
                        {
                            agregados = s.Split(":")[1].Split(";").ToList();
                        }
                        else if (s.Contains("bloqueados"))
                        {
                            bloqueados = s.Split(":")[1].Split(";").ToList();
                        }
                    }
                }
            }

 */