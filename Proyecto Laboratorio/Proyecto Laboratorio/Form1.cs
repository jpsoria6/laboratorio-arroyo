using Proyecto_Laboratorio.Clases;

namespace Proyecto_Laboratorio
{
    public partial class Form1 : Form
    {
        public List<Instrumento> instrumentos;
        public Form1()
        {
            instrumentos = new List<Instrumento>();
            InitializeComponent();
            this.CargarCategorias();
        }



        public void CargarCategorias()
        {
            string[] Categorias = new string[9];
            Categorias[0] = "Baterias Acusticas";
            Categorias[1] = "Baterias Electronicas";
            Categorias[2] = "Baquetas";
            Categorias[3] = "Fundas";
            Categorias[4] = "Redoblantes";
            Categorias[5] = "Parches";
            Categorias[6] = "Bombos";
            Categorias[7] = "Pedales para Bombo";
            Categorias[8] = "Accesorios";
            
           this.comboBoxCategorias.DataSource = Categorias;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instrumento instrumento = new Instrumento();
            instrumento.Descripcion = txtDescripcion.Text;
            instrumento.Precio = double.Parse(txtPrecio.Text);
            instrumento.Categoria = comboBoxCategorias.Text;


            this.instrumentos.Add(instrumento);
            dataGridInstrumentos.DataSource = null;
            this.dataGridInstrumentos.DataSource = this.instrumentos;
        }
    }
}