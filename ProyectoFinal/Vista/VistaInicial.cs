using ProyectoFinal.Modelos;

namespace ProyectoFinal
{
    public partial class VistaInicial : Form {
        public VistaInicial() {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e) {

        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtMatricula.Text = "";
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e) {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMatricula.Text, "[^0-9]")) {
                txtMatricula.Text = txtMatricula.Text.Remove(txtMatricula.Text.Length - 1);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();

            int matricula = int.Parse(txtMatricula.Text.Trim() == "" ? "-1" : txtMatricula.Text);

            if (nombre == "" || apellido == "" || matricula == -1) {
                MessageBox.Show("Por favor, llene todos los campos");
            } else if (nombre.Length < 3 || nombre.Length > 50) {
                MessageBox.Show("El nombre debe tener una longitud entre 3 y 50 caracteres");
            } else if (apellido.Length < 3 || apellido.Length > 50) {
                MessageBox.Show("El apellido debe tener una longitud entre 3 y 50 caracteres");
            } else {
                Boolean seInserto = new Logica.Storage().agregarEstudiante(nombre, apellido, matricula);
                if (seInserto) {
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtMatricula.Text = "";
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            int matricula = int.Parse(txtBuscar.Text.Trim() == "" ? "-1" : txtBuscar.Text);
            if (matricula == -1) {
                MessageBox.Show("Por favor, ingrese una matricula");
            } else {
                Estudiantes estudiante = new Logica.Storage().buscarEstudiante(matricula);
                if (estudiante != null) {
                    MessageBox.Show(imprimirEstudiante(estudiante));
                } else {
                    MessageBox.Show("No se encontro ningun estudiante con esa matricula");
                }
            }

        }

        private string imprimirEstudiante(Estudiante estudiante) {
            //las practicas y parcuales pueden valer -1, en ese caso imprimi sin nota
            string parcial1 = estudiante.parcial1 == -1 ? "Sin nota" : estudiante.parcial1.ToString();
            string parcial2 = estudiante.parcial2 == -1 ? "Sin nota" : estudiante.parcial2.ToString();
            string parcial3 = estudiante.parcial3 == -1 ? "Sin nota" : estudiante.parcial3.ToString();
            string practica1 = estudiante.practica1 == -1 ? "Sin nota" : estudiante.practica1.ToString();
            string practica2 = estudiante.practica2 == -1 ? "Sin nota" : estudiante.practica2.ToString();
            string practica3 = estudiante.practica3 == -1 ? "Sin nota" : estudiante.practica3.ToString();

            return $"Nombre: {estudiante.nombre}\nApellido: {estudiante.apellido}\nMatricula: {estudiante.matricula}\nParcial 1: {parcial1}\nParcial 2: {parcial2}\nParcial 3: {parcial3}\nPractica 1: {practica1}\nPractica 2: {practica2}\nPractica 3: {practica3}";
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e) {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBuscar.Text, "[^0-9]")) {
                txtBuscar.Text = txtBuscar.Text.Remove(txtBuscar.Text.Length - 1);
            }
        }
    }
}
