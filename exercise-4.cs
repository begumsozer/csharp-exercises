        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            if (sayi1 % 2 == 0)
            {
                MessageBox.Show("Sayınızı çift giriniz.");
            }
            else
            {
                MessageBox.Show("Sayınız tektir.");
            }
        }
