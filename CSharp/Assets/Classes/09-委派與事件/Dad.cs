using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kid.class9
{

    public class Dad : MonoBehaviour
    {
        // 訂閱者: 訂閱事件
        public Boy boy;


        private void Start()
        {
            // 1. 訂閱事件
            boy.onNoMoney += HitBoy;
            boy.onNoMoney += GiveMOney;

        }

        // 2. 實作方法
        private void GiveMOney()
        {
            boy.money += 10;
            print("給你十塊錢");

        }

        // 2. 實作方法
        private void HitBoy()
        {
            print("欠揍阿!!");
        }


    }

}
