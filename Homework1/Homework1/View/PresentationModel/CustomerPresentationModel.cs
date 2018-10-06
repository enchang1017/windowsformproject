using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1.Model;

namespace Homework1.View.PresentationModel
{
    public class CustomerPresentationModel
    {
        private CustomerModel _customerModel = new CustomerModel();

        public CustomerPresentationModel(CustomerModel customerModel)
        {
            _customerModel = customerModel;
        }
        /// <summary>
        /// 觸發按鈕更新現在頁數
        /// </summary>
        /// <param name="formData"></param>
        public void UpdateNowPage(Homework1.Model.FormData formData, string buttonName)
        {
            if (buttonName == Constant.NEXT_BUTTON)
            {
                formData.nowPage += 1;
            }
            else
            {
                formData.nowPage -= 1;
            }
        }

        /// <summary>
        /// 設定上一頁按鈕是否Enable
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        public bool SetPreviousPageButtonEnable(Homework1.Model.FormData formData)
        {
            if (formData.nowPage == 1)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 設定page label 的 Text
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        public string SetPageLabelText(int nowPage, int totalPage)
        {
            return Constant.PAGE_LABEL_TEXT_PAGE + nowPage + Constant.SLASH + totalPage;
        }

        /// <summary>
        /// 設定total price Label Text
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        public string SetTotalPriceLabel(Homework1.Model.FormData formData)
        {
            return Constant.TOTAL_PRICE + formData.totalPrice + Constant.DOLLARS;
        }

        /// <summary>
        /// 計算Total Price
        /// </summary>
        /// <param name="formData"></param>
        /// <param name="meal"></param>
        /// <returns></returns>
        public int SetTotalPrice(Homework1.Model.FormData formData, Homework1.Model.Meal meal)
        {
            return formData.totalPrice += meal._mealPrice;
        }

        /// <summary>
        /// 設定Meal Button的文字內容
        /// </summary>
        /// <param name="mealButtonListIndex"></param>
        /// <param name="formData"></param>
        /// <returns></returns>
        public string SetMealButtonText(int mealButtonListIndex)
        {
            return _customerModel.CombineButtonText(mealButtonListIndex);
        }

        /// <summary>
        /// 取得Meal List
        /// </summary>
        /// <returns></returns>
        public List<Meal> GetMealList()
        {
            return _customerModel.ReadFile();
        }

        /// <summary>
        /// 設定總頁數
        /// </summary>
        /// <param name="formData"></param>
        public void SetTotalPage(FormData formData)
        {
            formData.totalPage = _customerModel.ReadFile().Count / Constant.MAX_MEAL_BUTTON_NUMBER + 1;
        }

        /// <summary>
        /// 取的CustomerModel
        /// </summary>
        /// <returns></returns>
        public CustomerModel GetCustomerModelInstance()
        {
            return _customerModel;
        }

        /// <summary>
        /// 設定上一頁按鈕狀態
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>

        public bool SetPreviousPageButtonStatus(FormData formData)
        {
            if (formData.nowPage == 1)
            {
                return false;
            }
            return true;
        }
    }
}
