using UnityEngine;



public enum Prop
{
    red,blue,yellow
}


public class Class05_IfSwitchLoop : MonoBehaviour

{
    [Header("是否開門")]
    public bool openDoor;
    [Header("分數"),Range(0,100)]
    public int Scorer = 0;
    [Header("血量"),Range(0,100)]
    public int HP = 90;
    [Header("道具")]
    public string Prop = "紅水";

    public Season season; //使用之前宣告的enum
    public Prop prop1;   // 測試switch藥水 用

 
    [Header("任務")]
    public int count;
    [Header("任務是否完成")]
    public bool complete;

    public string test;

    int i = 1;
    int j = 1;

    public int[] scores = { 100, 90, 80, 70, 60, 50 };
    #region 生成地板方式

    //GameObject 可以存放階層面板或專案物件內的模型
    public GameObject cube;

    public void CreatFloor(int length, int width)
    {

        // 巢狀迴圈
        // 注意初始值名稱不能相同
        for (int j = 0; j  < width ; j++)
        {
            for (int i = 0; i < length; i++)
            {
                // API 實例化 (生成
                // 生成(物件、座標、角度
                // Vector 3 三維向量 (保存三個浮點數)
                // Quaternion 角度
                // Quaternion.identity 零角度
                // Quaternion.Euler(x,y,z) 歐拉角度 - 0-360度

                Instantiate(cube, new Vector3(j * 2, 0, i * 2), Quaternion.Euler(270, 0, 0));  // * n 每排 + n 間距
            }
        }
      

    }

    #endregion
    private void Awake()
    {
        CreatFloor(30,5);   //生成地板

        #region foreach 迴圈
        //使用 for 取得陣列資料

        for (int i =0 ;i < scores .Length; i ++)
        {
            print("for 迴圈取得資料 : " + scores[i]);
        }

        // 使用 foreach 取得陣列資料
        // 語法 : foreach (取得資料的類型 取得資料的名稱 in 陣列) { 執行次數為陣列數量}
        foreach (int item in scores )
        {
            print("foreach 迴圈取得資料 : " + item );
        }

        #endregion

        #region while 迴圈
        // while 迴圈
        // while (布林值) {當布林值為 true 執行)
        // 迴圈之前評估 : 第一次判斷 i = 1
        while (i <= 10)
        {
            print("while 迴圈第 :" + i + "次");
            i++;
        }
        #endregion

        #region do 迴圈

        // 迴圈之後評估 : 第一次判斷 j = 2
        do
        {
            print("do 迴圈第 : " + j + "次");
            j++;
        } while (j <=10);

        #endregion

        #region for 迴圈
        for (int k = 0; k <= 10; k++)
        {
            print("for 迴圈 : " + k + "次");
        }

        for (int k = 10; k > 0 ; k--)
        {
            print("for 迴圈倒數 : " + k + "次");
        }
        #endregion
        /*
        for(int i = 1; i<101; i++)
        {
            print("break 迴圈" + i);
            // 如果 i 等於 10 就打斷迴圈並執行迴圈下方的程式
            if (i == 10) break; 
        }

        print("break 迴圈外的程式");
        

        for (int i = 0 ; i < 101; i++)
        {
            print("return 迴圈" + i);
            // 如果 i 等於 10 就跳出方法外，下方的程式皆不執行
            if (i == 10) return ;
        }

        print("return 迴圈外的程式");

        

        // 執行結果 : 0-4 6-19 迴圈外的程式
        for (int i = 0; i < 20; i++)
        {
            if (i == 5) continue;
            print("continue 迴圈: " + i);
        }

        print("continue 迴圈外的程式");
        */

        for (int i = 0; i < 10; i++)
        {
            // goto 標記名稱
            if (i == 5) goto test;
            print("goto迴圈" + i);
        }

        //標記名稱
    test:
        //標記陳述式
        print("這是標記陳述式");
    }

    private void Start()
    {
        // if 判斷式
        // if (布林值) {布林值 = true 時執行 }
        
        if (true)
        {
            print("哈囉，我是 IF 判斷式");
            
        }
    }   
    

    // 更新事件 : 一秒執行60次 
    private void Update()
    {
        #region 三元運算
        // 當道具數量 >=5 任務完成 true
        // 三元運算子語法 - 布林運算式 ? 運算式 A :運算式 B
        // 指派、呼叫 =()
        complete = (count >= 5) ? true : false;

        /* 利用判斷式 if 方式寫法
         if (complet >=5)
         {complete =  ture;}
         else 
         {complete =false;}
        */

        test = Scorer >= 60 ? "及格" : Scorer >= 40 ? "補考" : "被當";
        #endregion

        #region 開關門
        // 當 openDoor 為 true  執行 {開門}
        // 當 opneDoor 為 false 執行 {關門}
        // if (openDoor == true)
        if (openDoor)
        {
            print("開門");
        }

        else
        {
            print("關門");
        }
        #endregion

        #region 練習測試 enum +swich 寫法
        switch (prop1)
        {
            case global::Prop.red:
                print("補紅水");
                break;
            case global::Prop.blue:
                print("補藍水");
                break;
            case global::Prop.yellow:
                print("補黃水");
                break;
            default:
                print("沒");
                break;
        }
        #endregion

        #region  switch 吃藥水用法
        switch (Prop)
        {
            case "紅水":             // case 後要使用 : (冒號)
                print("補HP");
                break;              //一定要配 break

            case "藍水":
                print("補MP");
                break;

            case "黃水":
                print("補EXP");
                break;

            // default 可省略
            default:
                print("你吃錯道具了~");
                break;
        }
        #endregion

        #region switch使用 enum 列舉的方式
        switch (season)   // 按兩下TAB 可以選擇呼叫之前宣告的列舉 (class 04的 seasom)
        {
            case Season.Spring:
                print("春");
                break;
            case Season.Summer:
                print("夏");
                break;
            case Season.Fall:
                print("秋");
                break;
            case Season.Winter:
                print("冬");
                break;
            default:
                break;
        }
        #endregion

        #region IF分數判斷
        // 比較運算子、邏輯運算子結果為布林值
        // 大於等於 60 及格 ; 小於 60 不及格
        // 一組判斷式只會有有一個執行結果

        if (Scorer >= 60)  // true
        {
            print("及格");
        }

        else if (Scorer >= 40)
        {
            print("補考");
        }

        else if (Scorer >= 20)
        {
            print("付錢補考");
        }
        else
        {
            print("不及格 !!");
        }
        #endregion
        
        #region IF血量判斷

        if (HP >= 70)
        {
            print("安全");
        }

        else if (HP <= 20)
        {
            print("危險");
        }            

        else
        {
            print("警告");
        }
                
        #endregion

    }



}
