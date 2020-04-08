using UnityEngine;

// 註解:用來說明、紀錄、筆記等..只會在腳本內看到
// 摘要(三條線) summary; 描述此內容,會在其他腳本內看到 - 提高維護性、擴充性、方便好讀!!
// 新增的 C# 放在專案內為藍圖
// 放在場景物件上為實體物件
/// <summary>
/// 定義汽車物件
/// </summary>
public class Car : MonoBehaviour
{
    // 認識第一個成員 : 欄位 field - 儲存物件資料
    // 資料類型:
    // C.C 數      - 2000          - 整數  int 
    // 重量        - 100.2         - 浮點數  float
    // 品牌        - BMW           - 字串  string
    // 剎車        - 是否開放      - 布林值 bool  

    // 定義欄位於法
    // 修飾詞 資料類型 欄位名稱 (指定 值);
    // 1.公開 public (會顯示在屬性面板, 允許其他類別忖取)
    // 私人 praviate (預設) 不顯示, 不允許
    // 預設值 int、float 為0
    // string 為 ""
    // bool 為 false
    // 欄位屬性 Attribute : Unity 用於輔助欄位的功能
    // 語法 : [屬性名稱(值)]
    // 標題 [Header("字串")]
    // 小提示 [Tooltip("字串")] - 游標停留時顯示
    // 範圍 [Range(最小值, 最大值] - 僅限於數值型資料 int、float
    

    /// <summary>
    /// 汽車CC數
    /// </summary>
    [Header("汽車CC數"), Tooltip ("CC數"), Range(1000, 10000)]
    public int cc = 2000;  // 點int + F12 可以看官方數值規範

    /// <summary>
    /// 汽車重量
    /// </summary>
    [Header("汽車重量"), Tooltip("這格是存放汽車噸位用"), Range(1000, 10000)]
    public float weight = 100.9f;

    /// <summary>
    /// 汽車品牌
    /// </summary>
    [Header("汽車品牌"), Tooltip("這台汽車的品牌")]
    public string brand = "BMW";

    /// <summary>
    /// 是否煞車
    /// </summary>
    [Header("是否煞車"), Tooltip("用來儲存目前車子是否為煞車狀態")]
    public bool brake = false ;



}
