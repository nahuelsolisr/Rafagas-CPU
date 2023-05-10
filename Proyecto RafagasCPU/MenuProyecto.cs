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
    public partial class MenuProyecto : Form
    {
        public MenuProyecto()
        {
            InitializeComponent();
        }

        private Form formActivo = null;

        private void FormHijo(Form FormHijo)
        {
            if (formActivo != null) formActivo.Close();
            formActivo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            panel_contenedor.Controls.Add(FormHijo);
            panel_contenedor.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();

        }
        private void btn_fcfs_Click(object sender, EventArgs e)
        {
            FormHijo(new FrmFCFS());
            btn_fcfs.BackColor = Color.FromArgb(0, 64, 64);
            btn_sjf.BackColor = Color.Teal;
            btn_priori.BackColor = Color.Teal;
            btn_rrq.BackColor = Color.Teal;
        }

        private void btn_sjf_Click(object sender, EventArgs e)
        {
            FormHijo(new FrmSJF());
            btn_sjf.BackColor = Color.FromArgb(0, 64, 64);
            btn_fcfs.BackColor = Color.Teal;
            btn_priori.BackColor = Color.Teal;
            btn_rrq.BackColor = Color.Teal;
        }

        private void btn_priori_Click(object sender, EventArgs e)
        {
            FormHijo(new FrmPrioridad());
            btn_priori.BackColor = Color.FromArgb(0, 64, 64);
            btn_fcfs.BackColor = Color.Teal;
            btn_sjf.BackColor = Color.Teal;
            btn_rrq.BackColor = Color.Teal;
        }

        private void btn_rrq_Click(object sender, EventArgs e)
        {
            FormHijo(new FrmRRQ());
            btn_rrq.BackColor = Color.FromArgb(0, 64, 64);
            btn_fcfs.BackColor = Color.Teal;
            btn_sjf.BackColor = Color.Teal;
            btn_priori.BackColor = Color.Teal;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
