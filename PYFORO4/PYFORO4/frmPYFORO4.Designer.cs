namespace PYFORO4
{
    partial class frmPYFORO4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstCursos = new System.Windows.Forms.ListView();
            this.btnbuscarCurso = new System.Windows.Forms.Button();
            this.txtbuscarcodigoCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnagregarCurso = new System.Windows.Forms.Button();
            this.txtcreditosCurso = new System.Windows.Forms.TextBox();
            this.txtnombreCurso = new System.Windows.Forms.TextBox();
            this.txtcodigoCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstDocentes = new System.Windows.Forms.ListView();
            this.btnbuscarDocente = new System.Windows.Forms.Button();
            this.txtbuscarCodigoDocente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnagregarDocente = new System.Windows.Forms.Button();
            this.txtedadDocente = new System.Windows.Forms.TextBox();
            this.txtnombreDocente = new System.Windows.Forms.TextBox();
            this.txtcodigoDocente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(546, 383);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GreenYellow;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lstCursos);
            this.tabPage1.Controls.Add(this.btnbuscarCurso);
            this.tabPage1.Controls.Add(this.txtbuscarcodigoCurso);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnagregarCurso);
            this.tabPage1.Controls.Add(this.txtcreditosCurso);
            this.tabPage1.Controls.Add(this.txtnombreCurso);
            this.tabPage1.Controls.Add(this.txtcodigoCurso);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(538, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cursos";
            // 
            // lstCursos
            // 
            this.lstCursos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstCursos.Location = new System.Drawing.Point(295, 6);
            this.lstCursos.Name = "lstCursos";
            this.lstCursos.Size = new System.Drawing.Size(240, 261);
            this.lstCursos.TabIndex = 10;
            this.lstCursos.UseCompatibleStateImageBehavior = false;
            // 
            // btnbuscarCurso
            // 
            this.btnbuscarCurso.Location = new System.Drawing.Point(154, 220);
            this.btnbuscarCurso.Name = "btnbuscarCurso";
            this.btnbuscarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarCurso.TabIndex = 9;
            this.btnbuscarCurso.Text = "buscar";
            this.btnbuscarCurso.UseVisualStyleBackColor = true;
            this.btnbuscarCurso.Click += new System.EventHandler(this.btnbuscarCurso_Click_1);
            // 
            // txtbuscarcodigoCurso
            // 
            this.txtbuscarcodigoCurso.Location = new System.Drawing.Point(138, 172);
            this.txtbuscarcodigoCurso.Name = "txtbuscarcodigoCurso";
            this.txtbuscarcodigoCurso.Size = new System.Drawing.Size(100, 20);
            this.txtbuscarcodigoCurso.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "buscar codigo";
            // 
            // btnagregarCurso
            // 
            this.btnagregarCurso.Location = new System.Drawing.Point(154, 132);
            this.btnagregarCurso.Name = "btnagregarCurso";
            this.btnagregarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnagregarCurso.TabIndex = 6;
            this.btnagregarCurso.Text = "Agregar";
            this.btnagregarCurso.UseVisualStyleBackColor = true;
            this.btnagregarCurso.Click += new System.EventHandler(this.btnagregarCurso_Click_1);
            // 
            // txtcreditosCurso
            // 
            this.txtcreditosCurso.Location = new System.Drawing.Point(138, 98);
            this.txtcreditosCurso.Name = "txtcreditosCurso";
            this.txtcreditosCurso.Size = new System.Drawing.Size(100, 20);
            this.txtcreditosCurso.TabIndex = 5;
            // 
            // txtnombreCurso
            // 
            this.txtnombreCurso.Location = new System.Drawing.Point(138, 60);
            this.txtnombreCurso.Name = "txtnombreCurso";
            this.txtnombreCurso.Size = new System.Drawing.Size(100, 20);
            this.txtnombreCurso.TabIndex = 4;
            // 
            // txtcodigoCurso
            // 
            this.txtcodigoCurso.Location = new System.Drawing.Point(138, 24);
            this.txtcodigoCurso.Name = "txtcodigoCurso";
            this.txtcodigoCurso.Size = new System.Drawing.Size(100, 20);
            this.txtcodigoCurso.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "creditos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nombre curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "codigo Curso";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Orange;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.lstDocentes);
            this.tabPage2.Controls.Add(this.btnbuscarDocente);
            this.tabPage2.Controls.Add(this.txtbuscarCodigoDocente);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnagregarDocente);
            this.tabPage2.Controls.Add(this.txtedadDocente);
            this.tabPage2.Controls.Add(this.txtnombreDocente);
            this.tabPage2.Controls.Add(this.txtcodigoDocente);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(538, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Docentes";
            // 
            // lstDocentes
            // 
            this.lstDocentes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstDocentes.Location = new System.Drawing.Point(290, 27);
            this.lstDocentes.Name = "lstDocentes";
            this.lstDocentes.Size = new System.Drawing.Size(242, 279);
            this.lstDocentes.TabIndex = 21;
            this.lstDocentes.UseCompatibleStateImageBehavior = false;
            // 
            // btnbuscarDocente
            // 
            this.btnbuscarDocente.Location = new System.Drawing.Point(133, 219);
            this.btnbuscarDocente.Name = "btnbuscarDocente";
            this.btnbuscarDocente.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarDocente.TabIndex = 20;
            this.btnbuscarDocente.Text = "buscar";
            this.btnbuscarDocente.UseVisualStyleBackColor = true;
            this.btnbuscarDocente.Click += new System.EventHandler(this.btnbuscarDocente_Click_1);
            // 
            // txtbuscarCodigoDocente
            // 
            this.txtbuscarCodigoDocente.Location = new System.Drawing.Point(153, 168);
            this.txtbuscarCodigoDocente.Name = "txtbuscarCodigoDocente";
            this.txtbuscarCodigoDocente.Size = new System.Drawing.Size(100, 20);
            this.txtbuscarCodigoDocente.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "buscar codigo";
            // 
            // btnagregarDocente
            // 
            this.btnagregarDocente.Location = new System.Drawing.Point(169, 128);
            this.btnagregarDocente.Name = "btnagregarDocente";
            this.btnagregarDocente.Size = new System.Drawing.Size(75, 23);
            this.btnagregarDocente.TabIndex = 17;
            this.btnagregarDocente.Text = "Agregar";
            this.btnagregarDocente.UseVisualStyleBackColor = true;
            this.btnagregarDocente.Click += new System.EventHandler(this.btnagregarDocente_Click_1);
            // 
            // txtedadDocente
            // 
            this.txtedadDocente.Location = new System.Drawing.Point(153, 94);
            this.txtedadDocente.Name = "txtedadDocente";
            this.txtedadDocente.Size = new System.Drawing.Size(100, 20);
            this.txtedadDocente.TabIndex = 16;
            // 
            // txtnombreDocente
            // 
            this.txtnombreDocente.Location = new System.Drawing.Point(153, 56);
            this.txtnombreDocente.Name = "txtnombreDocente";
            this.txtnombreDocente.Size = new System.Drawing.Size(100, 20);
            this.txtnombreDocente.TabIndex = 15;
            // 
            // txtcodigoDocente
            // 
            this.txtcodigoDocente.Location = new System.Drawing.Point(153, 20);
            this.txtcodigoDocente.Name = "txtcodigoDocente";
            this.txtcodigoDocente.Size = new System.Drawing.Size(100, 20);
            this.txtcodigoDocente.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "edad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "nombre docente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "codigo docente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPYFORO4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 383);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPYFORO4";
            this.Text = "frmPYFORO4";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnagregarCurso;
        private System.Windows.Forms.TextBox txtcreditosCurso;
        private System.Windows.Forms.TextBox txtnombreCurso;
        private System.Windows.Forms.TextBox txtcodigoCurso;
        private System.Windows.Forms.ListView lstCursos;
        private System.Windows.Forms.Button btnbuscarCurso;
        private System.Windows.Forms.TextBox txtbuscarcodigoCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstDocentes;
        private System.Windows.Forms.Button btnbuscarDocente;
        private System.Windows.Forms.TextBox txtbuscarCodigoDocente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnagregarDocente;
        private System.Windows.Forms.TextBox txtedadDocente;
        private System.Windows.Forms.TextBox txtnombreDocente;
        private System.Windows.Forms.TextBox txtcodigoDocente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}