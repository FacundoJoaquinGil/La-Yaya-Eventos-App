using System.Drawing.Printing;
using System.Text;
//using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;


namespace La_Yaya_Eventos_App
{
    public partial class Form1 : Form
    {
        PrintDocument printDocument = new PrintDocument();
        Bitmap bmp;
        private decimal ganancia;
        decimal totalComidaNinos = 0;
        int cantidadNinos = 0;
        public Form1()
        {
            
            InitializeComponent();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;


            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;


            this.Resize += new EventHandler(Form1_Resize_1); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;



            // Asignar eventos a los TextBox deseados
            txtPrecioUnidad.KeyDown += textBox_KeyDown;
            txtPrecioUnidad.TextChanged += textBox_TextChanged;

            txtCantidadPersona.KeyDown += textBox_KeyDown;
            txtCantidadPersona.TextChanged += textBox_TextChanged;

            txtCantidadPersonas.KeyDown += textBox_KeyDown;
            txtCantidadPersonas.TextChanged += textBox_TextChanged;

            txtPagoMozos.KeyDown += textBox_KeyDown;
            txtPagoMozos.TextChanged += textBox_TextChanged;

            txtGananciaxPersona.KeyDown += textBox_KeyDown;
            txtGananciaxPersona.TextChanged += textBox_TextChanged;

            txtPrecioNinos.KeyDown += textBox_KeyDown;
            txtPrecioNinos.TextChanged += textBox_TextChanged;

            textCantidadNinos.KeyDown += textBox_KeyDown;
            textCantidadNinos.TextChanged += textBox_TextChanged;

            textNinosTotales.KeyDown += textBox_KeyDown;
            textNinosTotales.TextChanged += textBox_TextChanged;
        }



        private void btnCrearPresupuesto_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            label1.Visible = false;
            pictureBox1.Visible = false;
            btnCrearPresupuesto.Visible = false;

            CenterPanel(panel1);

        }

        private void btnvolver_inicio_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            label1.Visible = true;
            pictureBox1.Visible = true;
            btnCrearPresupuesto.Visible = true;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Deshabilitar Ctrl+V (pegar)
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, @"^\d*$"))
            {
                textBox.Text = System.Text.RegularExpressions.Regex.Replace(textBox.Text, @"[^\d]", "");
                textBox.SelectionStart = textBox.Text.Length; 
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox1.SelectedItem.ToString() == "Seleccione una comida" ||
                string.IsNullOrEmpty(txtPrecioUnidad.Text) ||
                string.IsNullOrEmpty(txtCantidadPersona.Text))
            {
               
                MessageBox.Show("Por Favor Ingrese todos los datos del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string tipoComida = comboBox1.SelectedItem.ToString();
            decimal precioPorUnidad = Convert.ToDecimal(txtPrecioUnidad.Text);
            int cantidadPorPersona = Convert.ToInt32(txtCantidadPersona.Text);



            
            decimal subtotal = precioPorUnidad * cantidadPorPersona;

            
            dgvComidas.Rows.Add(tipoComida, precioPorUnidad, cantidadPorPersona, subtotal);

            txtPrecioUnidad.Text = string.Empty;
            txtCantidadPersona.Text = string.Empty;

            comboBox1.SelectedIndex = -1;
        }

        private void btnAgregarNinos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecioNinos.Text) ||
                string.IsNullOrEmpty(textCantidadNinos.Text) ||
                string.IsNullOrEmpty(textNinosTotales.Text))
            {
                MessageBox.Show("Por favor, ingrese todos los datos del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal precioPorUnidadNinos = Convert.ToDecimal(txtPrecioNinos.Text);
            int cantidadPorNinos = Convert.ToInt32(textCantidadNinos.Text);

            
            cantidadNinos = Convert.ToInt32(textNinosTotales.Text);  

            decimal subTotalNinos = precioPorUnidadNinos * cantidadPorNinos;
            totalComidaNinos = cantidadNinos * subTotalNinos;

            string tipoComida = "Menu Niños";
            decimal subtotal = subTotalNinos;

            
            dgvComidas.Rows.Add(tipoComida, precioPorUnidadNinos, cantidadPorNinos, subtotal);

            
            txtPrecioNinos.Text = string.Empty;
            textCantidadNinos.Text = string.Empty;
            textNinosTotales.Text = string.Empty;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CenterPanel(panel2);

            
            if (string.IsNullOrEmpty(txtCantidadPersonas.Text) ||
                string.IsNullOrEmpty(txtPagoMozos.Text) ||
                string.IsNullOrEmpty(txtGananciaxPersona.Text) ||
                dgvComidas.Rows.Count == 0 || dgvComidas.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel1.Visible = true;
                panel2.Visible = true;
                return;
            }

            panel1.Visible = false;
            panel2.Visible = true;

            int cantidadPersonas = Convert.ToInt32(txtCantidadPersonas.Text);
            decimal pagoMozos = Convert.ToDecimal(txtPagoMozos.Text);
            decimal gananciaxPersona = Convert.ToDecimal(txtGananciaxPersona.Text);
           
            string textoResumen = "";


            decimal totalComida = 0; 
            decimal totalComidaNinos = 0;  
            StringBuilder resumenComida = new StringBuilder();

            resumenComida.AppendLine("Resumen del presupuesto.");
            resumenComida.AppendLine("========================\n");

            foreach (DataGridViewRow row in dgvComidas.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    string tipoComida = row.Cells["Column1"].Value.ToString();
                    decimal subTotalPorPersona = Convert.ToDecimal(row.Cells["Subtotal"].Value);

                   
                    if (tipoComida == "Menu Niños")
                    {
                        totalComidaNinos += subTotalPorPersona;
                    }
                    
                    else
                    {
                        totalComida += subTotalPorPersona;
                    }

                    
                    resumenComida.AppendLine($"{tipoComida}.");
                }
            }

           
            decimal totalComidaMultiplicada = totalComida * cantidadPersonas;

            

            
            decimal totalComidaNinosFinal = totalComidaNinos * cantidadNinos;
            int cantidadTotalPersonas = cantidadPersonas + cantidadNinos;
           
            decimal ganancia = Math.Round((cantidadPersonas + cantidadNinos) * gananciaxPersona, 2);
            decimal precioPorAdulto = Math.Round((totalComidaMultiplicada + pagoMozos + ganancia) / cantidadPersonas, 2);
            decimal totalPresupuesto = Math.Round(totalComidaMultiplicada + totalComidaNinosFinal + pagoMozos + ganancia, 2);

            decimal precioPorNino = 0;
            if (cantidadNinos > 0)
            {
                precioPorNino = Math.Round(totalComidaNinosFinal / cantidadNinos, 2);
            }

            if (cantidadTotalPersonas > 0)
            {
                decimal precioPorPersona = Math.Round(totalPresupuesto / cantidadTotalPersonas, 2);
            }


            // Mostrar los resultados
            resumenComida.AppendLine("\n========================");
            resumenComida.AppendLine($"Presupuesto para {cantidadTotalPersonas} personas");
            resumenComida.AppendLine($"Total Presupuesto: ${totalPresupuesto}");
            

            if (cantidadNinos == 0)
            {
                textoResumen = $"{cantidadPersonas} adultos";
            }
            else if (cantidadNinos > 0)
            {
                textoResumen = $"{cantidadPersonas} adultos, {cantidadNinos} niños";
            }

            resumenComida.AppendLine($"\n* El presupuesto incluye comida para {textoResumen}, mozos y ayudantes de cocina.*");
            resumenComida.AppendLine($"Precio por adulto: ${precioPorAdulto}");

            if (totalComidaNinosFinal > 0)
            {
                resumenComida.AppendLine($"Precio por niño: ${precioPorNino}");
            }

            txtResumenPresupuesto.Text = resumenComida.ToString();
            lblGanancia.Text = $"Ganancia estimada: ${ganancia}";
        }



        private void btnGuardarImg_Click(object sender, EventArgs e)
        {
            lblGanancia.Visible = false;
            btnGuardarImg.Visible = false;
            btnNuevoPresupuesto.Visible = false;
            btnImprimir.Visible = false;

            
            int labelWidth = txtResumenPresupuesto.Width;
            int labelHeight = txtResumenPresupuesto.Height;
            Bitmap bmp = new Bitmap(labelWidth, labelHeight);

            
            txtResumenPresupuesto.DrawToBitmap(bmp, new Rectangle(0, 0, labelWidth, labelHeight));

           
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }

           
            lblGanancia.Visible = true;
            btnGuardarImg.Visible = true;
            btnNuevoPresupuesto.Visible = true;
            btnImprimir.Visible = true;
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            lblGanancia.Visible = false;
            btnGuardarImg.Visible = false;
            btnNuevoPresupuesto.Visible = false;
            btnImprimir.Visible = false;

            
            int labelWidth = txtResumenPresupuesto.Width;
            int labelHeight = txtResumenPresupuesto.Height;
            bmp = new Bitmap(labelWidth, labelHeight);

            
            txtResumenPresupuesto.DrawToBitmap(bmp, new Rectangle(0, 0, labelWidth, labelHeight));

            
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

            
            lblGanancia.Visible = true;
            btnGuardarImg.Visible = true;
            btnNuevoPresupuesto.Visible = true;
            btnImprimir.Visible = true;
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            bmp.SetResolution(e.Graphics.DpiX, e.Graphics.DpiY);

            
            int imageWidth = bmp.Width;
            int imageHeight = bmp.Height;
            int pageWidth = e.PageBounds.Width;
            int pageHeight = e.PageBounds.Height;

            
            float scale = Math.Min((float)pageWidth / imageWidth, (float)pageHeight / imageHeight);

            
            int x = (int)((pageWidth - (imageWidth * scale)) / 2);
            int y = (int)((pageHeight - (imageHeight * scale)) / 2);

            
            e.Graphics.DrawImage(bmp, x, y, imageWidth * scale, imageHeight * scale);
        }


        private void btnNuevoPresupuesto_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            txtPrecioUnidad.Text = string.Empty; 
            txtCantidadPersona.Text = string.Empty; 
           
            txtCantidadPersonas.Text = string.Empty;
            txtPagoMozos.Text = string.Empty;
            txtGananciaxPersona.Text = string.Empty;

            txtPrecioNinos.Text = string.Empty;
            textCantidadNinos.Text = string.Empty;
            textNinosTotales.Text = string.Empty;

            cantidadNinos = 0;

            cbNinos.Checked = false;

            
            dgvComidas.Rows.Clear();

            lblGanancia.Text = "";
            MessageBox.Show("Los campos han sido limpiados para un nuevo presupuesto.");


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCantidadPersonas.Text = string.Empty;
            txtPagoMozos.Text = string.Empty;
            txtGananciaxPersona.Text = string.Empty;

            txtPrecioNinos.Text = string.Empty;
            textCantidadNinos.Text = string.Empty;
            textNinosTotales.Text = string.Empty;

            cantidadNinos = 0;

            cbNinos.Checked = false;

            txtPrecioUnidad.Text = string.Empty;
            txtCantidadPersona.Text = string.Empty;


            dgvComidas.Rows.Clear();

            lblGanancia.Text = "";

        }

        private void Form1_Resize_1(object sender, EventArgs e)
        {
            


            
            CenterStaticControls(); 

            CenterPanel(panel1);
            CenterPanel(panel2);

        }

        private void CenterPanel(Panel panel)
        {
            if (panel.Visible)
            {
                // Calcula la nueva posición centrada
                int x = (this.ClientSize.Width - panel.Width) / 2;
                int y = (this.ClientSize.Height - panel.Height) / 2;

                // Asegura que el panel no se salga del formulario
                x = Math.Max(0, x);
                y = Math.Max(0, y);

                // Asigna la nueva ubicación
                panel.Location = new Point(x, y);
            }
        }

        private void CenterStaticControls()
        {
            
            pictureBox1.Location = new Point((this.ClientSize.Width - pictureBox1.Width) / 2, 20);

            
            label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2, pictureBox1.Bottom + 10);


            int margin = 150; 
            btnCrearPresupuesto.Location = new Point((this.ClientSize.Width - btnCrearPresupuesto.Width) / 2, this.ClientSize.Height - btnCrearPresupuesto.Height - margin); // Posicionar el botón centrado en la parte inferior



        }

        private void cbNinos_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Visible = cbNinos.Checked;

        }
    }
}
