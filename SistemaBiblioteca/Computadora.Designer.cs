namespace SistemaBiblioteca
{
    partial class Computadora
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgComputadora = new System.Windows.Forms.DataGridView();
            this.Cédula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beneficiarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuComputadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.txtBeneficiario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComputadora = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.MonthCalendar();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEncargado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHoy = new System.Windows.Forms.Label();
            this.rbPersonalizado = new System.Windows.Forms.RadioButton();
            this.rbFechaActual = new System.Windows.Forms.RadioButton();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.TextCedula = new System.Windows.Forms.TextBox();
            this.filtrarMes = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgComputadora)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computadoras";
            // 
            // dgComputadora
            // 
            this.dgComputadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComputadora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cédula,
            this.Nombre,
            this.Apellido,
            this.HoraInicio,
            this.Beneficiarios,
            this.NuComputadora,
            this.Encargado});
            this.dgComputadora.Location = new System.Drawing.Point(82, 319);
            this.dgComputadora.Name = "dgComputadora";
            this.dgComputadora.Size = new System.Drawing.Size(747, 318);
            this.dgComputadora.TabIndex = 4;
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
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inico";
            this.HoraInicio.Name = "HoraInicio";
            // 
            // Beneficiarios
            // 
            this.Beneficiarios.HeaderText = "Beneficiarios";
            this.Beneficiarios.Name = "Beneficiarios";
            // 
            // NuComputadora
            // 
            this.NuComputadora.HeaderText = "# Computadora";
            this.NuComputadora.Name = "NuComputadora";
            // 
            // Encargado
            // 
            this.Encargado.HeaderText = "Encargado";
            this.Encargado.Name = "Encargado";
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
            // txtBeneficiario
            // 
            this.txtBeneficiario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBeneficiario.Location = new System.Drawing.Point(359, 135);
            this.txtBeneficiario.MaxLength = 2;
            this.txtBeneficiario.Name = "txtBeneficiario";
            this.txtBeneficiario.Size = new System.Drawing.Size(71, 20);
            this.txtBeneficiario.TabIndex = 49;
            this.txtBeneficiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Beneficiarios:";
            // 
            // txtComputadora
            // 
            this.txtComputadora.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtComputadora.Location = new System.Drawing.Point(139, 135);
            this.txtComputadora.MaxLength = 2;
            this.txtComputadora.Name = "txtComputadora";
            this.txtComputadora.Size = new System.Drawing.Size(138, 20);
            this.txtComputadora.TabIndex = 44;
            this.txtComputadora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(600, 54);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.TabIndex = 43;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(139, 214);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 45);
            this.btnAgregar.TabIndex = 41;
            this.btnAgregar.Text = "Agregar Prestamo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Encargado:";
            // 
            // cbEncargado
            // 
            this.cbEncargado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbEncargado.FormattingEnabled = true;
            this.cbEncargado.Items.AddRange(new object[] {
            "Damaris Ramírez",
            "Marta Valverde",
            "Oscar Rodríguez"});
            this.cbEncargado.Location = new System.Drawing.Point(139, 169);
            this.cbEncargado.Name = "cbEncargado";
            this.cbEncargado.Size = new System.Drawing.Size(180, 21);
            this.cbEncargado.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Computadora:";
            // 
            // lblHoy
            // 
            this.lblHoy.AutoSize = true;
            this.lblHoy.Location = new System.Drawing.Point(7, 7);
            this.lblHoy.Name = "lblHoy";
            this.lblHoy.Size = new System.Drawing.Size(37, 13);
            this.lblHoy.TabIndex = 60;
            this.lblHoy.Text = "Fecha";
            // 
            // rbPersonalizado
            // 
            this.rbPersonalizado.AutoSize = true;
            this.rbPersonalizado.Location = new System.Drawing.Point(728, 255);
            this.rbPersonalizado.Name = "rbPersonalizado";
            this.rbPersonalizado.Size = new System.Drawing.Size(91, 17);
            this.rbPersonalizado.TabIndex = 61;
            this.rbPersonalizado.TabStop = true;
            this.rbPersonalizado.Text = "Personalizado";
            this.rbPersonalizado.UseVisualStyleBackColor = true;
            this.rbPersonalizado.CheckedChanged += new System.EventHandler(this.rbPersonalizado_CheckedChanged);
            // 
            // rbFechaActual
            // 
            this.rbFechaActual.AutoSize = true;
            this.rbFechaActual.Location = new System.Drawing.Point(635, 255);
            this.rbFechaActual.Name = "rbFechaActual";
            this.rbFechaActual.Size = new System.Drawing.Size(87, 17);
            this.rbFechaActual.TabIndex = 62;
            this.rbFechaActual.TabStop = true;
            this.rbFechaActual.Text = "Fecha actual";
            this.rbFechaActual.UseVisualStyleBackColor = true;
            this.rbFechaActual.CheckedChanged += new System.EventHandler(this.rbFechaActual_CheckedChanged);
            // 
            // dtHora
            // 
            this.dtHora.Location = new System.Drawing.Point(671, 227);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(151, 20);
            this.dtHora.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Apellido: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Nombre: ";
            // 
            // textApellido
            // 
            this.textApellido.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textApellido.Enabled = false;
            this.textApellido.Location = new System.Drawing.Point(346, 100);
            this.textApellido.Name = "textApellido";
            this.textApellido.ReadOnly = true;
            this.textApellido.Size = new System.Drawing.Size(138, 20);
            this.textApellido.TabIndex = 70;
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textNombre.Enabled = false;
            this.textNombre.Location = new System.Drawing.Point(139, 101);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(138, 20);
            this.textNombre.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Cédula:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(384, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 36);
            this.btnBuscar.TabIndex = 67;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TextCedula
            // 
            this.TextCedula.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextCedula.Location = new System.Drawing.Point(139, 64);
            this.TextCedula.MaxLength = 10;
            this.TextCedula.Name = "TextCedula";
            this.TextCedula.Size = new System.Drawing.Size(138, 20);
            this.TextCedula.TabIndex = 66;
            this.TextCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // filtrarMes
            // 
            this.filtrarMes.BackColor = System.Drawing.Color.SteelBlue;
            this.filtrarMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarMes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filtrarMes.Location = new System.Drawing.Point(729, 286);
            this.filtrarMes.Name = "filtrarMes";
            this.filtrarMes.Size = new System.Drawing.Size(100, 27);
            this.filtrarMes.TabIndex = 73;
            this.filtrarMes.Text = "Filtrar por mes";
            this.filtrarMes.UseVisualStyleBackColor = false;
            this.filtrarMes.Click += new System.EventHandler(this.filtrarMes_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Brown;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrar.Location = new System.Drawing.Point(613, 286);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(110, 27);
            this.btnBorrar.TabIndex = 74;
            this.btnBorrar.Text = "Borrar prestamo";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick_1);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinalizar.Location = new System.Drawing.Point(453, 286);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(154, 27);
            this.btnFinalizar.TabIndex = 42;
            this.btnFinalizar.Text = "Finalizar Prestamo";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Computadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 649);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.filtrarMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.TextCedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.rbFechaActual);
            this.Controls.Add(this.rbPersonalizado);
            this.Controls.Add(this.lblHoy);
            this.Controls.Add(this.txtBeneficiario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtComputadora);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbEncargado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgComputadora);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(4000, 0);
            this.Name = "Computadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cubiculos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Computadora_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgComputadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgComputadora;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cédula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beneficiarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuComputadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado;
        private System.Windows.Forms.TextBox txtBeneficiario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComputadora;
        private System.Windows.Forms.MonthCalendar dtFecha;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEncargado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHoy;
        private System.Windows.Forms.RadioButton rbPersonalizado;
        private System.Windows.Forms.RadioButton rbFechaActual;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox TextCedula;
        private System.Windows.Forms.Button filtrarMes;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Button btnFinalizar;
    }
}