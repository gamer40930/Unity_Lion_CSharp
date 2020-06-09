using UnityEngine;

public class Ship : MonoBehaviour
{
    // 公開的欄位 : 給任何人存取
    // 從其他類別取得或存放資料
    public float speed = 20;

    // 私人欄位 : 僅限於此類別存取
    // 從其他類別無法存取或存放資料
    private float weight = 50;

    #region prop 寫法
    // 問題 :
    // 假設要取得但不能修改 -- 屬性prop (權限)
    // 屬性語法
    // 修飾詞 類型 名稱 { 存取權限 }
    // get 可以存取
    // set 可以存放
    // 讀取權限屬性
    // 屬性不會顯示在屬性面板上 (ODIN) - UnityEditor

    public float length { get; set; }   // 輸入 prop 按兩下 TAB 鍵，會自動出現這串語法，修改類型後在按下兩下 TAB 鍵
    #endregion


    #region 封裝欄位寫法 1 
    // 企劃 : 寬度固定 30 不變
    // 封裝欄位 :  
    // 1. 私人欄位
    // 2.唯獨屬性 (return 私人欄位)
    private float _width = 30;

    // 唯獨屬性 : 不能給予預設值  (刪除了set 只有 get,所以只能存取)
    public float width { get { return _width; } }

    #endregion

    #region 封裝欄位寫法 2 
    // 企劃 : 固定高度 10.5
    private float _hight = 10.5f;   //點左邊小燈泡，選封裝欄位並使用屬性

    // => (黏巴達 Lambda)
    // C# 6版以上 | Unity 2017 C# 7版
    // C# 目前改版到 8 版
    // get => 寫法等於 get {return _height; }
    public float Hight { get => _hight; set => _hight = value; }

    #endregion

    private float lv = 3;

    // 企劃 : 攻擊力等於 攻擊力 *3
    // 封裝欄位 : 
    // 1. 私人欄位
    // 2. 透過屬性存取 (return 私人欄位) {私人欄位 = value}
    // value 設定屬性時給予的值
    private float _atk;
    public float Atk { get { return _atk; } set { _atk = value *lv ; } }


    //使用快速完成的黏巴達寫法 48 行與 52 行是相同的，只是版本不同
    public float Def { get => def; set => def = value * lv; }

    private float def;
}
