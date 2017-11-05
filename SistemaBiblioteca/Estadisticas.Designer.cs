namespace SistemaBiblioteca
{
    partial class Estadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadisticas));
            this.cbTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.cbEstadistica = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcSelecc = new System.Windows.Forms.Button();
            this.btnCalcTodas = new System.Windows.Forms.Button();
            this.dgEstadistica = new System.Windows.Forms.DataGridView();
            this.estadistica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEstadistica = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTipoPrestamo
            // 
            this.cbTipoPrestamo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbTipoPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPrestamo.FormattingEnabled = true;
            this.cbTipoPrestamo.Items.AddRange(new object[] {
            "Computadora",
            "Cubículo",
            "Libro"});
            this.cbTipoPrestamo.Location = new System.Drawing.Point(94, 10);
            this.cbTipoPrestamo.Name = "cbTipoPrestamo";
            this.cbTipoPrestamo.Size = new System.Drawing.Size(138, 21);
            this.cbTipoPrestamo.TabIndex = 34;
            this.cbTipoPrestamo.SelectedIndexChanged += new System.EventHandler(this.cbTipoPrestamo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tipo prestamo:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(368, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Volver";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cbEstadistica
            // 
            this.cbEstadistica.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbEstadistica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadistica.FormattingEnabled = true;
            this.cbEstadistica.Items.AddRange(new object[] {
            "Cantidad",
            "Género",
            "Grupo de edad"});
            this.cbEstadistica.Location = new System.Drawing.Point(94, 37);
            this.cbEstadistica.Name = "cbEstadistica";
            this.cbEstadistica.Size = new System.Drawing.Size(138, 21);
            this.cbEstadistica.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Estadística por:";
            // 
            // btnCalcSelecc
            // 
            this.btnCalcSelecc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcSelecc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcSelecc.Location = new System.Drawing.Point(14, 74);
            this.btnCalcSelecc.Name = "btnCalcSelecc";
            this.btnCalcSelecc.Size = new System.Drawing.Size(105, 23);
            this.btnCalcSelecc.TabIndex = 37;
            this.btnCalcSelecc.Text = "Calcular selección";
            this.btnCalcSelecc.UseVisualStyleBackColor = false;
            this.btnCalcSelecc.Click += new System.EventHandler(this.btnCalcSelecc_Click);
            // 
            // btnCalcTodas
            // 
            this.btnCalcTodas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcTodas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcTodas.Location = new System.Drawing.Point(127, 74);
            this.btnCalcTodas.Name = "btnCalcTodas";
            this.btnCalcTodas.Size = new System.Drawing.Size(105, 23);
            this.btnCalcTodas.TabIndex = 38;
            this.btnCalcTodas.Text = "Calcular todas";
            this.btnCalcTodas.UseVisualStyleBackColor = false;
            this.btnCalcTodas.Click += new System.EventHandler(this.btnCalcTodas_Click);
            // 
            // dgEstadistica
            // 
            this.dgEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstadistica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estadistica,
            this.Fecha,
            this.Resultado});
            this.dgEstadistica.Location = new System.Drawing.Point(14, 103);
            this.dgEstadistica.Name = "dgEstadistica";
            this.dgEstadistica.Size = new System.Drawing.Size(429, 254);
            this.dgEstadistica.TabIndex = 39;
            // 
            // estadistica
            // 
            this.estadistica.HeaderText = "Estadística";
            this.estadistica.Name = "estadistica";
            this.estadistica.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "resultado";
            this.Resultado.Name = "Resultado";
            this.Resultado.Width = 130;
            // 
            // fechaEstadistica
            // 
            this.fechaEstadistica.Location = new System.Drawing.Point(243, 38);
            this.fechaEstadistica.Name = "fechaEstadistica";
            this.fechaEstadistica.Size = new System.Drawing.Size(200, 20);
            this.fechaEstadistica.TabIndex = 41;
            this.fechaEstadistica.ValueChanged += new System.EventHandler(this.fechaEstadistica_ValueChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Brown;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(238, 74);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(66, 23);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 369);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.fechaEstadistica);
            this.Controls.Add(this.dgEstadistica);
            this.Controls.Add(this.btnCalcTodas);
            this.Controls.Add(this.btnCalcSelecc);
            this.Controls.Add(this.cbEstadistica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoPrestamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadísticas";
            ((System.ComponentModel.ISupportInitialize)(this.dgEstadistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbEstadistica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcSelecc;
        private System.Windows.Forms.Button btnCalcTodas;
        private System.Windows.Forms.DataGridView dgEstadistica;
        private System.Windows.Forms.DateTimePicker fechaEstadistica;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadistica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
    }
}