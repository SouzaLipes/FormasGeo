namespace Geometrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_comecar_Click(object sender, EventArgs e)
        {
            Formass forma = new Formass();
            forma.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}