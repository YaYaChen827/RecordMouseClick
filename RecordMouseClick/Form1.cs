using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordMouseClick
{
    public partial class mainform : Form
    {
        int count_dgv, count_play;
        List<int[]> cursorXY_play = new List<int[]>();

        public mainform()
        {
            InitializeComponent();
            count_play = 0;
        }

        private void recordTimer_Tick(object sender, EventArgs e)
        {             
            dgvCursor.Rows.Add(Cursor.Position.X.ToString(), Cursor.Position.Y.ToString());
        }

        private void playTimer_Tick(object sender, EventArgs e)
        {
            if (count_dgv != count_play)
            {
                Cursor.Position = new Point( Convert.ToInt32(dgvCursor.Rows[count_play].Cells[0].Value) , Convert.ToInt32(dgvCursor.Rows[count_play].Cells[1].Value));
                count_play++;
            }            
        }

        private void record_Click(object sender, EventArgs e)
        {
            dgvCursor.Rows.Clear();
            recordTimer.Start();
        }

        private void save_Click(object sender, EventArgs e)
        {
            count_dgv = dgvCursor.Rows.Count;
            recordTimer.Stop();
            playTimer.Stop();
        }

        private void play_Click(object sender, EventArgs e)
        {
            count_play = 0;
            playTimer.Start();
        }


    }
}
