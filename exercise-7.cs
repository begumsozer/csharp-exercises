  private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1935; i < 2020; i++)
            {
                    listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1935; i < 2020; i++)
            {
                if (i % 2 == 0)
                    listBox1.Items.Add(i);
            }
        }
