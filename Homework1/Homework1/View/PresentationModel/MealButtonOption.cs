using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.View.PresentationModel
{
    public class MealButtonOption
    {
        const int SPACING = 179;
        const int MAX_ROW_NUMBER = 3;
        const int MAX_BUTTON_NUMBER = 9;
        /// <summary>
        /// 取得Y的變量
        /// </summary>
        /// <param name="index">i的序號</param>
        /// <returns></returns>
        public int GetVariable(int index)
        {
            if ((index / MAX_ROW_NUMBER) % MAX_ROW_NUMBER == 0)
            {
                return 0;
            }
            else if ((index / MAX_ROW_NUMBER) % MAX_ROW_NUMBER == 1)
            {
                return SPACING;
            }
            else
            {
                return SPACING + SPACING;
            }
        }

        /// <summary>
        /// 取得按鈕是否存在
        /// </summary>
        /// <param name="totalButtonNumber">按鈕總數</param>
        /// <param name="mealButtonIndex">按鈕序號</param>
        /// <param name="formData">ViewModel</param>
        /// <returns></returns>
        public bool GetButtonOption(int totalButtonNumber, int mealButtonIndex, Homework1.Model.FormData formData)
        {
            if (mealButtonIndex / MAX_BUTTON_NUMBER == formData.nowPage - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
