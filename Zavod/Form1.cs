using System.Data.Entity;
using System.Data.SQLite;

namespace Zavod
{
    public partial class Form1 : Form
    {

        SQLiteConnection sqconn = new SQLiteConnection(@"Data Source=StorageDB.db");


        DBclass db = new DBclass();
        public Form1()
        {
            InitializeComponent();
            ReadData();
            Calculate();
        }

        private void ReadData()
        {
            sqconn = new SQLiteConnection(@"Data Source=StorageDB.db");
            sqconn.Open();
            SQLiteCommand sqc = new SQLiteCommand("SELECT * FROM Items",sqconn);
            var reader = sqc.ExecuteReader(); //результат возвращаем в reader

            while (reader.Read())
            {
                screw.Text = reader[0].ToString();
                big_door.Text = reader[1].ToString();
                small_door.Text = reader[2].ToString();
                shelf.Text = reader[3].ToString();
            }
               
                //в данном примере запрос возвратил одну строку с одним столбцом - числовым значением, иначе используйте while и считывайте, пока строки не закончатся, а также при n столбцах - меняйте соответственно индекс, а также тип данных, в которфй конвертируете должен совпадать с типом столбца в БД
            reader.Close();
            sqconn.Close();
            
        }
        

        private void Calculate()
        {
            var calc_screv = Convert.ToInt64(screw.Text);
            var calc_big_door = Convert.ToInt64(big_door.Text);
            var calc_small_door = Convert.ToInt64(small_door.Text);
            var calc_shelf = Convert.ToInt64(shelf.Text);
            var count=0;
            while (calc_screv >= 10 && calc_big_door >= 2 && calc_shelf >= 2)
            {
                calc_screv -= 10;
                calc_big_door -= 2;
                calc_shelf -= 2;
                count++;
                possiblebench.Text = count.ToString();
            }

            calc_screv = Convert.ToInt64(screw.Text);
            calc_big_door = Convert.ToInt64(big_door.Text);
            calc_small_door = Convert.ToInt64(small_door.Text);
            calc_shelf = Convert.ToInt64(shelf.Text);
            count=0;
            while (calc_screv >= 20 && calc_big_door >= 2 && calc_shelf >= 5)
            {

                calc_screv -= 20;
                calc_big_door -= 2;
                calc_shelf -= 5;
                count++;
                possiblearchivelocker.Text = count.ToString();
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
           
            ReadData();
            Calculate();
        }





        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           

            sqconn = new SQLiteConnection(@"Data Source=StorageDB.db");
            sqconn.Open();
            SQLiteCommand sqc = new SQLiteCommand("UPDATE Items SET screw=@screw, big_door=@big_door, small_door=@small_door, shelf=@shelf", sqconn);
            if(textBox4.Text != null)
                sqc.Parameters.AddWithValue("@screw", textBox4.Text);
            if (textBox2.Text != null)
            {
                sqc.Parameters.AddWithValue("@big_door", textBox2.Text);
            }
            if(textBox1.Text != null)
                sqc.Parameters.AddWithValue("@small_door", textBox1.Text);
            if(textBox3.Text != null)
                sqc.Parameters.AddWithValue("@shelf", textBox3.Text);
            sqc.ExecuteNonQuery();
            sqconn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Calculate();
        }


    }
}