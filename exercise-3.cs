       private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x, y;
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
                int sonuc = (x + y) / 2;
                MessageBox.Show(sonuc.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
