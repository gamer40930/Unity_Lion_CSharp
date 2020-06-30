using System.Collections;
using System.Collections.Generic; // List<T> Dictionary<TK,TV>、Queue<T>、stack<T>
using UnityEngine;
using System.Linq;  // 使用系統的Linq


namespace KID.Class10
{

    public class Class10_LinQ : MonoBehaviour
    {
        public int[] numbers = { 7, 50, 98, 8, 3, 6, 15, 22 };

        public List<float> atk = new List<float> { 2f, 56.1f, 34f, 1f, 23f };

        private void Start()
        {
            // LinQ 查詢語法
            // 區域變數
            var even =
                from data in numbers     // 在陣列 numbers 取得資料 存在 data
                where (data % 2) == 0    // 條件 資料 與2 餘數 為0
                select data;             // 選取 符合條件的 資料

            foreach (var item in even)
            {
                print("所有偶數:" + item);
            }

            var odd =
                from data in numbers
                where (data % 2) == 1
                orderby data ascending   // 排序 資料 由小到大 ascending ; 由大到小 descneding
                select data;

            foreach (var item in odd)
            {
                print("所有奇數:" + item);
            }


            // LinQ 方法語法
            print("總和:" + atk.Sum());
            print("總和:" + atk.Average ());
            print("總和:" + atk.Min ());
            print("總和:" + atk.Max());

            var a20 = atk.Where((x) => x <= 20);
            foreach (var item in a20 )
            {
                print("小於 20 的資料:" + item);
            }

        }

    }
}
