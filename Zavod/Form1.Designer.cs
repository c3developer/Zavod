namespace Zavod
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.screw = new System.Windows.Forms.Label();
            this.big_door = new System.Windows.Forms.Label();
            this.small_door = new System.Windows.Forms.Label();
            this.shelf = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.possiblebench = new System.Windows.Forms.Label();
            this.possiblearchivelocker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "На складе имеется:";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Саморезы";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Большие Двери";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Двери тумбочки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Полки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Изменить склад";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(271, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(271, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(271, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(689, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Счет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // screw
            // 
            this.screw.AutoSize = true;
            this.screw.Location = new System.Drawing.Point(94, 65);
            this.screw.Name = "screw";
            this.screw.Size = new System.Drawing.Size(13, 15);
            this.screw.TabIndex = 16;
            this.screw.Text = "0";
            // 
            // big_door
            // 
            this.big_door.AutoSize = true;
            this.big_door.Location = new System.Drawing.Point(121, 92);
            this.big_door.Name = "big_door";
            this.big_door.Size = new System.Drawing.Size(13, 15);
            this.big_door.TabIndex = 17;
            this.big_door.Text = "0";
            // 
            // small_door
            // 
            this.small_door.AutoSize = true;
            this.small_door.Location = new System.Drawing.Point(124, 121);
            this.small_door.Name = "small_door";
            this.small_door.Size = new System.Drawing.Size(13, 15);
            this.small_door.TabIndex = 18;
            this.small_door.Text = "0";
            // 
            // shelf
            // 
            this.shelf.AutoSize = true;
            this.shelf.Location = new System.Drawing.Point(72, 151);
            this.shelf.Name = "shelf";
            this.shelf.Size = new System.Drawing.Size(13, 15);
            this.shelf.TabIndex = 19;
            this.shelf.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Обновить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Калькулятор мебели";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Возможное количество верстаков:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Возможное количество архивных шкафов:";
            // 
            // possiblebench
            // 
            this.possiblebench.AutoSize = true;
            this.possiblebench.Location = new System.Drawing.Point(673, 65);
            this.possiblebench.Name = "possiblebench";
            this.possiblebench.Size = new System.Drawing.Size(13, 15);
            this.possiblebench.TabIndex = 25;
            this.possiblebench.Text = "0";
            // 
            // possiblearchivelocker
            // 
            this.possiblearchivelocker.AutoSize = true;
            this.possiblearchivelocker.Location = new System.Drawing.Point(720, 89);
            this.possiblearchivelocker.Name = "possiblearchivelocker";
            this.possiblearchivelocker.Size = new System.Drawing.Size(13, 15);
            this.possiblearchivelocker.TabIndex = 26;
            this.possiblearchivelocker.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 238);
            this.Controls.Add(this.possiblearchivelocker);
            this.Controls.Add(this.possiblebench);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shelf);
            this.Controls.Add(this.small_door);
            this.Controls.Add(this.big_door);
            this.Controls.Add(this.screw);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private Button button3;
        private Label screw;
        private Label big_door;
        private Label small_door;
        private Label shelf;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label possiblebench;
        private Label possiblearchivelocker;
    }
}