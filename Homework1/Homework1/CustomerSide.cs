using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework1.Model;
using Homework1.View.PresentationModel;

namespace Homework1
{
    public partial class CustomerSide : Form
    {
        private FormData _formData = new FormData();
        private List<Button> _mealButtonList = new List<Button>();
        private CustomerPresentationModel _customerPresentationModel = new CustomerPresentationModel(new CustomerModel());
        private CustomerModel _customerModel = new CustomerModel();
        public CustomerSide(FormData formData)
        {
            InitializeComponent();
            _customerModel = _customerPresentationModel.GetCustomerModelInstance(); 
            this._formData = formData;
            _customerPresentationModel.GetMealList();
            _customerPresentationModel.SetTotalPage(_formData);
            #region Meal Button init
            #region Create Button List
            for (int i = 0; i < _customerPresentationModel.GetMealList().Count; i++)
            {
                _mealButtonList.Add(new Button());
                _mealGroupBox.Controls.Add(_mealButtonList[i]);
                _mealButtonList[i].Text = _customerPresentationModel.SetMealButtonText(i);
                _mealButtonList[i].Size = new Size(Constant.BUTTON_SIZE, Constant.BUTTON_SIZE);
                _mealButtonList[i].Name = i.ToString();
                _mealButtonList[i].Click += new EventHandler(this.MealButtonClick);
                _mealButtonList[i].Image = System.Drawing.Image.FromFile(@"..\..\..\img\MealButtonImg\" + i + Constant.GET_PICTURE);
                _mealButtonList[i].TextAlign = ContentAlignment.BottomLeft;
                _mealButtonList[i].ForeColor = Color.White;
            }
            MealButtonOption mealButtonOption = new MealButtonOption();
            SetMealButtonLocation(_customerPresentationModel.GetMealList());
            #endregion
            SetMealButtonOption();
            SetPageButtonEnable();
            SetPageButtonEnable();
            #endregion
            _pageLabel.Text = _customerPresentationModel.SetPageLabelText(_formData.nowPage, _formData.totalPage);
            _totalLabel.Text = _customerPresentationModel.SetTotalPriceLabel(_formData);
            this._orderDataGridView.AllowUserToAddRows = false;
            _addButton.Enabled = false;
        }
        /// <summary>
        /// 設定頁面按鈕狀態
        /// </summary>
        public void SetPageButtonEnable()
        {
            _nextPageButton.Enabled = _formData.SetNextPageButtonEnable();
            _previousPageButton.Enabled = _customerPresentationModel.SetPreviousPageButtonStatus(_formData);
        }

        /// <summary>
        /// 設定MealButton位置
        /// </summary>
        public void SetMealButtonLocation(List<Homework1.Model.Meal> mealList)
        {
            MealButtonOption mealButtonOption = new MealButtonOption();
            for (int i = 0; i < mealList.Count; i++)
            {
                if (i % Constant.MAX_ROW_NUMBER == 0)
                {
                    _mealButtonList[i].Location = new System.Drawing.Point(Constant.INITIAL_X, Constant.INITIAL_Y + mealButtonOption.GetVariable(i));
                }
                else if (i % Constant.MAX_ROW_NUMBER == 1)
                {
                    _mealButtonList[i].Location = new System.Drawing.Point(Constant.INITIAL_X + Constant.SPACING, Constant.INITIAL_Y + mealButtonOption.GetVariable(i));
                }
                else
                {
                    _mealButtonList[i].Location = new System.Drawing.Point(Constant.INITIAL_X + Constant.SPACING + Constant.SPACING, Constant.INITIAL_Y + mealButtonOption.GetVariable(i));
                }
            }
        }

        /// <summary>
        /// 設定按鈕顯示
        /// </summary>
        public void SetMealButtonOption()
        {
            MealButtonOption mealButtonOption = new MealButtonOption();
            for (int i = 0; i < _mealButtonList.Count; i++)
            {
                if (mealButtonOption.GetButtonOption(_mealButtonList.Count, i, _formData))
                {
                    _mealButtonList[i].Visible = true;
                    _mealButtonList[i].Enabled = true;
                }
                else
                {
                    _mealButtonList[i].Visible = false;
                    _mealButtonList[i].Enabled = false;
                }
            }
        }

        /// <summary>
        /// 切換上一頁按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickPreviousPageButton(object sender, EventArgs e)
        {
            _customerPresentationModel.UpdateNowPage(_formData, _previousPageButton.Name);
            SetMealButtonOption();
            SetPageButtonEnable();
            _pageLabel.Text = _customerPresentationModel.SetPageLabelText(_formData.nowPage, _formData.totalPage);
            _addButton.Enabled = false;
            _customerModel.SetSelectedMeal(new Meal(Constant.INITIAL, 0));
            _mealDescriptionBox.Text = _customerModel.GetSelectedMeal()._mealDescription;
        }

        /// <summary>
        /// 切換下一頁按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickNextPageButton(object sender, EventArgs e)
        {
            _customerPresentationModel.UpdateNowPage(_formData, _nextPageButton.Name);
            SetMealButtonOption();
            SetPageButtonEnable();
            _pageLabel.Text = _customerPresentationModel.SetPageLabelText(_formData.nowPage, _formData.totalPage);
            _customerModel.SetSelectedMeal(new Meal(Constant.INITIAL, 0));
            _addButton.Enabled = false;
            _mealDescriptionBox.Text = _customerModel.GetSelectedMeal()._mealDescription;
        }

        /// <summary>
        /// Meal Button 觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MealButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            _customerModel.SetSelectedMeal(_customerPresentationModel.GetMealList()[Int32.Parse(button.Name)]);
            _mealDescriptionBox.Text = _customerModel.GetSelectedMeal()._mealDescription;
            _addButton.Enabled = true;
        }

        /// <summary>
        /// Add Button 觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonClick(object sender, EventArgs e)
        {
            _orderDataGridView.Rows.Add(Constant.DELETE, _customerModel.GetSelectedMeal()._mealName, _customerModel.GetSelectedMeal()._mealPrice);
            _customerModel.GetOrderList().Add(_customerModel.GetSelectedMeal());
            _formData.SetTotalOrderListPrice(_customerModel.GetOrderList());
            _totalLabel.Text = _customerPresentationModel.SetTotalPriceLabel(_formData);
        }

        /// <summary>
        /// DataGridView Delete Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] == _deleteButton)
            {
                _orderDataGridView.Rows.Remove(_orderDataGridView.Rows[e.RowIndex]);
                _customerModel.GetOrderList().RemoveAt(e.RowIndex);
                _formData.SetTotalOrderListPrice(_customerModel.GetOrderList());
                _totalLabel.Text = _customerPresentationModel.SetTotalPriceLabel(_formData);
            }
        }
    }
}
