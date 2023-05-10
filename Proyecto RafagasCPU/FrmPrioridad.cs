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
    public partial class FrmPrioridad : Form
    {
        VARIABLES Global = new VARIABLES(); 
       
        public FrmPrioridad()
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
            validaPriori1();
            validaPriori2();
            validaPriori3();
            validaPriori4();
            validaPriori5();
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

        private bool validaPriori1()
        {
            bool ok = true;
            if (txt_priori1.Text == "")
            {
                errorProvider1.SetError(txt_priori1, "  Ingresa algo");
            }

            return ok;
        }
        private bool validaPriori2()
        {
            bool ok = true;
            if (txt_priori2.Text == "")
            {
                errorProvider1.SetError(txt_priori2, "  Ingresa algo");
            }

            return ok;
        }
        private bool validaPriori3()
        {
            bool ok = true;
            if (txt_priori3.Text == "")
            {
                errorProvider1.SetError(txt_priori3, "  Ingresa algo");
            }

            return ok;
        }
        private bool validaPriori4()
        {
            bool ok = true;
            if (txt_priori4.Text == "")
            {
                errorProvider1.SetError(txt_priori4, "  Ingresa algo");
            }

            return ok;
        }
        private bool validaPriori5()
        {
            bool ok = true;
            if (txt_priori5.Text == "")
            {
                errorProvider1.SetError(txt_priori5, "  Ingresa algo");
            }
            else
            {
                Global.p1 = Convert.ToInt32(txt_priori1.Text);
                Global.p2 = Convert.ToInt32(txt_priori2.Text);
                Global.p3 = Convert.ToInt32(txt_priori3.Text);
                Global.p4 = Convert.ToInt32(txt_priori4.Text);
                Global.p5 = Convert.ToInt32(txt_priori5.Text);

                Global.cpu[0] = Convert.ToInt32(txt_p1.Text);
                Global.cpu[1] = Convert.ToInt32(txt_p2.Text);
                Global.cpu[2] = Convert.ToInt32(txt_p3.Text);
                Global.cpu[3] = Convert.ToInt32(txt_p4.Text);
                Global.cpu[4] = Convert.ToInt32(txt_p5.Text);
                grup_resultado.Visible = true;

                List<Procesos> L = new List<Procesos>();


                L.Add(new Procesos(Global.p1, 1, Global.cpu[0]));
                L.Add(new Procesos(Global.p2, 2, Global.cpu[1]));
                L.Add(new Procesos(Global.p3, 3, Global.cpu[2]));
                L.Add(new Procesos(Global.p4, 4, Global.cpu[3]));
                L.Add(new Procesos(Global.p5, 5, Global.cpu[4]));


                List<Procesos> Lordenado = L.OrderBy(o => o._Prioridad).ToList();


                Global.retorno[0] = Lordenado[0]._Rafaga;
                Global.retorno[1] = Lordenado[0]._Rafaga + Lordenado[1]._Rafaga;
                Global.retorno[2] = Lordenado[0]._Rafaga + Lordenado[1]._Rafaga + Lordenado[2]._Rafaga;
                Global.retorno[3] = Lordenado[0]._Rafaga + Lordenado[1]._Rafaga + Lordenado[2]._Rafaga + Lordenado[3]._Rafaga;
                Global.retorno[4] = Lordenado[0]._Rafaga + Lordenado[1]._Rafaga + Lordenado[2]._Rafaga + Lordenado[3]._Rafaga + Lordenado[4]._Rafaga;

                Global.espera[0] = 0;
                Global.espera[1] = Global.retorno[0];
                Global.espera[2] = Global.retorno[1];
                Global.espera[3] = Global.retorno[2];
                Global.espera[4] = Global.retorno[3];

                lbl_p1.Text = Convert.ToString("P" + Lordenado[0]._Proceso);
                lbl_p2.Text = Convert.ToString("P" + Lordenado[1]._Proceso);
                lbl_p3.Text = Convert.ToString("P" + Lordenado[2]._Proceso);
                lbl_p4.Text = Convert.ToString("P" + Lordenado[3]._Proceso);
                lbl_p5.Text = Convert.ToString("P" + Lordenado[4]._Proceso);


                double tme = 0;
                double tmr = 0;
                for (int i = 0; i < Global.espera.Length; i++)
                {
                    tme += Global.espera[i];
                    tmr += Global.retorno[i];
                }
                tme = tme / 5;
                tmr = tmr / 5;

                lbl_retorno1.Text = Convert.ToString(Global.retorno[0]);
                lbl_retorno2.Text = Convert.ToString(Global.retorno[1]);
                lbl_retorno3.Text = Convert.ToString(Global.retorno[2]);
                lbl_retorno4.Text = Convert.ToString(Global.retorno[3]);
                lbl_retorno5.Text = Convert.ToString(Global.retorno[4]);

                lbl_espera1.Text = Convert.ToString(Global.espera[0]);
                lbl_espera2.Text = Convert.ToString(Global.espera[1]);
                lbl_espera3.Text = Convert.ToString(Global.espera[2]);
                lbl_espera4.Text = Convert.ToString(Global.espera[3]);
                lbl_espera5.Text = Convert.ToString(Global.espera[4]);

                lbl_tme.Text = Convert.ToString(tme);
                lbl_tmr.Text = Convert.ToString(tmr);
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

        private void txt_priori1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_priori1, "pone numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

        private void txt_priori2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_priori2, "pone numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

        private void txt_priori3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_priori3, "pone numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

        private void txt_priori4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_priori4, "pone numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

        private void txt_priori5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_priori5, "pone numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();
        }

    }
    public class Procesos
    {
        public Procesos(int prioridad, int proceso, int rafaga)
        {
            _Rafaga = rafaga;
            _Prioridad = prioridad;
            _Proceso = proceso;
        }
        public int _Rafaga;
        public int _Prioridad;
        public int _Proceso;
    }

}
