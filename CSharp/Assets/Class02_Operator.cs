using UnityEngine;

public class Class02_Operator : MonoBehaviour
{
    public float a = 10;
    public float b = 3;

    public string c = "7";
    public int d = 3;

    public int e = 99;
    public int f = 9;

    public bool g = true;
    public bool h = false;

    public int key;
    public int result;

    public int hp = 100;

    // 事件:開始事件 - 撥放遊戲時執行一次
    private void Start()
    {
        #region 數學運算子        
        // 數學運算子:加減乘除餘數 + - * / % 

        print(a + b);     // 13
        print(a - b);     // 7
        print(a * b);     // 30
        print(a / b);     // 3.3333
        print(a % b);     // 兩個數值相除剩下的值 -1

        // 加法:串接字串與其他資料 - 其結果為字串
        print("分數:" + 87.87f);        
        // 將字串與數值類型串接再一起不會運算 - 其結果為字串
        print(c + d);
        #endregion 

        #region 比較運算子
        // 比較運算子 : 結果為布林值 - 成立時為 true; 不成立時為 false 
        // 大於、小於、大於等於、小於等於、等於、不等於
        //  >    <      >=        <=     ==     !=

        print(e > f);     // true              
        print(e < f);     // false 
        print(e >= f);    // true 
        print(e <= f);    // false
        print(e == f);     // false
        print(e != f);    // true
        #endregion

        #region 邏輯運算子
        // 邏輯運算子 : 結果為布林值 - 比較兩個布林值
        // 並且 && 只要有一個為 false 結果為 false
        print("並且:" + (g && h));

        // 或者|| 只要有一個 true 結果為 true - 
        print("或者:" + (g || h));

        print(true && true );       // true
        print(true && false);       // falase
        print(false && true );      // false
        print(false  && false);     // false

        print(true || true);        // true
        print(true || false);       // true
        print(false || true);       // true
        print(false || false);      // false
        #endregion

        #region 顛倒運算子
        //顛倒運算子 : 加在布林值前 - 將布林值改為顛倒結果

        print(!true);
        print(!false);
        #endregion

        #region 指定運算子
        // 指定運算子 = 右邊先運算在指定給左邊      
        result = 2 + 3;
        print(result);

        key = key + 1;
        print("鑰匙 : " + key);  //key = 1
        #endregion

        #region 遞增
        //後製遞增 ++ : 先輸出在遞增
        print("鑰匙數量 : " + key++); //key = 1

        //前製遞增 ++ : 先遞增在輸出
        print("鑰匙數量 : " + ++key); //key = 3
        #endregion

        #region 指派運算子
        //指派運算子 : +=  -=  *=  /=  %=
        //hp = hp + 20; (120)

        hp += 20; //120
        print("血量:" + hp);

        //hp = hp -50 
        hp -= 50;
        print("血量:" + hp);

        //hp = hp*5
        hp *= 5;
        print("血量:" + hp);

        //hp = hp / 7
        hp /= 7;
        print("血量:" + hp);

        //hp = hp % 5
        hp %= 5;
        print("血量:" + hp);
        #endregion




    }

}
