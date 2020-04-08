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

    [Header ("Car01")]
    public Car car01; //招喚Car的腳本資料 & 使用它

    [Header("Car02")]
    public Car car02 ; //招喚Car的腳本資料 & 使用它


    //事件:特定時間會已指定次數執行的方法 (名稱為藍色)
    //開始事件:播放遊戲時執行一次 - 初始事件
    private void Start()
    {
        //輸出("文字訊息")
        print("HI WORLD!"); 

        // 取得 get

        print("car01的CC數是" + car01.cc);
        print("car01的品牌是" + car01.brand);
        print("car02的品牌是" + car02.brand);

        // 設定 set
        //移動程式碼快捷鍵 ALT + 上下
        car01.cc = 9999;
        car01.weight = 2000.55f;
        car01.brand = "Bently";
        car01.brake = true;





    }




}
