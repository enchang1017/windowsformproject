using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class RestaurantSide : Form
    {
        public RestaurantSide()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 按下OK按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCheckButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
