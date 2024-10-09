using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;


namespace La_Yaya_Eventos_App
{
    public partial class Form1 : Form
    {
        PrintDocument printDocument = new PrintDocument();
        Bitmap bmp;
        public Form1()
        {
            //private List<Comida> comidas = new List<Comida>();
            InitializeComponent();
            
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;

            CenterControl(panel1);
            CenterControl(panel2);

            // Asignar eventos a los TextBox deseados
            txtPrecioUnidad.KeyDown += textBox_KeyDown;
            txtPrecioUnidad.TextChanged += textBox_TextChanged;

            txtCantidadPersona.KeyDown += textBox_KeyDown;
            txtCantidadPersona.TextChanged += textBox_TextChanged;

            txtCantidadPersonas.KeyDown += textBox_KeyDown;
            txtCantidadPersonas.TextChanged += textBox_TextChanged;

            txtPagoMozos.KeyDown += textBox_KeyDown;
            txtPagoMozos.TextChanged += textBox_TextChanged;

            txtPorcentajeGanancia.KeyDown += textBox_KeyDown;
            txtPorcentajeGanancia.TextChanged += textBox_TextChanged;

        }

        private void CenterControl(Control control)
        {
            // Centra horizontalmente
            control.Left = (this.ClientSize.Width - control.Width) / 2;

            // Centra verticalmente
            control.Top = (this.ClientSize.Height - control.Height) / 2;
        }


        private void btnCrearPresupuesto_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnvolver_inicio_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
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

            // Validar si el texto contiene caracteres no numéricos y eliminarlos
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, @"^\d*$"))
            {
                textBox.Text = System.Text.RegularExpressions.Regex.Replace(textBox.Text, @"[^\d]", "");
                textBox.SelectionStart = textBox.Text.Length; // Mover el cursor al final
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox1.SelectedItem.ToString() == "Seleccione una comida" ||
                string.IsNullOrEmpty(txtPrecioUnidad.Text) ||
                string.IsNullOrEmpty(txtCantidadPersona.Text))
            {
                // Mostrar mensaje de alerta si algún campo está vacío
                MessageBox.Show("Por Favor Ingrese todos los datos del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución si faltan campos
            }

            // Obtener valores de los controles
            string tipoComida = comboBox1.SelectedItem.ToString();
            decimal precioPorUnidad = Convert.ToDecimal(txtPrecioUnidad.Text);
            int cantidadPorPersona = Convert.ToInt32(txtCantidadPersona.Text);

            

            // Calcular el subtotal
            decimal subtotal = precioPorUnidad * cantidadPorPersona;

            // Agregar una nueva fila al DataGridView
            dgvComidas.Rows.Add(tipoComida, precioPorUnidad, cantidadPorPersona, subtotal);

        }

        private decimal ganancia;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos necesarios estén llenos
            if (string.IsNullOrEmpty(txtCantidadPersonas.Text) ||
                string.IsNullOrEmpty(txtPagoMozos.Text) ||
                string.IsNullOrEmpty(txtPorcentajeGanancia.Text) ||
                dgvComidas.Rows.Count == 0 || dgvComidas.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                // Mostrar mensaje de alerta si algún campo está vacío
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución si faltan campos
            }

            // Ocultar el panel actual y mostrar el panel de resumen
            panel1.Visible = false;
            panel2.Visible = true;

            // Obtener los valores ingresados por el usuario
            int cantidadPersonas = Convert.ToInt32(txtCantidadPersonas.Text);
            decimal pagoMozos = Convert.ToDecimal(txtPagoMozos.Text);
            decimal porcentajeGanancia = Convert.ToDecimal(txtPorcentajeGanancia.Text);

            // Calcular el costo total de la comida
            decimal totalComida = 0;
            StringBuilder resumenComida = new StringBuilder();

            // Agregar un título al resumen
            resumenComida.AppendLine("Resumen del Presupuesto:");
            resumenComida.AppendLine("========================\n");

            foreach (DataGridViewRow row in dgvComidas.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    string tipoComida = row.Cells["Column1"].Value.ToString();
                    decimal precioUnidad = Convert.ToDecimal(row.Cells["Column2"].Value);
                    int cantidadPorPersona = Convert.ToInt32(row.Cells["Column3"].Value);
                    decimal subTotalPorPersona = Convert.ToInt32(row.Cells["subtotal"].Value);

                    // Calcular subtotal total por el número de personas
                    decimal subtotalTotal = subTotalPorPersona * precioUnidad;
                    totalComida = subTotalPorPersona + totalComida;

                    // Formatear la salida de la comida
                    resumenComida.AppendLine($"{tipoComida}: {cantidadPorPersona} por persona, Precio unidad: ${precioUnidad}, Subtotal: ${subTotalPorPersona}");
                }
            }

            totalComida = totalComida * cantidadPersonas;

            ganancia = totalComida * (porcentajeGanancia / 100);

            // Calcular presupuesto total
            decimal totalPresupuesto = totalComida + pagoMozos + ganancia;

            // Guardar la ganancia en una variable separada

            // Formatear la visualización del total (sin incluir ganancia)
            resumenComida.AppendLine("\n========================");
            resumenComida.AppendLine($"Total Comida: ${totalComida}");
            resumenComida.AppendLine($"Total Presupuesto: ${totalPresupuesto}");

            // Nota sobre lo que incluye el presupuesto
            resumenComida.AppendLine("\n* El presupuesto incluye mozos y ayudantes de cocina.");

            // Mostrar el resumen en un Label o TextBox
            txtResumenPresupuesto.Text = resumenComida.ToString();

            // Mostrar ganancia en un label aparte, opcionalmente
            lblGanancia.Text = $"Ganancia estimada: ${ganancia}";

        }


        private void btnGuardarImg_Click(object sender, EventArgs e)
        {
            lblGanancia.Visible = false;
            btnGuardarImg.Visible = false;
            btnNuevoPresupuesto.Visible = false;
            btnImprimir.Visible = false;


            // Crear un bitmap con el tamaño del panel2
            Bitmap bmp = new Bitmap(panel2.Width, panel2.Height);

            // Dibujar el contenido del panel2 en el bitmap
            panel2.DrawToBitmap(bmp, new Rectangle(0, 0, panel2.Width, panel2.Height));

            // Guardar la imagen en un archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }

            // Volver a mostrar botones y label
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

            // Crear un bitmap con el tamaño del panel2
            bmp = new Bitmap(panel2.Width, panel2.Height);

            // Dibujar el contenido del panel2 en el bitmap
            panel2.DrawToBitmap(bmp, new Rectangle(0, 0, panel2.Width, panel2.Height));

            // Configurar el evento para la impresión
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            // Abrir el cuadro de diálogo de impresión
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

            // Volver a mostrar los controles ocultos
            lblGanancia.Visible = true;
            btnGuardarImg.Visible = true;
            btnNuevoPresupuesto.Visible = true;
            btnImprimir.Visible = true;
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Obtener el tamaño de la imagen y el tamaño del área de impresión
            int imageWidth = bmp.Width;
            int imageHeight = bmp.Height;
            int pageWidth = e.PageBounds.Width;
            int pageHeight = e.PageBounds.Height;

            // Calcular las coordenadas X e Y para centrar la imagen
            int x = (pageWidth - imageWidth) / 2;
            int y = (pageHeight - imageHeight) / 2;

            // Dibujar la imagen centrada en la página
            e.Graphics.DrawImage(bmp, x, y);
        }

        private void btnNuevoPresupuesto_Click(object sender, EventArgs e)
        {
            txtPrecioUnidad.Text = string.Empty; //cambiarrrr
            txtCantidadPersona.Text = string.Empty; //cambiarrrr
            // Limpiar los campos de texto
            txtCantidadPersonas.Text = string.Empty;
            txtPagoMozos.Text = string.Empty;
            txtPorcentajeGanancia.Text = string.Empty;

            // Restablecer la lista desplegable de tipos de comida (ComboBox)
            comboBox1.Text = "Seleccione una comida"; // Deja sin seleccionar nada

            // Limpiar la lista de comidas agregadas (DataGridView o ListView)
            dgvComidas.Rows.Clear(); // Si estás usando un DataGridView

            // Limpiar otros campos o controles según sea necesario
            lblTotal.Text = "Total: $0"; // Ejemplo de etiqueta que muestra el total
            lblGanancia.Text = "Total: $0";
            MessageBox.Show("Los campos han sido limpiados para un nuevo presupuesto.");
            panel1.Visible = true;
            panel2.Visible = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPrecioUnidad.Text = string.Empty; 
            txtCantidadPersona.Text = string.Empty;
            
            txtCantidadPersonas.Text = string.Empty;
            txtPagoMozos.Text = string.Empty;
            txtPorcentajeGanancia.Text = string.Empty;

            
            comboBox1.Text = "Seleccione una comida"; 

            
            dgvComidas.Rows.Clear(); 

            
            lblTotal.Text = "Total: $0"; 
            lblGanancia.Text = "Total: $0";

        }
    }
}
