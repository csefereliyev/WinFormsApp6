namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Cixis emeliyyati", "bildiris", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string temp = comboBox1.Text;

            comboBox1.Text = comboBox2.Text;

            comboBox2.Text = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string info = $"Ucus: {comboBox1.Text}->{comboBox2.Text} | Tarix: {maskedTextBox1.Text} | " +
                  $"Saat: {maskedTextBox2.Text} | Yer: {maskedTextBox3.Text} | " +
                  $"Ad Soy.: {maskedTextBox4.Text} | FIN: {maskedTextBox5.Text} | Email: {maskedTextBox6.Text} | Tel.: {maskedTextBox7.Text}";
            listBox1.Items.Add(info);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
