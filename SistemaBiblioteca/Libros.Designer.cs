namespace SistemaBiblioteca
{
    partial class Libros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libros));
            this.label1 = new System.Windows.Forms.Label();
            this.TextCedula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cédula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beneficiarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.automatizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textLibro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_tipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CB_automizado = new System.Windows.Forms.ComboBox();
            this.CB_encargado = new System.Windows.Forms.ComboBox();
            this.CB_beneficiarios = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.MonthCalendar();
            this.label10 = new System.Windows.Forms.Label();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.rbFechaActual = new System.Windows.Forms.RadioButton();
            this.rbPersonalizado = new System.Windows.Forms.RadioButton();
            this.lblHoy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libros";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextCedula
            // 
            this.TextCedula.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextCedula.Location = new System.Drawing.Point(107, 59);
            this.TextCedula.Name = "TextCedula";
            this.TextCedula.Size = new System.Drawing.Size(138, 20);
            this.TextCedula.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(352, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cédula:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cédula,
            this.Nombre,
            this.Apellido,
            this.Libro,
            this.HoraInicio,
            this.FechaRecibido,
            this.Beneficiarios,
            this.tipoPrestamo,
            this.automatizado,
            this.Encargado,
            this.Finalidad});
            this.dataGridView1.Location = new System.Drawing.Point(12, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 348);
            this.dataGridView1.TabIndex = 4;
            // 
            // Cédula
            // 
            this.Cédula.HeaderText = "Cédula";
            this.Cédula.Name = "Cédula";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Libro
            // 
            this.Libro.HeaderText = "Libro";
            this.Libro.Name = "Libro";
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Fecha entrega";
            this.HoraInicio.Name = "HoraInicio";
            // 
            // FechaRecibido
            // 
            this.FechaRecibido.HeaderText = "Fecha recibido";
            this.FechaRecibido.Name = "FechaRecibido";
            // 
            // Beneficiarios
            // 
            this.Beneficiarios.HeaderText = "Beneficiarios";
            this.Beneficiarios.Name = "Beneficiarios";
            // 
            // tipoPrestamo
            // 
            this.tipoPrestamo.HeaderText = "Tipo prestamo";
            this.tipoPrestamo.Name = "tipoPrestamo";
            // 
            // automatizado
            // 
            this.automatizado.HeaderText = "automatizado";
            this.automatizado.Name = "automatizado";
            // 
            // Encargado
            // 
            this.Encargado.HeaderText = "Encargado";
            this.Encargado.Name = "Encargado";
            // 
            // Finalidad
            // 
            this.Finalidad.HeaderText = "Estado";
            this.Finalidad.Name = "Finalidad";
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textNombre.Location = new System.Drawing.Point(107, 96);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(138, 20);
            this.textNombre.TabIndex = 5;
            // 
            // textApellido
            // 
            this.textApellido.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textApellido.Location = new System.Drawing.Point(314, 95);
            this.textApellido.Name = "textApellido";
            this.textApellido.ReadOnly = true;
            this.textApellido.Size = new System.Drawing.Size(138, 20);
            this.textApellido.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Libro";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Encargado:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(45, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 45);
            this.button2.TabIndex = 17;
            this.button2.Text = "Agregar Prestamo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Firebrick;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(309, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 45);
            this.button4.TabIndex = 19;
            this.button4.Text = "Finalizar Prestamo";
            this.button4.UseVisualStyleBackColor = false;
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
            // textLibro
            // 
            this.textLibro.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textLibro.Location = new System.Drawing.Point(107, 131);
            this.textLibro.Name = "textLibro";
            this.textLibro.Size = new System.Drawing.Size(180, 20);
            this.textLibro.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tipo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CB_tipo
            // 
            this.CB_tipo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CB_tipo.FormattingEnabled = true;
            this.CB_tipo.Items.AddRange(new object[] {
            "Domicilio",
            "Sala"});
            this.CB_tipo.Location = new System.Drawing.Point(338, 134);
            this.CB_tipo.Name = "CB_tipo";
            this.CB_tipo.Size = new System.Drawing.Size(114, 21);
            this.CB_tipo.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Automatizado:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Beneficiarios:";
            // 
            // CB_automizado
            // 
            this.CB_automizado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CB_automizado.FormattingEnabled = true;
            this.CB_automizado.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.CB_automizado.Location = new System.Drawing.Point(381, 190);
            this.CB_automizado.Name = "CB_automizado";
            this.CB_automizado.Size = new System.Drawing.Size(71, 21);
            this.CB_automizado.TabIndex = 30;
            // 
            // CB_encargado
            // 
            this.CB_encargado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CB_encargado.FormattingEnabled = true;
            this.CB_encargado.Items.AddRange(new object[] {
            "Damaris Ramírez",
            "Marta Valverde",
            "Oscar Rodríguez"});
            this.CB_encargado.Location = new System.Drawing.Point(107, 165);
            this.CB_encargado.Name = "CB_encargado";
            this.CB_encargado.Size = new System.Drawing.Size(180, 21);
            this.CB_encargado.TabIndex = 40;
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
            this.CB_beneficiarios.Location = new System.Drawing.Point(383, 160);
            this.CB_beneficiarios.Name = "CB_beneficiarios";
            this.CB_beneficiarios.Size = new System.Drawing.Size(69, 21);
            this.CB_beneficiarios.TabIndex = 56;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(614, 50);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(647, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Hora:";
            // 
            // dtHora
            // 
            this.dtHora.Location = new System.Drawing.Point(686, 223);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(151, 20);
            this.dtHora.TabIndex = 66;
            this.dtHora.ValueChanged += new System.EventHandler(this.dtHora_ValueChanged);
            // 
            // rbFechaActual
            // 
            this.rbFechaActual.AutoSize = true;
            this.rbFechaActual.Location = new System.Drawing.Point(650, 251);
            this.rbFechaActual.Name = "rbFechaActual";
            this.rbFechaActual.Size = new System.Drawing.Size(87, 17);
            this.rbFechaActual.TabIndex = 69;
            this.rbFechaActual.TabStop = true;
            this.rbFechaActual.Text = "Fecha actual";
            this.rbFechaActual.UseVisualStyleBackColor = true;
            this.rbFechaActual.CheckedChanged += new System.EventHandler(this.rbFechaActual_CheckedChanged);
            // 
            // rbPersonalizado
            // 
            this.rbPersonalizado.AutoSize = true;
            this.rbPersonalizado.Location = new System.Drawing.Point(746, 251);
            this.rbPersonalizado.Name = "rbPersonalizado";
            this.rbPersonalizado.Size = new System.Drawing.Size(91, 17);
            this.rbPersonalizado.TabIndex = 68;
            this.rbPersonalizado.TabStop = true;
            this.rbPersonalizado.Text = "Personalizado";
            this.rbPersonalizado.UseVisualStyleBackColor = true;
            this.rbPersonalizado.CheckedChanged += new System.EventHandler(this.rbPersonalizado_CheckedChanged);
            // 
            // lblHoy
            // 
            this.lblHoy.AutoSize = true;
            this.lblHoy.Location = new System.Drawing.Point(9, 9);
            this.lblHoy.Name = "lblHoy";
            this.lblHoy.Size = new System.Drawing.Size(37, 13);
            this.lblHoy.TabIndex = 70;
            this.lblHoy.Text = "Fecha";
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 646);
            this.Controls.Add(this.lblHoy);
            this.Controls.Add(this.rbFechaActual);
            this.Controls.Add(this.rbPersonalizado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.CB_beneficiarios);
            this.Controls.Add(this.CB_encargado);
            this.Controls.Add(this.CB_automizado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CB_tipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textLibro);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextCedula);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(700, 500);
            this.Name = "Libros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.Libros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextCedula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textLibro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_tipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CB_automizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cédula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRecibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beneficiarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn automatizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finalidad;
        private System.Windows.Forms.ComboBox CB_encargado;
        private System.Windows.Forms.ComboBox CB_beneficiarios;
        private System.Windows.Forms.MonthCalendar dtFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.RadioButton rbFechaActual;
        private System.Windows.Forms.RadioButton rbPersonalizado;
        private System.Windows.Forms.Label lblHoy;
    }
}