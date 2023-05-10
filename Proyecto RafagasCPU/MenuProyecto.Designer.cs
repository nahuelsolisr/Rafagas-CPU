namespace Proyecto_RafagasCPU
{
    partial class MenuProyecto
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_botones = new System.Windows.Forms.Panel();
            this.btn_rrq = new System.Windows.Forms.Button();
            this.btn_sjf = new System.Windows.Forms.Button();
            this.btn_priori = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_fcfs = new System.Windows.Forms.Button();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.panel_botones.SuspendLayout();
            this.panel_contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_top.Controls.Add(this.label6);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(785, 59);
            this.panel_top.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 33);
            this.label6.TabIndex = 31;
            this.label6.Text = "PROGRAMA: RÁFAGAS DE CPU V1.1";
            // 
            // panel_botones
            // 
            this.panel_botones.BackColor = System.Drawing.Color.Teal;
            this.panel_botones.Controls.Add(this.btn_rrq);
            this.panel_botones.Controls.Add(this.btn_sjf);
            this.panel_botones.Controls.Add(this.btn_priori);
            this.panel_botones.Controls.Add(this.btn_salir);
            this.panel_botones.Controls.Add(this.btn_fcfs);
            this.panel_botones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_botones.Location = new System.Drawing.Point(0, 59);
            this.panel_botones.Name = "panel_botones";
            this.panel_botones.Size = new System.Drawing.Size(168, 413);
            this.panel_botones.TabIndex = 1;
            // 
            // btn_rrq
            // 
            this.btn_rrq.FlatAppearance.BorderSize = 0;
            this.btn_rrq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rrq.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_rrq.ForeColor = System.Drawing.Color.Transparent;
            this.btn_rrq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rrq.Location = new System.Drawing.Point(3, 246);
            this.btn_rrq.Name = "btn_rrq";
            this.btn_rrq.Size = new System.Drawing.Size(162, 73);
            this.btn_rrq.TabIndex = 4;
            this.btn_rrq.Text = "ROUND ROBIN";
            this.btn_rrq.UseVisualStyleBackColor = true;
            this.btn_rrq.Click += new System.EventHandler(this.btn_rrq_Click);
            // 
            // btn_sjf
            // 
            this.btn_sjf.FlatAppearance.BorderSize = 0;
            this.btn_sjf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sjf.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_sjf.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sjf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sjf.Location = new System.Drawing.Point(4, 82);
            this.btn_sjf.Name = "btn_sjf";
            this.btn_sjf.Size = new System.Drawing.Size(162, 73);
            this.btn_sjf.TabIndex = 2;
            this.btn_sjf.Text = "SJF";
            this.btn_sjf.UseVisualStyleBackColor = true;
            this.btn_sjf.Click += new System.EventHandler(this.btn_sjf_Click);
            // 
            // btn_priori
            // 
            this.btn_priori.FlatAppearance.BorderSize = 0;
            this.btn_priori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_priori.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_priori.ForeColor = System.Drawing.Color.Transparent;
            this.btn_priori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_priori.Location = new System.Drawing.Point(3, 164);
            this.btn_priori.Name = "btn_priori";
            this.btn_priori.Size = new System.Drawing.Size(162, 73);
            this.btn_priori.TabIndex = 3;
            this.btn_priori.Text = "PRIORIDAD";
            this.btn_priori.UseVisualStyleBackColor = true;
            this.btn_priori.Click += new System.EventHandler(this.btn_priori_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_salir.ForeColor = System.Drawing.Color.Transparent;
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.Location = new System.Drawing.Point(3, 366);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(162, 44);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_fcfs
            // 
            this.btn_fcfs.FlatAppearance.BorderSize = 0;
            this.btn_fcfs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fcfs.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.btn_fcfs.ForeColor = System.Drawing.Color.Transparent;
            this.btn_fcfs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fcfs.Location = new System.Drawing.Point(3, 3);
            this.btn_fcfs.Name = "btn_fcfs";
            this.btn_fcfs.Size = new System.Drawing.Size(162, 73);
            this.btn_fcfs.TabIndex = 1;
            this.btn_fcfs.Text = "FIFO\r\n";
            this.btn_fcfs.UseVisualStyleBackColor = true;
            this.btn_fcfs.Click += new System.EventHandler(this.btn_fcfs_Click);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.PowderBlue;
            this.panel_contenedor.Controls.Add(this.label2);
            this.panel_contenedor.Controls.Add(this.label1);
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(168, 59);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(617, 413);
            this.panel_contenedor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 33);
            this.label2.TabIndex = 33;
            this.label2.Text = "¡HOLA!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 66);
            this.label1.TabIndex = 32;
            this.label1.Text = "SELECCIONE UN TIPO DE ALGORITMO\r\n⬅️";
            // 
            // MenuProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 472);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panel_botones);
            this.Controls.Add(this.panel_top);
            this.Name = "MenuProyecto";
            this.Text = "Menu";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_botones.ResumeLayout(false);
            this.panel_contenedor.ResumeLayout(false);
            this.panel_contenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_botones;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_rrq;
        private System.Windows.Forms.Button btn_priori;
        private System.Windows.Forms.Button btn_sjf;
        private System.Windows.Forms.Button btn_fcfs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

