
/*
 * Created by: Jadon Fournier
 * Created on: 22-Feb-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - MovingObject
 * This program allows you to use a menu to change the image of a cat between 2 different images.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingObject
{
    public partial class frmMovingObject : Form
    {
        public frmMovingObject()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mniCat1_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat2;
        }
    }
}
