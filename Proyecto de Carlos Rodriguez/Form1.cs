using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_de_Carlos_Rodriguez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Cal_estandar();
            claroToolStripMenuItem.Checked = true;
        }
        private void Cal_estandar()
        {
            estándarToolStripMenuItem.Checked = true;
            científicaToolStripMenuItem.Checked = false;
            programadorToolStripMenuItem.Checked = false;
            estadísticasToolStripMenuItem.Checked = false;
            conversiónDeUnidadesToolStripMenuItem.Checked = false;
            conversiónDeUnidadesToolStripMenuItem.Enabled = true;
            panel_CDU.Visible = false;
            panel_cient.Visible = false;
            panel_prog.Visible = false;
            panel1.Size = new Size(249, 55);
            //label1.Location = new Point(217, 20);
            textBox5.Size = new Size(239, 28);
            textBox5.Location = new Point(3, 18);
            panel_estandar.Location = new Point(13, 98);
            Size = new Size(280, 386);

            button_nothing.Enabled = true;
            button77.Enabled = true;
            button29.Enabled = true;
            button61.Enabled = true;
            button60.Enabled = true;
            button66.Enabled = true;
        }

        private void Cal_cientifica()
        {
            OcultarCDU();
            estándarToolStripMenuItem.Checked = false;
            científicaToolStripMenuItem.Checked = true;
            programadorToolStripMenuItem.Checked = false;
            estadísticasToolStripMenuItem.Checked = false;
            conversiónDeUnidadesToolStripMenuItem.Enabled = false;
            Size = new Size(540, 386);
            panel1.Size = new Size(504, 55);
            textBox5.Size = new Size(494, 28);
            textBox6.Size = new Size(494, 14);
            panel_estandar.Location = new Point(268, 98);
            panel_cient.Visible = true;
            panel_prog.Visible = false;
            panel_cient.Location = new Point(13, 98);

            button_nothing.Enabled = false;
            button77.Enabled = true;
            button29.Enabled = false;
            button61.Enabled = false;
            button60.Enabled = true;
            button66.Enabled = true;
        }

        private void Cal_programador()
        {
            OcultarCDU();
            estándarToolStripMenuItem.Checked = false;
            científicaToolStripMenuItem.Checked = false;
            programadorToolStripMenuItem.Checked = true;
            estadísticasToolStripMenuItem.Checked = false;
            conversiónDeUnidadesToolStripMenuItem.Enabled = false;
            Size = new Size(540, 386);
            panel1.Size = new Size(504, 55);
            textBox5.Size = new Size(494, 28);
            textBox6.Size = new Size(494, 14);
            panel_estandar.Location = new Point(268, 98);
            panel_cient.Visible = false;
            panel_prog.Visible = true;
            panel_prog.Location = new Point(13, 98);

            button_hexa.Checked = true;
            button_qword.Checked = true;

            button_nothing.Enabled = false;
            button77.Enabled = false;
            button29.Enabled = true;
            button61.Enabled = false;
            button60.Enabled = false;
            button66.Enabled = false;
        }

        private void MostrarCDU()
        {
            Size = new Size(902, 386);
            panel_CDU.Visible = true;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            conversiónDeUnidadesToolStripMenuItem.Checked = true;
        }
        private void OcultarCDU()
        {
            panel_CDU.Visible = false;
            conversiónDeUnidadesToolStripMenuItem.Checked = false;
        }
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void estándarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cal_estandar();
        }

        private void científicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cal_cientifica();
        }

        private void programadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cal_programador();
            estándarToolStripMenuItem.Checked = false;
            científicaToolStripMenuItem.Checked = false;
            programadorToolStripMenuItem.Checked = true;
            estadísticasToolStripMenuItem.Checked = false;
        }

        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estándarToolStripMenuItem.Checked = false;
            científicaToolStripMenuItem.Checked = false;
            programadorToolStripMenuItem.Checked = false;
            estadísticasToolStripMenuItem.Checked = true;
        }

        private void button_hexa_CheckedChanged(object sender, EventArgs e)
        {
            button_A.Enabled = true;
            button_B.Enabled = true;
            button_C.Enabled = true;
            button_D.Enabled = true;
            button_E.Enabled = true;
            button_F.Enabled = true;
            button76.Enabled = true;
            button75.Enabled = true;
            button74.Enabled = true;
            button73.Enabled = true;
            button72.Enabled = true;
            button71.Enabled = true;
            button69.Enabled = true;
            button68.Enabled = true;
        }

        private void button_dec_CheckedChanged(object sender, EventArgs e)
        {
            button_A.Enabled = false;
            button_B.Enabled = false;
            button_C.Enabled = false;
            button_D.Enabled = false;
            button_E.Enabled = false;
            button_F.Enabled = false;
            button76.Enabled = true;
            button75.Enabled = true;
            button74.Enabled = true;
            button73.Enabled = true;
            button72.Enabled = true;
            button71.Enabled = true;
            button69.Enabled = true;
            button68.Enabled = true;
        }

        private void button_oct_CheckedChanged(object sender, EventArgs e)
        {
            button_A.Enabled = false;
            button_B.Enabled = false;
            button_C.Enabled = false;
            button_D.Enabled = false;
            button_E.Enabled = false;
            button_F.Enabled = false;
            button76.Enabled = true;
            button75.Enabled = false;
            button74.Enabled = false;
            button73.Enabled = true;
            button72.Enabled = true;
            button71.Enabled = true;
            button69.Enabled = true;
            button68.Enabled = true;
        }

        private void button_bin_CheckedChanged(object sender, EventArgs e)
        {
            button_A.Enabled = false;
            button_B.Enabled = false;
            button_C.Enabled = false;
            button_D.Enabled = false;
            button_E.Enabled = false;
            button_F.Enabled = false;
            button76.Enabled = false;
            button75.Enabled = false;
            button74.Enabled = false;
            button73.Enabled = false;
            button72.Enabled = false;
            button71.Enabled = false;
            button69.Enabled = false;
            button68.Enabled = false;
        }

        private void conversiónDeUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conversiónDeUnidadesToolStripMenuItem.Checked == false)
            {
                MostrarCDU();
            }
            else
            {
                if (estándarToolStripMenuItem.Checked == true)
                {
                    OcultarCDU();
                    Size = new Size(298, 386);
                }
                else
                {
                    OcultarCDU();
                }
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.ForeColor = Color.DimGray;
                textBox3.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Italic);
                textBox3.Text = "Escribir valor";
                label2.Text = "";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Escribir valor")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                textBox3.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox3.Text;
        }
        private void textBox5_Click(object sender, EventArgs e)
        {
            panel1.Focus();
        }
        
        int operador;
        bool numero;
        double valor = 0;
        private void button62_Click(object sender, EventArgs e) //Cuando se presiona "+".
        {
            if(textBox5.Text == "Error matemático.")
            {
                textBox5.Text = "0";
            }

            if (numero == false)
            {
                textBox6.Text = valor + "+";
            }
            else
            {
                switch (operador)
                {
                    case 0:
                        valor = double.Parse(textBox5.Text);
                        break;
                    case 1:
                        valor += double.Parse(textBox5.Text);
                        break;
                    case 2:
                        valor -= double.Parse(textBox5.Text);
                        break;
                    case 3:
                        valor *= double.Parse(textBox5.Text);
                        break;
                    case 4:
                        break;
                }

                textBox6.Text = valor + "+";
                textBox5.Text = valor.ToString();
                operador = 1;
                operador_aux = 1;
                numero = false;
            }
        }
        private void button63_Click(object sender, EventArgs e) //Cuando se presiona "-".
        {
            if (textBox5.Text == "Error matemático.")
            {
                textBox5.Text = "0";
            }

            if (numero == false)
            {
                textBox6.Text = valor + "-";
            }
            else
            {
                switch (operador)
                {
                    case 0:
                        valor = double.Parse(textBox5.Text);
                        break;
                    case 1:
                        valor += double.Parse(textBox5.Text);
                        break;
                    case 2:
                        valor -= double.Parse(textBox5.Text);
                        break;
                    case 3:
                        valor *= double.Parse(textBox5.Text);
                        break;
                    case 4:
                        break;
                }

                textBox6.Text = valor + "-";
                textBox5.Text = valor.ToString();
                operador = 2;
                operador_aux = 2;
                numero = false;
            }
        }
        private void button64_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "Error matemático.")
            {
                textBox5.Text = "0";
            }

            if (numero == false)
            {
                textBox6.Text = valor + "*";
            }
            else
            {
                switch (operador)
                {
                    case 0:
                        valor = double.Parse(textBox5.Text);
                        break;
                    case 1:
                        valor += double.Parse(textBox5.Text);
                        break;
                    case 2:
                        valor -= double.Parse(textBox5.Text);
                        break;
                    case 3:
                        valor *= double.Parse(textBox5.Text);
                        break;
                    case 4:
                        break;
                }

                textBox6.Text = valor + "*";
                textBox5.Text = valor.ToString();
                operador = 3;
                operador_aux = 3;
                numero = false;
            }
        }//Cuando se presiona "*".
        private void button77_Click(object sender, EventArgs e) //Cuando se presiona "sqrt()".
        {
            if(double.Parse(textBox5.Text) < 0)
            {
                textBox5.Text = "Error matemático.";
                textBox6.Text = "";
                valor = 0;
                valor_aux = 0;
                operador = 0;
                operador_aux = 0;
                numero = false;
            }
            else
            {
                valor_aux = Math.Sqrt(double.Parse(textBox5.Text));

                switch (operador)
                {
                    case 0:
                        textBox6.Text = "sqrt(" + textBox5.Text + ")";
                        textBox5.Text = valor_aux.ToString();
                        valor = valor_aux;
                        break;
                    case 1:
                        textBox6.Text = valor + " + sqrt(" + textBox5.Text + ")";
                        textBox5.Text = valor_aux.ToString();
                        valor += valor_aux;
                        break;
                    case 2:
                        textBox6.Text = valor + " - sqrt(" + textBox5.Text + ")";
                        textBox5.Text = valor_aux.ToString();
                        valor -= valor_aux;
                        break;
                    case 3:
                        textBox6.Text = valor + " * sqrt(" + textBox5.Text + ")";
                        textBox5.Text = valor_aux.ToString();
                        valor *= valor_aux;
                        break;
                }

                operador = 4;
                numero = true;
            }
        }
        private void button67_Click(object sender, EventArgs e)
        {
            if (numero == false || textBox5.Text == "0" || textBox5.Text == "Error matemático.")
            {
                textBox5.Text = "0";
                numero = true;
            }
            else
            {
                textBox5.Text += "0";
            }
        }//Cuando se presiona "0".
        private void button70_Click(object sender, EventArgs e)
        {
            if (numero == false || textBox5.Text == "0" || textBox5.Text == "Error matemático.")
            {
                textBox5.Text = "1";
                numero = true;
            }
            else
            {
                textBox5.Text += "1";
            }
        }//Cuando se presiona "1".
        private void button69_Click(object sender, EventArgs e)
        {
            if (numero == false || textBox5.Text == "0" || textBox5.Text == "Error matemático.")
            {
                textBox5.Text = "2";
                numero = true;
            }
            else
            {
                textBox5.Text += "2";
            }
        }//Cuando se presiona "2".
        private void button68_Click(object sender, EventArgs e)
        {
            if (numero == false || textBox5.Text == "0" || textBox5.Text == "Error matemático.")
            {
                textBox5.Text = "3";
                numero = true;
            }
            else
            {
                textBox5.Text += "3";
            }
        }//Cuando se presiona "3".
        private void button73_Click(object sender, EventArgs e)
        {
            if (numero == false || textBox5.Text == "0" || textBox5.Text == "Error matemático.")
            {
                textBox5.Text = "4";
                numero = true;
            }
            else
            {
                textBox5.Text += "4";
            }
        }//Cuando se presiona "4".
        private void button72_Click(object sender, EventArgs e)
        {
            if (numero == false || textBox5.Text == "0" || textBox5.Text == "Error matemático.")
            {
                textBox5.Text = "5";
                numero = true;
            }
            else
            {
                textBox5.Text += "5";
            }
        }//Cuando se presiona "5".
        private void button71_Click(object sender, EventArgs e)
        {
            if (numero == false || textBox5.Text == "0" || textBox5.Text == "Error matemático.")
            {
                textBox5.Text = "6";
                numero = true;
            }
            else
            {
                textBox5.Text += "6";
            }
        }//Cuando se presiona "6".
        private void button76_Click(object sender, EventArgs e)
        {
            if (numero == false || textBox5.Text == "0" || textBox5.Text == "Error matemático.")
            {
                textBox5.Text = "7";
                numero = true;
            }
            else
            {
                textBox5.Text += "7";
            }
        }//Cuando se presiona "7".
        private void button75_Click(object sender, EventArgs e)
        {
            if (numero == false || textBox5.Text == "0" || textBox5.Text == "Error matemático.")
            {
                textBox5.Text = "8";
                numero = true;
            }
            else
            {
                textBox5.Text += "8";
            }
        }//Cuando se presiona "8".
        private void button74_Click(object sender, EventArgs e)
        {
            if (numero == false || textBox5.Text == "0" || textBox5.Text == "Error matemático.")
            {
                textBox5.Text = "9";
                numero = true;
            }
            else
            {
                textBox5.Text += "9";
            }
        }//Cuando se presiona "9".

        double valor_aux;
        int operador_aux;
        private void button59_Click(object sender, EventArgs e)
        {
            switch (operador)
            {
                case 0:
                    textBox6.Text = "";
                    switch (operador_aux)
                    {
                        case 0:
                            textBox6.Text = "";
                            valor = double.Parse(textBox5.Text);
                            break;
                        case 1:
                            textBox6.Text = "";
                            valor += valor_aux;
                            break;
                        case 2:
                            textBox6.Text = "";
                            valor -= valor_aux;
                            break;
                        case 3:
                            textBox6.Text = "";
                            valor *= valor_aux;
                            break;
                    }

                    textBox5.Text = valor.ToString();
                    break;
                case 1:
                    valor_aux = double.Parse(textBox5.Text);
                    operador_aux = 1;
                    textBox6.Text = "";
                    valor += double.Parse(textBox5.Text);
                    textBox5.Text = valor.ToString();
                    break;
                case 2:
                    valor_aux = double.Parse(textBox5.Text);
                    operador_aux = 2;
                    textBox6.Text = "";
                    valor -= double.Parse(textBox5.Text);
                    textBox5.Text = valor.ToString();
                    break;
                case 3:
                    valor_aux = double.Parse(textBox5.Text);
                    operador_aux = 3;
                    textBox6.Text = "";
                    valor *= double.Parse(textBox5.Text);
                    textBox5.Text = valor.ToString();
                    break;
                case 4:
                    valor_aux = double.Parse(textBox5.Text);
                    textBox6.Text = "";
                    textBox5.Text = valor.ToString();
                    break;
            }

            operador = 0;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            textBox5.Text = "0";
            textBox6.Text = "";
            operador = 0;
            numero = false;
            operador_aux = 0;
            valor_aux = 0;
        }

        private void button81_Click(object sender, EventArgs e)
        {
            textBox5.Text = textBox5.Text.Substring(0, textBox5.Text.Length - 1);

            if(textBox5.Text == "")
            {
                textBox5.Text = "0";
                numero = false;
            }
        }

        private void oscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            oscuroToolStripMenuItem.Checked = true;
            claroToolStripMenuItem.Checked = false;
            button81.BackColor = Color.FromArgb(70, 70, 70);
            button80.BackColor = Color.FromArgb(70, 70, 70);
            button79.BackColor = Color.FromArgb(70, 70, 70);
            button78.BackColor = Color.FromArgb(70, 70, 70);
            button77.BackColor = Color.FromArgb(70, 70, 70);
            button76.BackColor = Color.FromArgb(70, 70, 70);
            button75.BackColor = Color.FromArgb(70, 70, 70);
            button74.BackColor = Color.FromArgb(70, 70, 70);
            button73.BackColor = Color.FromArgb(70, 70, 70);
            button72.BackColor = Color.FromArgb(70, 70, 70);
            button71.BackColor = Color.FromArgb(70, 70, 70);
            button70.BackColor = Color.FromArgb(70, 70, 70);
            button69.BackColor = Color.FromArgb(70, 70, 70);
            button68.BackColor = Color.FromArgb(70, 70, 70);
            button67.BackColor = Color.FromArgb(70, 70, 70);
            button66.BackColor = Color.FromArgb(70, 70, 70);
            button65.BackColor = Color.FromArgb(70, 70, 70);
            button64.BackColor = Color.FromArgb(70, 70, 70);
            button63.BackColor = Color.FromArgb(70, 70, 70);
            button62.BackColor = Color.FromArgb(70, 70, 70);
            button61.BackColor = Color.FromArgb(70, 70, 70);
            button60.BackColor = Color.FromArgb(70, 70, 70);
            button59.BackColor = Color.FromArgb(70, 70, 70);
            button58.BackColor = Color.FromArgb(70,70,70);
            button57.BackColor = Color.FromArgb(70, 70, 70);
            button56.BackColor = Color.FromArgb(70, 70, 70);
            button55.BackColor = Color.FromArgb(70, 70, 70);
            button54.BackColor = Color.FromArgb(70, 70, 70);

            button53.BackColor = Color.FromArgb(70, 70, 70);
            button52.BackColor = Color.FromArgb(70, 70, 70);
            button51.BackColor = Color.FromArgb(70, 70, 70);
            button50.BackColor = Color.FromArgb(70, 70, 70);
            button49.BackColor = Color.FromArgb(70, 70, 70);
            button48.BackColor = Color.FromArgb(70, 70, 70);
            button47.BackColor = Color.FromArgb(70, 70, 70);
            button46.BackColor = Color.FromArgb(70, 70, 70);
            button45.BackColor = Color.FromArgb(70, 70, 70);
            button44.BackColor = Color.FromArgb(70, 70, 70);
            button43.BackColor = Color.FromArgb(70, 70, 70);
            button42.BackColor = Color.FromArgb(70, 70, 70);
            button41.BackColor = Color.FromArgb(70, 70, 70);
            button40.BackColor = Color.FromArgb(70, 70, 70);
            button39.BackColor = Color.FromArgb(70, 70, 70);
            button38.BackColor = Color.FromArgb(70, 70, 70);
            button37.BackColor = Color.FromArgb(70, 70, 70);
            button36.BackColor = Color.FromArgb(70, 70, 70);
            button35.BackColor = Color.FromArgb(70, 70, 70);
            button34.BackColor = Color.FromArgb(70, 70, 70);
            button33.BackColor = Color.FromArgb(70, 70, 70);
            button32.BackColor = Color.FromArgb(70, 70, 70);
            button31.BackColor = Color.FromArgb(70, 70, 70);
            button30.BackColor = Color.FromArgb(70, 70, 70);
            button29.BackColor = Color.FromArgb(70, 70, 70);
            button_nothing.BackColor = Color.FromArgb(70, 70, 70);
            button_mod.BackColor = Color.FromArgb(70, 70, 70);
            button_A.BackColor = Color.FromArgb(70, 70, 70);
            button_B.BackColor = Color.FromArgb(70, 70, 70);
            button_C.BackColor = Color.FromArgb(70, 70, 70);
            button_D.BackColor = Color.FromArgb(70, 70, 70);
            button_E.BackColor = Color.FromArgb(70, 70, 70);
            button_F.BackColor = Color.FromArgb(70, 70, 70);
            button_openParenthesis.BackColor = Color.FromArgb(70, 70, 70);
            button_closedParenthesis.BackColor = Color.FromArgb(70, 70, 70);
            button_rol.BackColor = Color.FromArgb(70, 70, 70);
            button_ror.BackColor = Color.FromArgb(70, 70, 70);
            button_or.BackColor = Color.FromArgb(70, 70, 70);
            button_xor.BackColor = Color.FromArgb(70, 70, 70);
            button_lsh.BackColor = Color.FromArgb(70, 70, 70);
            button_rsh.BackColor = Color.FromArgb(70, 70, 70);
            button_not.BackColor = Color.FromArgb(70, 70, 70);
            button_and.BackColor = Color.FromArgb(70, 70, 70);

            button81.ForeColor = Color.White;
            button80.ForeColor = Color.White;
            button79.ForeColor = Color.White;
            button78.ForeColor = Color.White;
            button77.ForeColor = Color.White;
            button76.ForeColor = Color.White;
            button75.ForeColor = Color.White;
            button74.ForeColor = Color.White;
            button73.ForeColor = Color.White;
            button72.ForeColor = Color.White;
            button71.ForeColor = Color.White;
            button70.ForeColor = Color.White;
            button69.ForeColor = Color.White;
            button68.ForeColor = Color.White;
            button67.ForeColor = Color.White;
            button66.ForeColor = Color.White;
            button65.ForeColor = Color.White;
            button64.ForeColor = Color.White;
            button63.ForeColor = Color.White;
            button62.ForeColor = Color.White;
            button61.ForeColor = Color.White;
            button60.ForeColor = Color.White;
            button59.ForeColor = Color.White;
            button58.ForeColor = Color.White;
            button57.ForeColor = Color.White;
            button56.ForeColor = Color.White;
            button55.ForeColor = Color.White;
            button54.ForeColor = Color.White;

            button53.ForeColor = Color.White;
            button52.ForeColor = Color.White;
            button51.ForeColor = Color.White;
            button50.ForeColor = Color.White;
            button49.ForeColor = Color.White;
            button48.ForeColor = Color.White;
            button47.ForeColor = Color.White;
            button46.ForeColor = Color.White;
            button45.ForeColor = Color.White;
            button44.ForeColor = Color.White;
            button43.ForeColor = Color.White;
            button42.ForeColor = Color.White;
            button41.ForeColor = Color.White;
            button40.ForeColor = Color.White;
            button39.ForeColor = Color.White;
            button38.ForeColor = Color.White;
            button37.ForeColor = Color.White;
            button36.ForeColor = Color.White;
            button35.ForeColor = Color.White;
            button34.ForeColor = Color.White;
            button33.ForeColor = Color.White;
            button32.ForeColor = Color.White;
            button31.ForeColor = Color.White;
            button30.ForeColor = Color.White;
            button29.ForeColor = Color.White;
            button_nothing.ForeColor = Color.White;
            button_mod.ForeColor = Color.White;
            button_A.ForeColor = Color.White;
            button_B.ForeColor = Color.White;
            button_C.ForeColor = Color.White;
            button_D.ForeColor = Color.White;
            button_E.ForeColor = Color.White;
            button_F.ForeColor = Color.White;
            button_openParenthesis.ForeColor = Color.White;
            button_closedParenthesis.ForeColor = Color.White;
            button_rol.ForeColor = Color.White;
            button_ror.ForeColor = Color.White;
            button_or.ForeColor = Color.White;
            button_xor.ForeColor = Color.White;
            button_lsh.ForeColor = Color.White;
            button_rsh.ForeColor = Color.White;
            button_not.ForeColor = Color.White;
            button_and.ForeColor = Color.White;
            radioButton1.ForeColor = Color.White;
            radioButton1.ForeColor = Color.White;
            radioButton2.ForeColor = Color.White;
            radioButton3.ForeColor = Color.White;
            button_hexa.ForeColor = Color.White;
            button_dec.ForeColor = Color.White;
            button_oct.ForeColor = Color.White;
            button_bin.ForeColor = Color.White;
            button_qword.ForeColor = Color.White;
            button_dword.ForeColor = Color.White;
            button_word.ForeColor = Color.White;
            button_byte.ForeColor = Color.White;

            panel1.BackColor = Color.Gray;
            textBox5.BackColor = Color.Gray;
            textBox5.ForeColor = Color.White;
            textBox6.BackColor = Color.Gray;
            textBox6.ForeColor = Color.FromArgb(64,64,64);

            panel_CDU.BackColor = Color.FromArgb(70, 70, 70);
            comboBox1.BackColor = Color.Gray;
            comboBox2.BackColor = Color.Gray;
            comboBox3.BackColor = Color.Gray;
            textBox1.BackColor = Color.FromArgb(70, 70, 70);
            textBox1.ForeColor = Color.FromArgb(30, 30, 30);
            textBox2.BackColor = Color.FromArgb(70, 70, 70);
            textBox2.ForeColor = Color.FromArgb(30, 30, 30);
            textBox4.BackColor = Color.FromArgb(70, 70, 70);
            textBox4.ForeColor = Color.FromArgb(30, 30, 30);
        }

        private void claroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
            oscuroToolStripMenuItem.Checked = false;
            claroToolStripMenuItem.Checked = true;
            button81.BackColor = Color.White;
            button80.BackColor = Color.White;
            button79.BackColor = Color.White;
            button78.BackColor = Color.White;
            button77.BackColor = Color.White;
            button76.BackColor = Color.White;
            button75.BackColor = Color.White;
            button74.BackColor = Color.White;
            button73.BackColor = Color.White;
            button72.BackColor = Color.White;
            button71.BackColor = Color.White;
            button70.BackColor = Color.White;
            button69.BackColor = Color.White;
            button68.BackColor = Color.White;
            button67.BackColor = Color.White;
            button66.BackColor = Color.White;
            button65.BackColor = Color.White;
            button64.BackColor = Color.White;
            button63.BackColor = Color.White;
            button62.BackColor = Color.White;
            button61.BackColor = Color.White;
            button60.BackColor = Color.White;
            button59.BackColor = Color.White;
            button58.BackColor = Color.White;
            button57.BackColor = Color.White;
            button56.BackColor = Color.White;
            button55.BackColor = Color.White;
            button54.BackColor = Color.White;

            button53.BackColor = Color.White;
            button52.BackColor = Color.White;
            button51.BackColor = Color.White;
            button50.BackColor = Color.White;
            button49.BackColor = Color.White;
            button48.BackColor = Color.White;
            button47.BackColor = Color.White;
            button46.BackColor = Color.White;
            button45.BackColor = Color.White;
            button44.BackColor = Color.White;
            button43.BackColor = Color.White;
            button42.BackColor = Color.White;
            button41.BackColor = Color.White;
            button40.BackColor = Color.White;
            button39.BackColor = Color.White;
            button38.BackColor = Color.White;
            button37.BackColor = Color.White;
            button36.BackColor = Color.White;
            button35.BackColor = Color.White;
            button34.BackColor = Color.White;
            button33.BackColor = Color.White;
            button32.BackColor = Color.White;
            button31.BackColor = Color.White;
            button30.BackColor = Color.White;
            button29.BackColor = Color.White;
            button_nothing.BackColor = Color.White;
            button_mod.BackColor = Color.White;
            button_A.BackColor = Color.White;
            button_B.BackColor = Color.White;
            button_C.BackColor = Color.White;
            button_D.BackColor = Color.White;
            button_E.BackColor = Color.White;
            button_F.BackColor = Color.White;
            button_openParenthesis.BackColor = Color.White;
            button_closedParenthesis.BackColor = Color.White;
            button_rol.BackColor = Color.White;
            button_ror.BackColor = Color.White;
            button_or.BackColor = Color.White;
            button_xor.BackColor = Color.White;
            button_lsh.BackColor = Color.White;
            button_rsh.BackColor = Color.White;
            button_not.BackColor = Color.White;
            button_and.BackColor = Color.White;

            button81.ForeColor = Color.Black;
            button80.ForeColor = Color.Black;
            button79.ForeColor = Color.Black;
            button78.ForeColor = Color.Black;
            button77.ForeColor = Color.Black;
            button76.ForeColor = Color.Black;
            button75.ForeColor = Color.Black;
            button74.ForeColor = Color.Black;
            button73.ForeColor = Color.Black;
            button72.ForeColor = Color.Black;
            button71.ForeColor = Color.Black;
            button70.ForeColor = Color.Black;
            button69.ForeColor = Color.Black;
            button68.ForeColor = Color.Black;
            button67.ForeColor = Color.Black;
            button66.ForeColor = Color.Black;
            button65.ForeColor = Color.Black;
            button64.ForeColor = Color.Black;
            button63.ForeColor = Color.Black;
            button62.ForeColor = Color.Black;
            button61.ForeColor = Color.Black;
            button60.ForeColor = Color.Black;
            button59.ForeColor = Color.Black;
            button58.ForeColor = Color.Black;
            button57.ForeColor = Color.Black;
            button56.ForeColor = Color.Black;
            button55.ForeColor = Color.Black;
            button54.ForeColor = Color.Black;

            button53.ForeColor = Color.Black;
            button52.ForeColor = Color.Black;
            button51.ForeColor = Color.Black;
            button50.ForeColor = Color.Black;
            button49.ForeColor = Color.Black;
            button48.ForeColor = Color.Black;
            button47.ForeColor = Color.Black;
            button46.ForeColor = Color.Black;
            button45.ForeColor = Color.Black;
            button44.ForeColor = Color.Black;
            button43.ForeColor = Color.Black;
            button42.ForeColor = Color.Black;
            button41.ForeColor = Color.Black;
            button40.ForeColor = Color.Black;
            button39.ForeColor = Color.Black;
            button38.ForeColor = Color.Black;
            button37.ForeColor = Color.Black;
            button36.ForeColor = Color.Black;
            button35.ForeColor = Color.Black;
            button34.ForeColor = Color.Black;
            button33.ForeColor = Color.Black;
            button32.ForeColor = Color.Black;
            button31.ForeColor = Color.Black;
            button30.ForeColor = Color.Black;
            button29.ForeColor = Color.Black;
            button_nothing.ForeColor = Color.Black;
            button_mod.ForeColor = Color.Black;
            button_A.ForeColor = Color.Black;
            button_B.ForeColor = Color.Black;
            button_C.ForeColor = Color.Black;
            button_D.ForeColor = Color.Black;
            button_E.ForeColor = Color.Black;
            button_F.ForeColor = Color.Black;
            button_openParenthesis.ForeColor = Color.Black;
            button_closedParenthesis.ForeColor = Color.Black;
            button_rol.ForeColor = Color.Black;
            button_ror.ForeColor = Color.Black;
            button_or.ForeColor = Color.Black;
            button_xor.ForeColor = Color.Black;
            button_lsh.ForeColor = Color.Black;
            button_rsh.ForeColor = Color.Black;
            button_not.ForeColor = Color.Black;
            button_and.ForeColor = Color.Black;
            radioButton1.ForeColor = Color.Black;
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Black;
            radioButton3.ForeColor = Color.Black;
            button_hexa.ForeColor = Color.Black;
            button_dec.ForeColor = Color.Black;
            button_oct.ForeColor = Color.Black;
            button_bin.ForeColor = Color.Black;
            button_qword.ForeColor = Color.Black;
            button_dword.ForeColor = Color.Black;
            button_word.ForeColor = Color.Black;
            button_byte.ForeColor = Color.Black;

            panel1.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox5.ForeColor = Color.Black;
            textBox6.BackColor = Color.White;
            textBox6.ForeColor = Color.Gray;

            panel_CDU.BackColor = Color.White;
            comboBox1.BackColor = Color.White;
            comboBox2.BackColor = Color.White;
            comboBox3.BackColor = Color.White;
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.DarkSlateGray;
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.DarkSlateGray;
            textBox4.BackColor = Color.White;
            textBox4.ForeColor = Color.DarkSlateGray;
        }
    }
}
