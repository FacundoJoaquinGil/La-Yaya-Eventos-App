namespace La_Yaya_Eventos_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnCrearPresupuesto = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            lblPrecioNinos = new Label();
            btnAgregarNinos = new Button();
            lblNinosTotales = new Label();
            txtPrecioNinos = new TextBox();
            textNinosTotales = new TextBox();
            textCantidadNinos = new TextBox();
            lblCantidadNinos = new Label();
            cbNinos = new CheckBox();
            label8 = new Label();
            btnCancelar = new Button();
            label7 = new Label();
            txtGananciaxPersona = new TextBox();
            label5 = new Label();
            btnCalcular = new Button();
            txtPagoMozos = new TextBox();
            label4 = new Label();
            txtCantidadPersonas = new TextBox();
            dgvComidas = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            btnAgregarProducto = new Button();
            label3 = new Label();
            txtCantidadPersona = new TextBox();
            label2 = new Label();
            txtPrecioUnidad = new TextBox();
            btnvolver_inicio = new Button();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            lblGanancia = new Label();
            txtResumenPresupuesto = new Label();
            btnNuevoPresupuesto = new Button();
            btnImprimir = new Button();
            btnGuardarImg = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComidas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(348, 154);
            label1.Name = "label1";
            label1.Size = new Size(588, 86);
            label1.TabIndex = 0;
            label1.Text = "LA YAYA EVENTOS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(427, 258);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 408);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnCrearPresupuesto
            // 
            btnCrearPresupuesto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearPresupuesto.Location = new Point(561, 685);
            btnCrearPresupuesto.Name = "btnCrearPresupuesto";
            btnCrearPresupuesto.Size = new Size(164, 54);
            btnCrearPresupuesto.TabIndex = 2;
            btnCrearPresupuesto.Text = "Crear Un Presupuesto";
            btnCrearPresupuesto.UseVisualStyleBackColor = true;
            btnCrearPresupuesto.Click += btnCrearPresupuesto_Click_1;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(cbNinos);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtGananciaxPersona);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnCalcular);
            panel1.Controls.Add(txtPagoMozos);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCantidadPersonas);
            panel1.Controls.Add(dgvComidas);
            panel1.Controls.Add(btnAgregarProducto);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCantidadPersona);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPrecioUnidad);
            panel1.Controls.Add(btnvolver_inicio);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1364, 741);
            panel1.TabIndex = 3;
            panel1.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblPrecioNinos);
            panel3.Controls.Add(btnAgregarNinos);
            panel3.Controls.Add(lblNinosTotales);
            panel3.Controls.Add(txtPrecioNinos);
            panel3.Controls.Add(textNinosTotales);
            panel3.Controls.Add(textCantidadNinos);
            panel3.Controls.Add(lblCantidadNinos);
            panel3.Location = new Point(784, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(371, 181);
            panel3.TabIndex = 25;
            panel3.Visible = false;
            // 
            // lblPrecioNinos
            // 
            lblPrecioNinos.AutoSize = true;
            lblPrecioNinos.FlatStyle = FlatStyle.Flat;
            lblPrecioNinos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioNinos.Location = new Point(25, 14);
            lblPrecioNinos.Name = "lblPrecioNinos";
            lblPrecioNinos.RightToLeft = RightToLeft.No;
            lblPrecioNinos.Size = new Size(142, 17);
            lblPrecioNinos.TabIndex = 19;
            lblPrecioNinos.Text = "Precio Por Unidad:   $";
            // 
            // btnAgregarNinos
            // 
            btnAgregarNinos.BackColor = SystemColors.ButtonHighlight;
            btnAgregarNinos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarNinos.ForeColor = Color.ForestGreen;
            btnAgregarNinos.Location = new Point(25, 130);
            btnAgregarNinos.Name = "btnAgregarNinos";
            btnAgregarNinos.RightToLeft = RightToLeft.No;
            btnAgregarNinos.Size = new Size(218, 51);
            btnAgregarNinos.TabIndex = 17;
            btnAgregarNinos.Text = "Agregar Menu Niños a la Lista";
            btnAgregarNinos.UseVisualStyleBackColor = false;
            btnAgregarNinos.Click += btnAgregarNinos_Click;
            // 
            // lblNinosTotales
            // 
            lblNinosTotales.AutoSize = true;
            lblNinosTotales.FlatStyle = FlatStyle.Flat;
            lblNinosTotales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNinosTotales.Location = new Point(25, 90);
            lblNinosTotales.Name = "lblNinosTotales";
            lblNinosTotales.RightToLeft = RightToLeft.No;
            lblNinosTotales.Size = new Size(161, 17);
            lblNinosTotales.TabIndex = 23;
            lblNinosTotales.Text = "Cantidad Total de Niños:";
            // 
            // txtPrecioNinos
            // 
            txtPrecioNinos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrecioNinos.Location = new Point(192, 8);
            txtPrecioNinos.Name = "txtPrecioNinos";
            txtPrecioNinos.RightToLeft = RightToLeft.No;
            txtPrecioNinos.Size = new Size(100, 23);
            txtPrecioNinos.TabIndex = 18;
            // 
            // textNinosTotales
            // 
            textNinosTotales.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textNinosTotales.Location = new Point(216, 83);
            textNinosTotales.Name = "textNinosTotales";
            textNinosTotales.RightToLeft = RightToLeft.No;
            textNinosTotales.Size = new Size(100, 23);
            textNinosTotales.TabIndex = 22;
            // 
            // textCantidadNinos
            // 
            textCantidadNinos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textCantidadNinos.Location = new Point(268, 43);
            textCantidadNinos.Name = "textCantidadNinos";
            textCantidadNinos.RightToLeft = RightToLeft.No;
            textCantidadNinos.Size = new Size(100, 23);
            textCantidadNinos.TabIndex = 20;
            // 
            // lblCantidadNinos
            // 
            lblCantidadNinos.AutoSize = true;
            lblCantidadNinos.FlatStyle = FlatStyle.Flat;
            lblCantidadNinos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidadNinos.Location = new Point(25, 49);
            lblCantidadNinos.Name = "lblCantidadNinos";
            lblCantidadNinos.RightToLeft = RightToLeft.No;
            lblCantidadNinos.Size = new Size(206, 17);
            lblCantidadNinos.TabIndex = 21;
            lblCantidadNinos.Text = "Cantidad de Unidades por Niño:";
            // 
            // cbNinos
            // 
            cbNinos.AutoSize = true;
            cbNinos.Location = new Point(249, 165);
            cbNinos.Name = "cbNinos";
            cbNinos.Size = new Size(136, 19);
            cbNinos.TabIndex = 24;
            cbNinos.Text = "Agregar Menu Niños";
            cbNinos.UseVisualStyleBackColor = true;
            cbNinos.CheckedChanged += cbNinos_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(88, 29);
            label8.Name = "label8";
            label8.Size = new Size(155, 17);
            label8.TabIndex = 16;
            label8.Text = "Seleccione Una Comida:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonHighlight;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Red;
            btnCancelar.Location = new Point(789, 568);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(147, 51);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Limpiar Presupuesto";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(88, 610);
            label7.Name = "label7";
            label7.Size = new Size(321, 17);
            label7.TabIndex = 14;
            label7.Text = "Indique la Ganancia por Persona que Desea Ganar:";
            // 
            // txtGananciaxPersona
            // 
            txtGananciaxPersona.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGananciaxPersona.Location = new Point(462, 604);
            txtGananciaxPersona.Name = "txtGananciaxPersona";
            txtGananciaxPersona.Size = new Size(100, 23);
            txtGananciaxPersona.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(88, 572);
            label5.Name = "label5";
            label5.Size = new Size(273, 17);
            label5.TabIndex = 11;
            label5.Text = "Pago para mozos y ayudantes de cocina:  $";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = SystemColors.HotTrack;
            btnCalcular.Location = new Point(766, 489);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(170, 50);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular Presupuesto Total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtPagoMozos
            // 
            txtPagoMozos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPagoMozos.Location = new Point(406, 568);
            txtPagoMozos.Name = "txtPagoMozos";
            txtPagoMozos.Size = new Size(100, 23);
            txtPagoMozos.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(88, 531);
            label4.Name = "label4";
            label4.Size = new Size(138, 17);
            label4.TabIndex = 9;
            label4.Text = "Cantidad de Adultos:";
            // 
            // txtCantidadPersonas
            // 
            txtCantidadPersonas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantidadPersonas.Location = new Point(261, 525);
            txtCantidadPersonas.Name = "txtCantidadPersonas";
            txtCantidadPersonas.Size = new Size(100, 23);
            txtCantidadPersonas.TabIndex = 8;
            // 
            // dgvComidas
            // 
            dgvComidas.BackgroundColor = SystemColors.ButtonHighlight;
            dgvComidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComidas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, subtotal });
            dgvComidas.Location = new Point(88, 207);
            dgvComidas.Name = "dgvComidas";
            dgvComidas.Size = new Size(443, 303);
            dgvComidas.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tipo de Comida";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Precio por Unidad";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad por Persona";
            Column3.Name = "Column3";
            // 
            // subtotal
            // 
            subtotal.HeaderText = "Subtotal";
            subtotal.Name = "subtotal";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = SystemColors.ButtonHighlight;
            btnAgregarProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProducto.ForeColor = Color.ForestGreen;
            btnAgregarProducto.Location = new Point(88, 152);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(136, 40);
            btnAgregarProducto.TabIndex = 6;
            btnAgregarProducto.Text = "Agregar a la lista";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 111);
            label3.Name = "label3";
            label3.Size = new Size(225, 17);
            label3.TabIndex = 5;
            label3.Text = "Cantidad de Unidades por persona:";
            // 
            // txtCantidadPersona
            // 
            txtCantidadPersona.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantidadPersona.Location = new Point(348, 104);
            txtCantidadPersona.Name = "txtCantidadPersona";
            txtCantidadPersona.Size = new Size(100, 23);
            txtCantidadPersona.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 69);
            label2.Name = "label2";
            label2.Size = new Size(142, 17);
            label2.TabIndex = 3;
            label2.Text = "Precio Por Unidad:   $";
            // 
            // txtPrecioUnidad
            // 
            txtPrecioUnidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrecioUnidad.Location = new Point(285, 63);
            txtPrecioUnidad.Name = "txtPrecioUnidad";
            txtPrecioUnidad.Size = new Size(100, 23);
            txtPrecioUnidad.TabIndex = 2;
            // 
            // btnvolver_inicio
            // 
            btnvolver_inicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnvolver_inicio.Location = new Point(834, 641);
            btnvolver_inicio.Name = "btnvolver_inicio";
            btnvolver_inicio.Size = new Size(100, 46);
            btnvolver_inicio.TabIndex = 1;
            btnvolver_inicio.Text = "Volver al Inicio";
            btnvolver_inicio.UseVisualStyleBackColor = true;
            btnvolver_inicio.Click += btnvolver_inicio_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "*Recepción* Pernil de cerdo", "*Recepción* Taco ", "*Recepción* Carne desmechada", "*Recepción* Mesa de fiambres", "*Recepción* Mesa de frutas", "*Recepción* Fondue de queso con albóndiga", "*Recepción* Cazuelas", "\"Plato Principal\" Pata muslo", "\"Plato Principal\" Pollo relleno", "\"Plato Principal\" Lomo al champignon", "\"Plato Principal\" Muslo relleno", "\"Plato Principal\" Asado", "Sandwiches triples de jamón y queso", "Sandwiches triples de pollo, huevo y morrón", "Sandwiches triples de ternera y queso", "Empanadas Carne", "Empanadas Pollo", "Empanadas fugazzeta", "Empanadas de choclo", "Pizzetas", "Quipes", "Tarteletas", "Pollo Picado" });
            comboBox1.Location = new Point(282, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Seleccione las comidas";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(lblGanancia);
            panel2.Controls.Add(txtResumenPresupuesto);
            panel2.Controls.Add(btnNuevoPresupuesto);
            panel2.Controls.Add(btnImprimir);
            panel2.Controls.Add(btnGuardarImg);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1364, 741);
            panel2.TabIndex = 13;
            panel2.Visible = false;
            // 
            // lblGanancia
            // 
            lblGanancia.AutoSize = true;
            lblGanancia.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGanancia.Location = new Point(807, 29);
            lblGanancia.Name = "lblGanancia";
            lblGanancia.Size = new Size(0, 30);
            lblGanancia.TabIndex = 9;
            // 
            // txtResumenPresupuesto
            // 
            txtResumenPresupuesto.AutoSize = true;
            txtResumenPresupuesto.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResumenPresupuesto.Location = new Point(12, 58);
            txtResumenPresupuesto.Name = "txtResumenPresupuesto";
            txtResumenPresupuesto.Size = new Size(0, 30);
            txtResumenPresupuesto.TabIndex = 8;
            // 
            // btnNuevoPresupuesto
            // 
            btnNuevoPresupuesto.BackColor = SystemColors.ButtonFace;
            btnNuevoPresupuesto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoPresupuesto.ForeColor = SystemColors.MenuHighlight;
            btnNuevoPresupuesto.Location = new Point(1054, 121);
            btnNuevoPresupuesto.Name = "btnNuevoPresupuesto";
            btnNuevoPresupuesto.Size = new Size(150, 46);
            btnNuevoPresupuesto.TabIndex = 7;
            btnNuevoPresupuesto.Text = "Nuevo Presupuesto";
            btnNuevoPresupuesto.UseVisualStyleBackColor = false;
            btnNuevoPresupuesto.Click += btnNuevoPresupuesto_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = SystemColors.ButtonFace;
            btnImprimir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.Location = new Point(1054, 58);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(150, 46);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "Imprimir Presupuesto";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnGuardarImg
            // 
            btnGuardarImg.BackColor = SystemColors.ButtonFace;
            btnGuardarImg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarImg.ForeColor = SystemColors.InfoText;
            btnGuardarImg.Location = new Point(1086, 179);
            btnGuardarImg.Name = "btnGuardarImg";
            btnGuardarImg.Size = new Size(118, 46);
            btnGuardarImg.TabIndex = 3;
            btnGuardarImg.Text = "Guardar Imagen";
            btnGuardarImg.UseVisualStyleBackColor = false;
            btnGuardarImg.Click += btnGuardarImg_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(265, 0);
            label6.Name = "label6";
            label6.Size = new Size(297, 45);
            label6.TabIndex = 0;
            label6.Text = "Presupuesto Total:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1364, 741);
            Controls.Add(panel2);
            Controls.Add(btnCrearPresupuesto);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "La Yaya App";
            Load += Form1_Load;
            Resize += Form1_Resize_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComidas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnCrearPresupuesto;
        private Panel panel1;
        private ComboBox comboBox1;
        private Button btnvolver_inicio;
        private Label label3;
        private Label label2;
        private Button btnAgregarProducto;
        private Label label4;
        private TextBox txtCantidadPersonas;
        private DataGridView dgvComidas;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnCalcular;
        private Label label5;
        private TextBox txtPagoMozos;
        private Panel panel2;
        private Label label6;
        private Button btnImprimir;
        private Button btnGuardarImg;
        private Label label7;
        private TextBox txtGananciaxPersona;
        private DataGridViewTextBoxColumn subtotal;
        private Button btnNuevoPresupuesto;
        private Label txtResumenPresupuesto;
        private Label lblGanancia;
        private Button btnCancelar;
        private Label label8;
        private TextBox txtPrecioUnidad;
        private TextBox txtCantidadPersona;
        private Button btnAgregarNinos;
        private Label lblCantidadNinos;
        private TextBox textCantidadNinos;
        private Label lblPrecioNinos;
        private TextBox txtPrecioNinos;
        private CheckBox cbNinos;
        private Label lblNinosTotales;
        private TextBox textNinosTotales;
        private Panel panel3;
    }
}
