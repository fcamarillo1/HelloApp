using System.Text.RegularExpressions;

namespace HelloApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            /* Inicialar el componente */ 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Se obtiene los datos de los textbox */
            string password = textBox1.Text;
            string confirmPassword = textBox2.Text;

            // Validaciones de la contraseña
            bool tieneMayuscula = Regex.IsMatch(password, "[A-Z]");
            bool tieneMinuscula = Regex.IsMatch(password, "[a-z]");
            bool tieneNumero = Regex.IsMatch(password, "[0-9]");
            bool tieneSimbolo = Regex.IsMatch(password, "[^a-zA-Z0-9]");

            // Verificar si cumple con todos los requisitos
            if (tieneMayuscula && tieneMinuscula && tieneNumero && tieneSimbolo)
            {
                // Verificar si las contraseñas coinciden
                if (password == confirmPassword)
                {
                    MessageBox.Show("La contraseña ha sido validada 🏆🎉");
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            //alertar si no cumple con los requisitos
            else
            {
                MessageBox.Show("La contraseña debe tener al menos una mayúscula, una minúscula, un número y un símbolo.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Mostrar u ocultar contraseña
        private void buttonEye1_Click(object sender, EventArgs e)
        {
            textBox1.PasswordChar = textBox1.PasswordChar == '\0' ? '*' : '\0';
        }
        // Mostrar u ocultar confirmación de contraseña
        private void buttonEye2_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = textBox2.PasswordChar == '\0' ? '*' : '\0';
        }
    }
}
