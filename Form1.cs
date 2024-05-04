namespace HotelPets
{
    public partial class frmHotelPets : Form
    {
        public frmHotelPets()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            decimal animais = numQtdAnimais.Value;
            decimal racao = numQtdRacao.Value;
            decimal dia = numQtdDias.Value;

            decimal resultado = animais * racao * dia;

            lblResultado.Text = resultado.ToString();
        }
    }
}
