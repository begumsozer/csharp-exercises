 
private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Add(sayi + "sayının çarpım tablosu");
            for  (int i = 0; i<=10; i++)
            {
                listBox1.Items.Add(sayi + "*" + i + "=" + sayi*i);
            }
            
        }
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
