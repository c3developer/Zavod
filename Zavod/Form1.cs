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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            //this.screw.Text = sqc.ExecuteScalar().ToString();
            //this.big_door.Text = sqc.ExecuteScalar().ToString();
            sqconn.Close();
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}