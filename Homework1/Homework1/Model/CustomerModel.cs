﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1.Model;

namespace Homework1.View.PresentationModel
{
    public class CustomerModel
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
        /// 取得讀檔後的資料傳回前端 並且設定總頁數
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        public List<Meal> ReadFile()
        {
            MealListFactory mealListFactory = new MealListFactory();
            return mealListFactory.ReadData();
        }

        /// <summary>
        /// 組合Meal Button Text
        /// </summary>
        /// <param name="mealButtonListIndex"></param>
        /// <returns></returns>
        public string CombineButtonText(int mealButtonListIndex)
        {
            return this.ReadFile()[mealButtonListIndex]._mealName + Constant.WRAP + Constant.MONEY_SYMBOL + this.ReadFile()[mealButtonListIndex]._mealPrice + Constant.DOLLARS;
        }
    }
}
