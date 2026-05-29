namespace ProyectoPOO2C
{
    public partial class Form1 : Form
    {
        List<Producto> carrito = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
            ConfigurarData();
        }

        public void ConfigurarData()
        {
            dgvVentas.ColumnCount = 4;
            dgvVentas.Columns[0].HeaderText = "Producto";
            dgvVentas.Columns[1].HeaderText = "Info";
            dgvVentas.Columns[2].HeaderText = "Precio";
            dgvVentas.Columns[3].HeaderText = "Fecha";
        }

        private void ActualizarGrid()
        {
            dgvVentas.Rows.Clear();

            foreach (var p in carrito)
            {
                dgvVentas.Rows.Add(p.Nombre, p.MostrarInfo(), p.Precio.ToString("C"), DateTime.Now.ToShortDateString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = int.Parse(nudCantidad.Value.ToString());

                foreach (var item in clbProductos.CheckedItems)
                {
                    for (int i = 0; i < cantidad; i++)
                    {
                        Producto producto = null;

                        switch (item.ToString())
                        {
                            case "Taco":
                                producto = new Taco("Taco Pastor", 35, "Pastor", "Maíz");
                                break;

                            case "Hamburguesa":
                                producto = new Hamburguesa("Hamburguesa BBQ", 80, 2);
                                break;

                            case "Refresco":
                                producto = new Bebida("Coca Cola", 25, "Grande");
                                break;

                            case "Papas":
                                producto = new Papas("Papas", 50, "Alto");
                                break;
                        }
                        carrito.Add(producto);
                    }
                }
                ActualizarGrid();
                MessageBox.Show("Productos agregados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                double total = 0;

                foreach (Producto p in carrito)
                {
                    total += p.CalcularPrecio();

                    Venta venta = new Venta( p.Nombre, p.CalcularPrecio(), 1);

                    dgvVentas.Rows.Add(p.Nombre, p.MostrarInfo(), 1, p.CalcularPrecio(), venta.Fecha);
                }

                total = Oferta.AplicarOferta(total);

                lblTotal.Text = "TOTAL: $" + total;

                MessageBox.Show("Venta realizada");

                carrito.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
