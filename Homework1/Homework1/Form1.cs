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
        private CustomerForm _customerForm = new CustomerForm();
        private Meal _meal = new Model.Meal(Constant.INITIAL, 0);
        private Order _order = new Model.Order();
        private List<Meal> _mealOrderList = new List<Meal>();
        private SetUpForm _setUpForm = new SetUpForm();
        public CustomerSide(FormData formData,SetUpForm setUpForm)
        {
            InitializeComponent();
            _setUpForm = setUpForm;
            _customerForm.ReadFile(_formData);
            this._formData = formData;
            #region Meal Button init
            #region Create Button List
            for (int i = 0; i < _customerForm.ReadFile(_formData).Count; i++)
            {
                _mealButtonList.Add(new Button());
                _mealGroupBox.Controls.Add(_mealButtonList[i]);
                _mealButtonList[i].Text = _customerForm.SetMealButtonText(i,_formData);
                _mealButtonList[i].Size = new Size(Constant.BUTTON_SIZE, Constant.BUTTON_SIZE);
                _mealButtonList[i].Name = i.ToString();
                _mealButtonList[i].Click += new EventHandler(this.MealButtonClick);
                _mealButtonList[i].Image = System.Drawing.Image.FromFile(@"..\..\..\img\MealButtonImg\" + i + Constant.GET_PICTURE);
                _mealButtonList[i].TextAlign = ContentAlignment.BottomLeft;
                _mealButtonList[i].ForeColor = Color.White;
            }
            MealButtonOption mealButtonOption = new MealButtonOption();
            SetMealButtonLocation(_customerForm.ReadFile(_formData));
            #endregion
            SetMealButtonOption();
            SetPageButtonEnable();
            SetPageButtonEnable();
            #endregion
            _pageLabel.Text = _customerForm.SetPageLabelText(_formData.nowPage, _formData.totalPage);
            _totalLabel.Text = _customerForm.SetTotalPriceLabel(_formData);
            //this.FormClosing();
        }
        /// <summary>
        /// 設定頁面按鈕狀態
        /// </summary>
        public void SetPageButtonEnable()
        {
            _nextPageButton.Enabled = _formData.SetNextPageButtonEnable();
            if (_formData.nowPage == 1)
            {
                _previousPageButton.Enabled = false;
            }
            else
            {
                _previousPageButton.Enabled = true;
            }
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
            _customerForm.UpdateNowPage(_formData, _previousPageButton.Name);
            SetMealButtonOption();
            SetPageButtonEnable();
            SetPageButtonEnable();
            _pageLabel.Text = _customerForm.SetPageLabelText(_formData.nowPage, _formData.totalPage);
        }

        /// <summary>
        /// 切換下一頁按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickNextPageButton(object sender, EventArgs e)
        {
            _customerForm.UpdateNowPage(_formData, _nextPageButton.Name);
            SetMealButtonOption();
            SetPageButtonEnable();
            SetPageButtonEnable();
            _pageLabel.Text = _customerForm.SetPageLabelText(_formData.nowPage, _formData.totalPage);
        }

        /// <summary>
        /// Meal Button 觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MealButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            _meal = _customerForm.ReadFile(_formData)[Int32.Parse(button.Name)];
            _mealDescriptionBox.Text = _meal._mealDescription;
        }

        /// <summary>
        /// Add Button 觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonClick(object sender, EventArgs e)
        {
            if (_meal.IsMealInitial(_meal))
            {
                _orderDataGridView.Rows.Add(Constant.DELETE,_meal._mealName, _meal._mealPrice);
                _mealOrderList.Add(_meal);
                //_formData.totalPrice = _order.SetTotalOrderListPrice(_formData.totalPrice);
                _formData.SetTotalOrderListPrice(_mealOrderList);
                _totalLabel.Text = _customerForm.SetTotalPriceLabel(_formData);
                _meal = new Meal(Constant.INITIAL, 0);
            }
        }

        /// <summary>
        /// DataGridView Delete Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] == _deleteButton && e.RowIndex < _mealOrderList.Count)
            {
                _orderDataGridView.Rows.Remove(_orderDataGridView.Rows[e.RowIndex]);
                _mealOrderList.RemoveAt(e.RowIndex);
                //_formData.totalPrice = _order.SetTotalOrderListPrice(_formData.totalPrice);
                _formData.SetTotalOrderListPrice(_mealOrderList);
                _totalLabel.Text = _customerForm.SetTotalPriceLabel(_formData);
            }
        }

        /// <summary>
        /// 複寫右上角X按鈕，開啟SetUpForm按鈕狀態
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            _setUpForm.SetCustomerSideButtonStatus();
        }
    }
}
