using UnityEngine;

public class Class06_StaticAPI : MonoBehaviour
{
    // 物件.宣告欄位
    public Enemy zombie1, zombie2;

    // 修飾詞 非靜態成員類別 物件名稱
    public GameObject Obj1;

    public Light m_Light;

    public Transform tran1;
    public Transform tran2;


     int a =0;

    void Start()
    {
        // 一般欄位
        // 取得方式 : 物件.欄位
        print(zombie1.name + "血量" + zombie1.hp );
        print(zombie2.name + "血量" + zombie2.hp );

        #region 練習靜態
        // 靜態欄位
        // 取得方式 : 類別.靜態物件
        print("殭屍的速度 : " + Enemy .speed);
        // 無法透過物件取得靜態欄位 (錯誤範例)
        // print(zombie.speed)

        // 使用一般方法
        // 物件.方法
        zombie1.Walk();
        zombie2.Walk();

        // 使用靜態方法
        // 類別.靜態方法
        Enemy.Stop();
        // 無法透過物件取得靜態物件 (錯誤範例)
        // zombie1.Stop();

        #endregion

        #region 靜態成員

        // 使用 API 靜態成員

        // 存放靜態屬性
        // 類別.靜態屬性 = 值
        Cursor.visible = false;

        // 取得 靜態 屬型

        print(Mathf.PI);

        // 取得 隨機 值
        print(Random.value);

        // 使用靜態方法
        // 類別.靜態方法 (對應的引數)
        print("絕對值 : " + Mathf.Abs(-66.6f));

        print("隨機範圍 : " + Random.Range(1f, 100f));
        //整數不傳回最大值
        print("隨機範圍 : " + Random.Range(1, 3));
        #endregion

        #region 非靜態成員

        // 錯誤: 非靜態不能透過類別存取
        // print(GameObject.Layer);

        // 靜態屬性與非靜態屬性區別
        // 靜態屬性      不需要新增欄位 - Random.Value
        // ㄈ非靜態屬性   需要新增欄位 - Public GameObject Obj1; Obj1.layer


        // 非靜態 屬性
        // 物件名稱.非靜態屬性
        print("物件圖層" + Obj1.layer);

        // 非靜態 需要有實體物件 - 存在於遊戲場景中的物件
        print("燈光顏色" + m_Light.color);


        // tran1.localScale = new Vector3(5, 5, 5);
        tran1.localScale = Vector3.one *2;
        


        #endregion

    }

    private void Update()
    {
        // true false
        // 原本用法: 字串
        print("是否按下空白鍵" + Input.GetKeyDown("space"));        
        if(Input .GetKeyDown ("space"))
        {
            a++;
            print("按下空白建"+a +"次");
        }

        //多載 1 : 列舉
        print("玩家是否案右鍵" + Input.GetKeyDown(KeyCode.Mouse1));


        // 非靜態方法
        // 物件名稱.非靜態方法(對應的引數)
        tran1.Rotate(0, 0, 10*Time.deltaTime);
        tran2.Rotate(0, 10, 0,Space .World);

        
    }

}
