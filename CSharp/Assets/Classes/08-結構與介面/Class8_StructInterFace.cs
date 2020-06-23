using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class8_StructInterFace : MonoBehaviour
{
    // Unity 定義的結構 struct
    public Vector3 pos;

    public Direction myDirel;
    public Direction myDirel2 = new Direction (4);

    void Start()
    {

        // 使用結構成員
        // 三維向量結構 方法成員
        pos.Set(1, 2, 3);
        // 三維向量結構 欄位成員

        print("X座標:" + pos.x);

        // 指定結構成員
        myDirel.direction = 1;

        // 常數與靜態取得用法是一樣的
        print("方向右邊的值:" + Direction.right);

        // 錯誤:不能變更常數 
        // Direction.left = 5;

        myDirel.Set("左");
        print("方向" + myDirel.direction);

        print("第二筆方向資訊:" + myDirel2.direction);

    }

    // 類別一定要使用 new 新增物件
    // 結構可用可不用
    public Class_Data c_data1 = new Class_Data(); 
    public Struct_Data S_data1;

    // 類別 : 參考型別 - 傳址
    public Class_Data C2 = new Class_Data("50",9999, 100);
    public Class_Data C3 = new Class_Data("亮亮", 999999, 50);


    // 結構 : 實質類別 - 傳值
    public Struct_Data s2 = new Struct_Data("50", 9999, 100);
    public Struct_Data s3 = new Struct_Data("亮亮", 999999, 50);

    private void Awake()
    {
        c_data1.name = "50大大";
        print(c_data1.name);

        S_data1.name = "KID";
        print(S_data1.name);

        C2 = C3;          // C2 = C3 兩筆資料 地址 相同
        C2.name = "50";   // 修改 C2 等同於修改 c3

        s2 = s3;          // s2 = s3 兩筆資料 數值 相同
        s2.name = "50";   // 修改 s2 不會修改到 s3


    }
}
