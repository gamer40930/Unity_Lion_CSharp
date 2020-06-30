using UnityEngine;
using System.Collections.Generic; // List - 泛型
using System.Collections;         // Array List  


namespace KID.Class10
{

    public class Class10_Collection : MonoBehaviour
    {
        #region List、ArrayList

        // 陣列 : 固定後陣列長度無法改變
        public int[] scores = {100,90,80,70,60 };

        // 集合 : 彈性
        // 清單
        public List<float> hp = new List<float> { 99.9f, 88.8f, 77.7f };

        public List<float> hpResult = new List<float>();

        // AarryList 
        public ArrayList numbers = new ArrayList();


        // 排序
        public List<int> count = new List<int> {9,100,15,17,30,888,123 };

        private void Start()
        {
            // 1. 集合可以改變長度
            hp.Add(66.6f);           // 清單.增加(T)
            hp.Remove(88.8f);        // 清單.刪除(T)
            print("是否包含 66.6 :" + hp.Contains(66.6f));  // 是否包含(T)


            hpResult =  hp.FindAll((x) =>  x >= 70f);                 // 搜尋所有(大於等於70)資料



            #region ArrayList 範例

            // ArrayList 與 LList 差異
            // Array List 為 object 類型 : 可存放所有類型
            // List 為泛型: 一但指定類型就只能存放一種類型 List<int> - int
            // ArrayList 不會顯示在屬性面板

            numbers.Add(100);
            numbers.Add(77.7f);
            numbers.Add("123");
            numbers.Add(true);

            #endregion


            // 排序
            count.Sort();       // 由小到大
            count.Reverse();    // 反轉

        }
        #endregion

        #region 佇列與堆疊

        // 佇列:
        // 1.添加資料到尾端
        // 先進先出
        public Queue<int> lv = new Queue<int>();

        // 堆疊
        // 2.添加資料到頂端
        // 後進先出
        public Stack<int> n = new Stack<int>();

        public Queue<string> people = new Queue<string>();
        public Stack <string> box = new Stack<string>();

        private void Awake()
        {
            // 添加佇列資料
            lv.Enqueue(10);    
            lv.Enqueue(20);
            lv.Enqueue(30);

            foreach (var item in lv )
            {
                print("佇列的資料:" + item);
            }

            // 添加堆疊資料
            n.Push(10);        
            n.Push(20);
            n.Push(40);

            foreach (var item in n)
            {
                print("堆疊的資料:" + item);
            }


            people.Enqueue("亮亮");
            people.Enqueue("50");
            people.Enqueue("KID");


            box.Push("盒子1號");
            box.Push("盒子2號");
            box.Push("盒子3號");

        }

        private void Update()
        {
            // 佇列 : 先進先出
            if (Input.GetMouseButtonDown(0)) print("排隊的第一個人" + people.Dequeue());
            // 堆疊 : 先進後出
            if (Input.GetMouseButtonDown(1)) print("堆放的第一個箱子" + box.Pop());
        }


        #endregion

        #region 雜湊表、字典

        // 兩個關鍵字
        // Key、Value - 關鍵字、值

        // 差異
        // 雜湊表 - 物件
        // 字典 - 泛型

        // 雜湊表        
        public Hashtable player = new Hashtable();

        // 字典 - 關鍵字 (字串)，值(整數)
        public Dictionary<string, int> data = new Dictionary<string, int>();

        // 物件啟動時執行事件
        private void OnEnable()
        {
            // 雜湊表
            player.Add("Lv",99);
            player.Add("Hp",499);
            player.Add("Mp",299);

            // DictionaryEntry 結構 - 儲存 Key 與 Value
            foreach (DictionaryEntry item in player )
            {
                print("雜湊表資料 KEY :" + item.Key);
                print("雜湊表資料 Value : " + item.Value);

            }


            // 字典
            data.Add("短刀", 30);
            data.Add("樹枝", 10);
            data.Add("屠龍刀", 100000);

            foreach (KeyValuePair<string,int>  item in data )
            {
                print("字典的 Key :" + data.Keys);
                print("字典的 Value :" + data.Values);
            }


            // 用陣列或清單存取資料時候只能透過索引值 index - 0 1 2 3 4 ...
            // 用 雜湊表 和 字典 可以使用 Key 存取資料 - "屠龍刀"、"Lv"
            print("價格:" + data["屠龍刀"]);
            print("等級:" + player ["Lv"]);
            

        }

        #endregion

    }

}
