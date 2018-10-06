using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1.Model;

namespace Homework1.View.PresentationModel
{
    class GetOrderData
    {
        private Order _order = new Order();
        /// <summary>
        /// 設定選取Meal
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        public Meal SetSelectedMeal(Meal meal)
        {
            _order.selectedMeal = meal;
            return _order.selectedMeal;
        }

        /// <summary>
        /// 取的選取Meal
        /// </summary>
        /// <returns></returns>
        public Meal GetSelectedMeal()
        {
            return _order.selectedMeal;
        }

        /// <summary>
        /// 取得訂購單
        /// </summary>
        /// <returns></returns>
        public List<Meal> GetOrderList()
        {
            return _order.orderMealList;
        }

        /// <summary>
        /// 增加訂購單
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        public List<Meal> SetOrderList(Meal meal)
        {
            _order.orderMealList.Add(meal);
            return _order.orderMealList;
        }
    }
}
