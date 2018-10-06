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
    public partial class StartUpForm : Form
    {
        public StartUpForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 開啟FrontEnd 視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCustomerSideButton(object sender, EventArgs e)
        {
            Form customerSide = new CustomerSide(new Model.FormData());
            _customerSideButton.Enabled = false;
            customerSide.Show();
            customerSide.FormClosed += new FormClosedEventHandler(this.SetCustomerSideButtonStatus);
        }

        /// <summary>
        /// 開啟BackEnd 視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickRestaurantSideButton(object sender, EventArgs e)
        {
            Form restaurantSide = new RestaurantSide();
            restaurantSide.Show();
            _restaurantSideButton.Enabled = false;
            restaurantSide.FormClosed += new FormClosedEventHandler(this.SetRestaurantSideButtonStatus);
        }

        /// <summary>
        /// 關閉程式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickExitButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 設定Restaurant Button 狀態
        /// </summary>
        public void SetRestaurantSideButtonStatus(object sender, FormClosedEventArgs e)
        {
            _restaurantSideButton.Enabled = true;
        }

        /// <summary>
        /// 設定前端的按鈕狀態
        /// </summary>
        public void SetCustomerSideButtonStatus(object sender, FormClosedEventArgs e)
        {
            _customerSideButton.Enabled = true;
        }
    }
}
