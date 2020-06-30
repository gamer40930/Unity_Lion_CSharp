using UnityEngine;

// 命名空間
namespace Kid.class9 
{

    public class Boy : MonoBehaviour
    {
        // 1.
        // 定義委派:
        // 簽名: 無回傳 無參數 無類型
        public delegate void DelegatBoy();

        // 2.
        // 定義事件  (不用加小括弧)
        // 修飾詞 事件 委派類型 事件名稱
        // 習慣開頭用 On 命名
        public event DelegatBoy onNoMoney;


        public int money = 1000;


        private void Update()
        {

            money -= 1; // 1 秒扣 60

            if (money == 0)
            {
                print("阿母阿~我沒錢啦");
                onNoMoney();   // 3. 引發事件
            }

        }




    }


}

