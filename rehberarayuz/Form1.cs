namespace rehberarayuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonsilme_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }



        private void buttonekleme_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(isimtextbox.Text) &&
                !string.IsNullOrWhiteSpace(soyisimtextbox.Text) &&
                !string.IsNullOrWhiteSpace(yastextbox.Text))
            {
                listBox1.Items.Add($" {isimtextbox.Text} {soyisimtextbox.Text} {yastextbox.Text}");
                isimtextbox.Clear();
                soyisimtextbox.Clear();
                yastextbox.Clear();

            }
            else
            {
                MessageBox.Show("L�tfen t�m de�erleri girdi�inizden emin olunuz.");
            }

        }

        private void buttonduzenle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (!string.IsNullOrWhiteSpace(isimtextbox.Text) &&
                !string.IsNullOrWhiteSpace(soyisimtextbox.Text) &&
                !string.IsNullOrWhiteSpace(yastextbox.Text))
                {
                    int selectedIndex = listBox1.SelectedIndex;

                    listBox1.Items[selectedIndex] = ($"{isimtextbox.Text} {soyisimtextbox.Text} {yastextbox.Text}");
                    isimtextbox.Clear();
                    soyisimtextbox.Clear();
                    yastextbox.Clear();
                }
                else
                {
                    MessageBox.Show("L�tfen t�m de�erleri girdi�inizden emin olunuz.");
                }

            }
            else
            {
                MessageBox.Show("L�tfen bir kay�t se�iniz!");
            }
        }

        private void isimtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private void soyisimtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }
    }
}
