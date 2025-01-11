namespace lista
{
    public partial class Form1 : Form
    {
        private LinkedList<int> lista;
        public Form1()
        {
            InitializeComponent();
            lista = new LinkedList<int>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textboxUpdate()
        {
            arraytext.Text = String.Join(", ", lista.ToArray());
            stringtext.Text = String.Join(", ", lista.ToString());
        }

        private void addfirst_button_Click(object sender, EventArgs e)
        {
            lista.AddFirst((int)input.Value);
            textboxUpdate();
        }

        private void addlast_button_Click(object sender, EventArgs e)
        {
            lista.AddLast((int)input.Value);
            textboxUpdate();
        }
    }
}
