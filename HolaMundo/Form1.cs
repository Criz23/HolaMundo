/// <summary>
/// Rosales Martínez Javier
/// 210509386
/// j.rosales@alumnos.udg.mx
/// </summary>
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HolaMundo
{
    /// <summary>
    /// Creación de formulario para registro
    /// </summary>
    public partial class registro : Form
    {
        #region Propiedades
        Regex expNum = new Regex(@"(?:.*\d)");
        Regex expMayus = new Regex(@"(?:.*[A-Z])");
        Regex expMin = new Regex(@"(?:.*[a-z])");
        Regex expSimb = new Regex(@"(?=.*[$@$!%*?&_-])");
        #endregion Propiedades

        #region Constructor
        public registro()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Eventos
        /// <summary>
        /// Creación del evento click del botón validar
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void btnValidar_Click(object sender, EventArgs e)
        {
            

            if (!(expNum.IsMatch(txtPws1.Text) && expMayus.IsMatch(txtPws1.Text) && expMin.IsMatch(txtPws1.Text) && expSimb.IsMatch(txtPws1.Text)))
            {
                MessageBox.Show("La contraseña debe de tener al menos una letra mayuscula, una letra inuscula, un numero y un simbolo");
            }
            else if(!(txtPws1.Text == txtPws2.Text))
            {
                MessageBox.Show("Las contraseñas no coinsiden");
            }
            else
            {
                MessageBox.Show("Las contrseñas coinsiden y es segura");
            }
        }
        /// <summary>
        /// Creación evento Checked del checkBoxPws1
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void checkBoxPws1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPws1.Checked)
            {
                txtPws1.UseSystemPasswordChar = false;
            }
            else
            {
                txtPws1.UseSystemPasswordChar = true;   
            }
            
           
        }
        /// <summary>
        /// Creación evento Checked del checkBoxPws2
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void checkBoxPws2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPws2.Checked)
            {
                txtPws2.UseSystemPasswordChar = false;
            }
            else
            {
                txtPws2.UseSystemPasswordChar = true;
            }
        }
        #endregion Eventos
    }
}
