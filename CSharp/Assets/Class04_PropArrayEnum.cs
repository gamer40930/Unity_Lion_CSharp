using UnityEngine;

public class Class04_PropArrayEnum : MonoBehaviour
{

    public Ship ship;

    private void Start()
    {

        //屬性設定
        ship.lenght = 99.9f;
        //取得屬性
        print("船的長度" + ship.lenght );


        // 設定唯獨屬性 
        // ship.width = 20.5f; // 錯誤
        print("船的寬度" + ship.width);

        ship.Atk = 50.3f;
        print("船的攻擊力" + ship.Atk);
    }
}
