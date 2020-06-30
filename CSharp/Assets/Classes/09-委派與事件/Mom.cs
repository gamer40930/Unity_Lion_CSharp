using UnityEngine;

namespace Kid.class9
{

    public class Mom : MonoBehaviour
    {
        // 訂閱者: 訂閱事件
        public Boy boy;

        private void Start()
        {
            // 1. 訂閱事件
            boy.onNoMoney += GiveMoney;

        }

           // 2. 實作方法
        private void GiveMoney()
        {
            print("怎麼這麼快就花完惹!!");
            boy.money += 1000;
        }


    }
}

