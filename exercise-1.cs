        private void hesapla_Click(object sender, EventArgs e)
        {
            try {
                double cevre = double.Parse(txt1.Text);
                double pi = 3.14;
                lblcevre.Text = Convert.ToString((cevre / 2) * 2 * pi);

                double alan = double.Parse(txt1.Text);
                double pi1 = 3.14;
                lblalan.Text = Convert.ToString((alan * alan) * pi);
            }
         
            catch(Exception ex)
            {
                MessageBox.Show("tekrar yaz");
            }
            finally
            {
                MessageBox.Show("bitti");
            }
        }
