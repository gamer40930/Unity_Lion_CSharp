using UnityEngine; //引用Unity API(函式庫:Unity 屬性、功能...)

//類別 class 定義一個物件
//語法:class 類別名稱
//:MonoBehaviour 可將此腳本掛在Unity物件上
// 類別必須放在物件上才能執行
public class Class01 : MonoBehaviour
{
    // 定義類別成員
    // C#
    // 1.大小寫不一樣
    // 2.括號成對出現 () {} [] '' "" < >

    //事件:特定時間會已指定次數執行的方法 (名稱為藍色)

    private void Start()//開始事件:播放遊戲時執行一次 - 初始事件
    {
        print("HI WORLD!"); //輸出("文字訊息")
    }

}
