using UnityEngine;

public class Class03 : MonoBehaviour
{

    // 儲存帶有 person 類別的物件
    public person person1;
    public person person2;

    private void Start()
    {
        //呼叫 person1 方法 Talk
        person1.Talk();
        person2.Talk();

        //傳回方法可以直接當作傳回類型使用
        print("髒比 BMI :" + person1.BMI());
        print("警察杯杯 BMI :" + person2.BMI ());

        //使用有參數的方法必須填入對應的引數
        person1.walk(99, sound: "AHHH");
        person2.walk(10, "左邊");

        person1.Attack();
        person2.Attack("M16A");

        

    }
}
