        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 2; i <= 100 ; i=i+2)
            {
                if (i%2==0)
                {
                    listBox1.Items.Add(i);
                }
            }
