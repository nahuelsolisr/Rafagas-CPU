using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_RafagasCPU
{
    public partial class FrmRRQ : Form
    {
        VARIABLES Global = new VARIABLES(); 

        public FrmRRQ()
        {
            InitializeComponent();
        }

        private void btn_realizar_Click(object sender, EventArgs e)
        {
            //LLAMO A LOS METODOS 
            validarp1();
            validarp2();
            validarp3();
            validarp4();
            validarp5();
            quantum();
        }

        //METODOS DE VALIDACION ESPACIOS EN BLANCO 
        private bool validarp1()
        {
            bool ok = true;
            if (txt_p1.Text == "")
            {
                errorProvider1.SetError(txt_p1, "  Ingresa algo");
            }

            return ok;
        }
        private bool validarp2()
        {
            bool ok = true;
            if (txt_p2.Text == "")
            {
                errorProvider1.SetError(txt_p2, "  Ingresa algo");
            }

            return ok;
        }
        private bool validarp3()
        {
            bool ok = true;
            if (txt_p3.Text == "")
            {
                errorProvider1.SetError(txt_p3, "  Ingresa algo");
            }

            return ok;
        }
        private bool validarp4()
        {
            bool ok = true;
            if (txt_p4.Text == "")
            {
                errorProvider1.SetError(txt_p4, "  Ingresa algo");
            }

            return ok;
        }
        private bool validarp5()
        {
            bool ok = true;
            if (txt_p5.Text == "")
            {
                errorProvider1.SetError(txt_p5, "  Ingresa algo");
            }
           

            return ok;
        }
        private bool quantum()
        {
            bool ok = true;
            if (txt_quantum.Text == "")
            {
                errorProvider1.SetError(txt_quantum, "  Ingresa algo");
            }
            else
            {
                Global.Q = Convert.ToInt32(txt_quantum.Text);

                Global.cpu[0] = Convert.ToInt32(txt_p1.Text);
                Global.cpu[1] = Convert.ToInt32(txt_p2.Text);
                Global.cpu[2] = Convert.ToInt32(txt_p3.Text);
                Global.cpu[3] = Convert.ToInt32(txt_p4.Text);
                Global.cpu[4] = Convert.ToInt32(txt_p5.Text);

                int contador = 0;
                bool fin = false;

                int total = Global.cpu[0] + Global.cpu[1] + Global.cpu[2] + Global.cpu[3] + Global.cpu[4];

                while (!fin)
                {

                    for (int i = 0; i < Global.cpu.Length; i++)
                    {
                        if (Global.cpu[0] > 0 || Global.cpu[1] > 0 || Global.cpu[2] > 0 || Global.cpu[3] > 0 || Global.cpu[4] > 0)
                        {
                            if (Global.cpu[i] > Global.Q)
                            {
                                Global.cpu[i] = Global.cpu[i] - Global.Q;
                                contador += Global.Q;
                                Global.retorno[i] = contador;

                            }

                            else
                            {
                                if (Global.cpu[i] != 0)
                                {
                                    contador += Global.cpu[i];
                                    Global.retorno[i] = contador;
                                    Global.cpu[i] = 0;
                                }


                            }

                        }
                        else
                        {
                            fin = true;
                            break;
                        }

                    }
                }

                grup_resultado.Visible = true;

                lbl_retorno1.Text = Convert.ToString(Global.retorno[0]);
                lbl_retorno2.Text = Convert.ToString(Global.retorno[1]);
                lbl_retorno3.Text = Convert.ToString(Global.retorno[2]);
                lbl_retorno4.Text = Convert.ToString(Global.retorno[3]);
                lbl_retorno5.Text = Convert.ToString(Global.retorno[4]);

                Global.espera[0] = Convert.ToInt32(Global.retorno[0] - Convert.ToInt32(txt_p1.Text));
                Global.espera[1] = Convert.ToInt32(Global.retorno[1] - Convert.ToInt32(txt_p2.Text));
                Global.espera[2] = Convert.ToInt32(Global.retorno[2] - Convert.ToInt32(txt_p3.Text));
                Global.espera[3] = Convert.ToInt32(Global.retorno[3] - Convert.ToInt32(txt_p4.Text));
                Global.espera[4] = Convert.ToInt32(Global.retorno[4] - Convert.ToInt32(txt_p5.Text));

                lbl_espera1.Text = Convert.ToString(Global.espera[0]);
                lbl_espera2.Text = Convert.ToString(Global.espera[1]);
                lbl_espera3.Text = Convert.ToString(Global.espera[2]);
                lbl_espera4.Text = Convert.ToString(Global.espera[3]);
                lbl_espera5.Text = Convert.ToString(Global.espera[4]);

                double tme = 0;
                double tmr = 0;

                for (int i = 0; i < Global.espera.Length; i++)
                {
                    tme += Global.espera[i];
                    tmr += Global.retorno[i];
                }

                tme = tme / 5;
                tmr = tmr / 5;


                lbl_tme.Text = Convert.ToString(tme);
                lbl_tmr.Text = Convert.ToString(tmr);


                grup_resultado.Visible = true;
            }

            return ok;
        }



        //EVENTO KEY PRESS VALIDACION
        private void txt_p1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_p1, "pone numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

        private void txt_p2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_p2, "pone numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

        private void txt_p3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_p3, "pone numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

        private void txt_p4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_p4, "pone numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

        private void txt_p5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_p5, "pone numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

        private void txt_quantum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_quantum, "pone numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }


    }
}
