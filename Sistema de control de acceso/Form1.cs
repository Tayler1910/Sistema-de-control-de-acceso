using System.Collections.Generic;
namespace Sistema_de_control_de_acceso

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        Queue<string> colaPersonas = new Queue<string>();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (nombre == "")
            {
                MessageBox.Show("Ingrese el nombre de la persona.");
                return;
            }

            colaPersonas.Enqueue(nombre);

            lstCola.Items.Clear();

            foreach (string persona in colaPersonas)
            {
                lstCola.Items.Add(persona);
            }

            txtNombre.Clear();

            MessageBox.Show("Persona registrada correctamente.");
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (colaPersonas.Count == 0)
            {
                MessageBox.Show("No hay personas esperando.");
                return;
            }

            string persona = colaPersonas.Dequeue();

            lstCola.Items.Clear();

            foreach (string nombre in colaPersonas)
            {
                lstCola.Items.Add(nombre);
            }

            lstHistorial.Items.Add(persona);

            MessageBox.Show(persona + " ha ingresado al laboratorio.");
        }
     
    
        public class HistorialIngresos
        {
            private List<string> personasIngresadas = new List<string>();

            public void RegistrarIngreso(string nombre)
            {
                personasIngresadas.Add(nombre);
            }

            public List<string> ObtenerHistorial()
            {
                return new List<string>(personasIngresadas);
            }

            public int CantidadIngresos()
            {
                return personasIngresadas.Count;
            }

            public void LimpiarHistorial()
            {
                personasIngresadas.Clear();
            }
        }
    }

}
