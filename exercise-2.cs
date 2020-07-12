private void btn_azalt_Click(object sender, EventArgs e)
        {
            try
            {
            int x, y;               
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            int sonuc7 = x - 1;
            MessageBox.Show(sonuc7.ToString());
            int sonuc8 = y - 1;
            MessageBox.Show(sonuc8.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
