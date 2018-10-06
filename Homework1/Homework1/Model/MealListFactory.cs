using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Model
{
    public class MealListFactory
    {
        const char SPLIT_CONDITION = ' ';
        /// <summary>
        /// 開檔讀檔 並寫入mealList
        /// </summary>
        /// <returns></returns>
        public List<Meal> ReadData()
        {
            List<Meal> mealList = new List<Meal>();
            StreamReader streamReader = new StreamReader(@"..\..\..\Data\MealData.txt");
            while (!streamReader.EndOfStream)
            {
                string Access = streamReader.ReadLine();
                string[] splitAccess = Access.Split(SPLIT_CONDITION);
                mealList.Add(new Meal(splitAccess[0], Int32.Parse(splitAccess[1])));
            }
            streamReader.Close();
            SetMealDescription(mealList);
            return mealList;
        }

        /// <summary>
        /// 設定菜單簡介
        /// </summary>
        /// <param name="mealList"></param>
        public void SetMealDescription(List<Meal> mealList)
        {
            int count = 0;
            StreamReader streamReader = new StreamReader(@"..\..\..\Data\MealDescription.txt");
            while (!streamReader.EndOfStream)
            {
                string Access = streamReader.ReadLine();
                mealList[count]._mealDescription = Access;
                count++;
            }
            streamReader.Close();
        }
    }
}
