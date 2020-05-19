using UnityEngine;

public class person : MonoBehaviour
{

    [Header("身高")]
    public float height;
    [Header("體重")]
    public float weight;



    // 定義方法語法 :
    // 修飾詞 傳回類型 方法名稱 (參數){陳述式}
    // void 無回傳 : 當使用此方法時不會得到任何回傳資料
    public void Talk()
    {

        //gameObject 套用此腳本的物件
        //gameObject 套用此腳本的物件的名稱
        print("Hello ~IT's me ~我是" + gameObject.name   );
        


     }

    //傳回方法:傳回類型不是void
    //使用此方法會得到回傳資料，必須使用關鍵字 return 
    /// <summary>
    /// 計算人的BMI
    /// </summary>
    /// <returns>計算完的BMI</returns>
    public float BMI()
    {
        //BMI 公式 : 體重（公斤）除以身高（公尺）的平方

        float result = weight / ((height / 100) * (height / 100));
        //傳回 return
        return result;
    }

    public void Walk10()
    {
        print("用時速 10 公里走路");
        print("走路音效");

       
    }
    public void Walk20()
    {
        print("用時速 20 公里走路");
        print("走路音效");

    }

    //參數語法 : 類型 名稱 指定 預設值
    //有預設值的參數為【選填式參數】 - 可以不填，值為預設值
    /// <summary>
    /// 走路方法
    /// </summary>
    /// <param name ="speed"> 需要以多少速度走路 </param>
        public void walk(int speed, string direction = "前方", string sound = "嘎嘎嘎")
    {
        print(gameObject .name + "用時速" + speed + "公里走路");
        print("走路音效 : " + sound );
        print(gameObject .name + "走路方向" + direction);

    }

    // 攻擊方法 : 徒手
    public void AttackWithHand()
    {

    }
    // 攻擊方法 : 武器，音效
    public void AttackWithWeapon()
    {

    }

    // 多載 Overload
    // 1.相同名稱的方法
    // 2.參數數量不同 或者 參數類型不同
    /// <summary>
    /// 徒手攻擊
    /// </summary>
    public void Attack()  //0 參數
    {
        print(gameObject.name + "徒手攻擊!!"); 
    }

    /// <summary>
    /// 武器攻擊
    /// </summary>
    /// <param name="weapon"> 想要使用的武器</param> 
    public void Attack(string weapon) // 1個參數
    {
        print(gameObject.name + "用武器" + weapon + "攻擊!!!");
        print("攻擊音效");
    }

    
    // 讓unity 使用button 使用方法條件:
    // 1.修飾詞為公開 public 
    // 2.參數數量小於等於 1
    /// <summary>
    /// 技能
    /// </summary>
    public void skill()
    {
        print(gameObject.name + "施發技能");
    }

}
