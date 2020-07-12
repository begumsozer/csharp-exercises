 private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string yildiz = "*";
            int a = int.Parse(textBox1.Text);
            for (int i = 1 ; i <= a; i++)
            {
                listBox1.Items.Add( yildiz);
                yildiz += "*";
            }
        }
