using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.RowHeadersWidth = 100;
        }

        //┏==================================================================================================================================================┒
        //│    ↓  ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓    핫키부분  1   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓ │
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, System.Windows.Forms.Keys vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int HOTKEY_ID = 31198; //Any number to use to identify the hotkey instance 
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Windows = 8
        }
        const int WM_HOTKEY = 0x0312;
        //│    ↑  ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑    핫키부분  1   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑ │
        //┖==================================================================================================================================================┛ 

        private void Form1_Load(object sender, EventArgs e)
        {

            //┏==================================================================================================================================================┒
            //│    ↓  ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓    핫키부분  3   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓ │
            RegisterHotKey(this.Handle, HOTKEY_ID, 0x0, System.Windows.Forms.Keys.F1);
            RegisterHotKey(this.Handle, HOTKEY_ID, KeyModifiers.Control, Keys.NumPad0); // shift + A  
            RegisterHotKey(this.Handle, HOTKEY_ID, KeyModifiers.Control, Keys.NumPad1); // shift + A  
            RegisterHotKey(this.Handle, HOTKEY_ID, KeyModifiers.Control, Keys.NumPad2); // shift + A  
            RegisterHotKey(this.Handle, HOTKEY_ID, KeyModifiers.Control, Keys.NumPad3); // shift + A  
            RegisterHotKey(this.Handle, HOTKEY_ID, KeyModifiers.Control, Keys.NumPad4); // shift + A  
            RegisterHotKey(this.Handle, HOTKEY_ID, KeyModifiers.Control, Keys.NumPad5); // shift + A  
            RegisterHotKey(this.Handle, HOTKEY_ID, KeyModifiers.Control, Keys.NumPad6); // shift + A  
            RegisterHotKey(this.Handle, HOTKEY_ID, KeyModifiers.Control, Keys.NumPad7); // shift + A  
            RegisterHotKey(this.Handle, HOTKEY_ID, KeyModifiers.Control, Keys.NumPad8); // shift + A  
            RegisterHotKey(this.Handle, HOTKEY_ID, KeyModifiers.Control, Keys.NumPad9); // shift + A  
            //RegisterHotKey(this.Handle, HOTKEY_ID, KeyModifiers.Control | KeyModifiers.Shift, Keys.N);    // Hotkeyset 핫키생성 [ 특수키 0x0면 입력안받는상태 ]
            //UnregisterHotKey(this.Handle, HOTKEY_ID);                                                     // Hotkeyset 핫키해제 [ HOTKEY_ID 번호인 핫키 해제 ]
            //│    ↑  ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑    핫키부분  3   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑ │
            //┖===
        }
        int cheat = -1;
        int cheat2 = 0;
        //┏==================================================================================================================================================┒
        //│    ↓  ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓    핫키부분  2   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓   ↓ │
        protected override void WndProc(ref Message message)
        {
            switch (message.Msg)
            {
                case WM_HOTKEY:
                    System.Windows.Forms.Keys key = (System.Windows.Forms.Keys)(((int)message.LParam >> 16) & 0xFFFF);
                    KeyModifiers modifier = (KeyModifiers)((int)message.LParam & 0xFFFF);
                    //if ((KeyModifiers.Control | KeyModifiers.Shift) == modifier && Keys.N == key)
                    if (System.Windows.Forms.Keys.F1 == key)                                          //  F1 핫키
                    { 
                    }
                    if ((KeyModifiers.Control) == modifier && Keys.NumPad0 == key)                                                        //  F1 핫키
                    {
                        cheat = -1;
                        cheat2 = cheat;
                    }
                    if ((KeyModifiers.Control) == modifier && Keys.NumPad1 == key)                                                        //  F1 핫키
                    {
                        cheat = 1;
                        cheat2 = cheat;
                        lotto.Add(1);
                    }
                    if ((KeyModifiers.Control) == modifier && Keys.NumPad2 == key)                                                        //  F1 핫키
                    {
                        cheat = 2;
                        cheat2 = cheat;
                        lotto.Add(2);
                    }
                    if ((KeyModifiers.Control) == modifier && Keys.NumPad3 == key)                                                        //  F1 핫키
                    {
                        cheat = 3;
                        cheat2 = cheat;
                        lotto.Add(3);
                    }
                    if ((KeyModifiers.Control) == modifier && Keys.NumPad4 == key)                                                        //  F1 핫키
                    {
                        cheat = 4;
                        cheat2 = cheat;
                        lotto.Add(4);
                    }
                    if ((KeyModifiers.Control) == modifier && Keys.NumPad5 == key)                                                        //  F1 핫키
                    {
                        cheat = 5;
                        cheat2 = cheat;
                        lotto.Add(5);
                    }
                    if ((KeyModifiers.Control) == modifier && Keys.NumPad6 == key)                                                        //  F1 핫키
                    {
                        cheat = 6;
                        cheat2 = cheat;
                        lotto.Add(6);
                    }
                    if ((KeyModifiers.Control) == modifier && Keys.NumPad7 == key)                                                        //  F1 핫키
                    {
                        cheat = 7;
                        cheat2 = cheat;
                        lotto.Add(7);
                    }
                    if ((KeyModifiers.Control) == modifier && Keys.NumPad8 == key)                                                        //  F1 핫키
                    {
                        cheat = 8;
                        cheat2 = cheat;
                        lotto.Add(8);
                    }
                    if ((KeyModifiers.Control) == modifier && Keys.NumPad9 == key)                                                        //  F1 핫키
                    {
                        cheat = 9;
                        cheat2 = cheat;
                        lotto.Add(9);
                    }
                    break; 
            }
            base.WndProc(ref message);
        }
        //│    ↑  ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑    핫키부분  2   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑   ↑ │
        //┖==================================================================================================================================================┛


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var team = textBox1.Text.Split('\n');
            label1.Text = team.Length.ToString();

            dataGridView1.RowCount = team.Length;
            foreach (var tmp in team.Select((value, index) => (value, index)))
            {
                dataGridView1.Rows[tmp.index].HeaderCell.Value = tmp.value;
            }

            dataGridView1.ColumnCount = team.Length;
            foreach (var tmp in team.Select((value, index) => (value, index)))
            {
                dataGridView1.Columns[tmp.index].Name = "";
            }
            try
            {
                textBox2_TextChanged(null, null);
            }
            catch { }
        }

        int recent_index = 0;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var team = textBox2.Text.Split('\n');
            label2.Text = team.Length.ToString();

            try
            {
                dataGridView1.Columns[recent_index].Name = "";
                dataGridView1.Columns[Convert.ToInt32(textBox2.Text) - 1].Name = "담배";
                recent_index = Convert.ToInt32(textBox2.Text) - 1;
            }
            catch
            {
                dataGridView1.Columns[recent_index].Name = "";
            }
        }
        List<int> lotto = new List<int>();
        int iSelect;

        private void button1_Click(object sender, EventArgs e)
        {
            lotto = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (var tmp in textBox1.Text.Split('\n').Select((value, index) => (value, index)))
                {
                    row.Cells[tmp.index].Value = "";
                }
            }
            var i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var rand = new Random();
                int r = rand.Next(0, dataGridView1.ColumnCount);
                if (cheat != -1 && row.Index == cheat - 1)
                {
                    iSelect = Convert.ToInt32(textBox2.Text)-1;

                    lotto.Add(iSelect);
                    Console.WriteLine(lotto[i]); //output 39 35 7 44 15 8

                    Thread.Sleep(100);
                    row.Cells[Convert.ToInt32(textBox2.Text)-1].Value = "O";
                    i++;
                    cheat = -1;
                }
                else
                {
                    do
                    {
                        iSelect = new Random().Next(0, dataGridView1.ColumnCount); //범위 입력 필요, 1<= value < 46
                    }
                    while (lotto.Contains(iSelect));
                    lotto.Add(iSelect);
                    Console.WriteLine(lotto[i]); //output 39 35 7 44 15 8

                    Thread.Sleep(100);
                    row.Cells[lotto[i]].Value = "O";
                    i++;
                }
                cheat = cheat2;

            }
        }
         

    } 
}
