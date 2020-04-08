using UnityEngine;

// 註解:用來說明、紀錄、筆記等..只會在腳本內看到
// 摘要(三條線) summary; 描述此內容,會在其他腳本內看到 - 提高維護性與擴充性
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
    // 資料類型 欄位名稱 (指定 值);
    // 預設值 int、float 為0
    // string 為 ""
    // bool 為 false
    int cc = 2000;  //點int +F12 可以看官方數值規範
    float weight = 100.9f; 
    string brand = "BMW"; 
    bool brake = false ;



}
