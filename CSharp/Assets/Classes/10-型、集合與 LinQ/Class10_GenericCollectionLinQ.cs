using UnityEngine;



namespace KID.Class10
{
    public class Class10_GenericCollectionLinQ : MonoBehaviour
    {


        // 不使用泛型的方法
        public CharacterFloat cF = new CharacterFloat(100.5f, 50f, 10.2f); // 角色浮點數
        public CharacterInt cI = new CharacterInt(100, 50, 10);            // 角色整數

        // 使用泛型的方法
        public Character<float> c1 = new Character<float>(99.9f,9.9f,9.6f);     // 使用泛型: 給予浮點數
        public Character<int> c2 = new Character<int>(50,50,50);                // 使用泛型: 給予整數
        public Character<long> c3 = new Character<long>(100000, 100000, 10000); // 使用泛型: 給予整數


        // 不使用泛型
        // 假設系統需要腳色類別 :
        // 1. 浮點數欄位 - 血量、經驗值、魔力、攻擊力
        // 2. 整數欄位 -  血量、經驗值、魔力、攻擊力
        public class CharacterFloat
        {
            public float hp;
            public float mp;
            public float exp;
            public float atk;

            // 建構子 : 跟類別名稱相同並且無傳回的方法 - 再新增物件時候執行
            public CharacterFloat(float h, float m, float a)
            {
                hp = h; mp = m; atk = a;
            }
        }



        // 不使用泛型
         public class CharacterInt 

         {
            // 多個游標選取 : Alt + shift + >
            public int hp;
            public int mp;
            public int exp;
            public int atk;

            // 建構子 : 跟類別名稱相同並且無傳回的方法 - 再新增物件時候執行
            public CharacterInt(int h, int m, int a)
            {
                hp = h; mp = m; atk = a;
            }
        }
    }


        // 還要多一個常整數 long


        // 使用泛型 T 泛型
        public class Character<T>
        {
            public T hp;      // 欄位的類型為泛型
            public T mp;
            public T exp;
            public T atk;
           
            public Character(T h,T m,T a)
            {
            hp = h; mp = m; atk = a;
            }

        }


    

}
