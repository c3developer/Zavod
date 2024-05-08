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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void ReadData()
        {
            using (sqconn)
            {
                using (SQLiteCommand sqc = new SQLiteCommand("SELECT screw FROM Items")) 
                {
                    sqconn.Open();
                    
                    label7.Text = sqc.ToString();
                    sqc.ExecuteNonQuery();
                }
                sqconn.Close();
            }
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
    }
}