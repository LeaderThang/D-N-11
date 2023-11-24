namespace DỰ_ÁN_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            GIAO_DIỆN_CHỨC_NĂNG giaodien = new GIAO_DIỆN_CHỨC_NĂNG();
            giaodien.Show();
        }
    }
}