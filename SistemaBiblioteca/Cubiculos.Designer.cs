namespace SistemaBiblioteca
{
    partial class Cubículos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cubículos));
            this.label1 = new System.Windows.Forms.Label();
            this.dgCubiculos = new System.Windows.Forms.DataGridView();
            this.Cédula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beneficiarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cubículo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_encargado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextCedula = new System.Windows.Forms.TextBox();
            this.textFinalidad = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.MonthCalendar();
            this.CB_beneficiarios = new System.Windows.Forms.ComboBox();
            this.CB_cubiculo = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblHoy = new System.Windows.Forms.Label();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.rbFechaActual = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgCubiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cubículos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgCubiculos
            // 
            this.dgCubiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCubiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cédula,
            this.Nombre,
            this.Apellido,
            this.HoraInicio,
            this.Beneficiarios,
            this.Cubículo,
            this.Finalidad,
            this.Encargado});
            this.dgCubiculos.Location = new System.Drawing.Point(45, 299);
            this.dgCubiculos.Name = "dgCubiculos";
            this.dgCubiculos.ReadOnly = true;
            this.dgCubiculos.Size = new System.Drawing.Size(846, 337);
            this.dgCubiculos.TabIndex = 4;
            // 
            // Cédula
            // 
            this.Cédula.HeaderText = "Cédula";
            this.Cédula.Name = "Cédula";
            this.Cédula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inico";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            // 
            // Beneficiarios
            // 
            this.Beneficiarios.HeaderText = "Beneficiarios";
            this.Beneficiarios.Name = "Beneficiarios";
            this.Beneficiarios.ReadOnly = true;
            // 
            // Cubículo
            // 
            this.Cubículo.HeaderText = "Cubículo";
            this.Cubículo.Name = "Cubículo";
            this.Cubículo.ReadOnly = true;
            // 
            // Finalidad
            // 
            this.Finalidad.HeaderText = "Finalidad";
            this.Finalidad.Name = "Finalidad";
            this.Finalidad.ReadOnly = true;
            // 
            // Encargado
            // 
            this.Encargado.HeaderText = "Encargado";
            this.Encargado.Name = "Encargado";
            this.Encargado.ReadOnly = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(822, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Volver";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Beneficiarios:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Finalidad:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Firebrick;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(204, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 45);
            this.button4.TabIndex = 42;
            this.button4.Text = "Finalizar Prestamo";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(59, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 45);
            this.button2.TabIndex = 41;
            this.button2.Text = "Agregar Prestamo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Encargado:";
            // 
            // CB_encargado
            // 
            this.CB_encargado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CB_encargado.FormattingEnabled = true;
            this.CB_encargado.Items.AddRange(new object[] {
            "Raul"});
            this.CB_encargado.Location = new System.Drawing.Point(121, 172);
            this.CB_encargado.Name = "CB_encargado";
            this.CB_encargado.Size = new System.Drawing.Size(180, 21);
            this.CB_encargado.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Cubículo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Apellido: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nombre: ";
            // 
            // textApellido
            // 
            this.textApellido.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textApellido.Location = new System.Drawing.Point(328, 102);
            this.textApellido.Name = "textApellido";
            this.textApellido.ReadOnly = true;
            this.textApellido.Size = new System.Drawing.Size(138, 20);
            this.textApellido.TabIndex = 35;
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textNombre.Location = new System.Drawing.Point(121, 103);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(138, 20);
            this.textNombre.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Cédula:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(366, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 32;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextCedula
            // 
            this.TextCedula.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextCedula.Location = new System.Drawing.Point(121, 66);
            this.TextCedula.Name = "TextCedula";
            this.TextCedula.Size = new System.Drawing.Size(138, 20);
            this.TextCedula.TabIndex = 31;
            // 
            // textFinalidad
            // 
            this.textFinalidad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textFinalidad.Location = new System.Drawing.Point(328, 138);
            this.textFinalidad.Name = "textFinalidad";
            this.textFinalidad.Size = new System.Drawing.Size(138, 20);
            this.textFinalidad.TabIndex = 51;
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Location = new System.Drawing.Point(576, 57);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.TabIndex = 54;
            // 
            // CB_beneficiarios
            // 
            this.CB_beneficiarios.FormattingEnabled = true;
            this.CB_beneficiarios.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.CB_beneficiarios.Location = new System.Drawing.Point(397, 172);
            this.CB_beneficiarios.Name = "CB_beneficiarios";
            this.CB_beneficiarios.Size = new System.Drawing.Size(69, 21);
            this.CB_beneficiarios.TabIndex = 55;
            // 
            // CB_cubiculo
            // 
            this.CB_cubiculo.FormattingEnabled = true;
            this.CB_cubiculo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CB_cubiculo.Location = new System.Drawing.Point(121, 141);
            this.CB_cubiculo.Name = "CB_cubiculo";
            this.CB_cubiculo.Size = new System.Drawing.Size(121, 21);
            this.CB_cubiculo.TabIndex = 56;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(712, 256);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(124, 17);
            this.radioButton1.TabIndex = 58;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fecha Personalizada";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblHoy
            // 
            this.lblHoy.AutoSize = true;
            this.lblHoy.Location = new System.Drawing.Point(2, 9);
            this.lblHoy.Name = "lblHoy";
            this.lblHoy.Size = new System.Drawing.Size(37, 13);
            this.lblHoy.TabIndex = 59;
            this.lblHoy.Text = "Fecha";
            // 
            // dtHora
            // 
            this.dtHora.Location = new System.Drawing.Point(637, 230);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(151, 20);
            this.dtHora.TabIndex = 65;
            // 
            // rbFechaActual
            // 
            this.rbFechaActual.AutoSize = true;
            this.rbFechaActual.Location = new System.Drawing.Point(576, 258);
            this.rbFechaActual.Name = "rbFechaActual";
            this.rbFechaActual.Size = new System.Drawing.Size(87, 17);
            this.rbFechaActual.TabIndex = 66;
            this.rbFechaActual.TabStop = true;
            this.rbFechaActual.Text = "Fecha actual";
            this.rbFechaActual.UseVisualStyleBackColor = true;
            this.rbFechaActual.CheckedChanged += new System.EventHandler(this.rbFechaActual_CheckedChanged_1);
            // 
            // Cubículos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 649);
            this.Controls.Add(this.rbFechaActual);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.lblHoy);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.CB_cubiculo);
            this.Controls.Add(this.CB_beneficiarios);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.textFinalidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CB_encargado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextCedula);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgCubiculos);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1000, 0);
            this.Name = "Cubículos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cubiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dgCubiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCubiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cédula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beneficiarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cubículo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_encargado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox TextCedula;
        private System.Windows.Forms.TextBox textFinalidad;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;

        private System.Windows.Forms.MonthCalendar dtFecha;
        private System.Windows.Forms.ComboBox CB_beneficiarios;
        private System.Windows.Forms.ComboBox CB_cubiculo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblHoy;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.RadioButton rbFechaActual;
    }
}