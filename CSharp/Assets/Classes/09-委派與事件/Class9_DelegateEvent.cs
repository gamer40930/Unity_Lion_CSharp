using UnityEngine;

public class Class9_DelegateEvent : MonoBehaviour
{
     
    public void Addten(int number)
    {
        int n = number += 10;
        print("數字累加:" + n);
    }

    public int number1 = 1;

    private void Awake()
    {
        Addten(9);
        Addten(number1);
    }

    public void MethodA()
    {
        print("我是方法A");
    }

    public void MethodB()
    {
        print("我是方法B");
    }

    // 簽名 : 無傳回，一個字串參數
    public void MethodC(string msg)
    {
        print("我是方法C - " + msg);
    }

    // 定義委派
    // 可以儲存 無傳回、無參數 的任何方法
    public delegate void DelegateTest();

    // 可以儲存 無傳回、一個字串參數的方法
    public delegate void DelegateTest_2(string s);

    // 定義委派欄位
    public DelegateTest dA;
    public DelegateTest dB;
    public DelegateTest dC;

    public DelegateTest d;
    public DelegateTest d2;

    public DelegateTest_2 d2C;

    private void Start()
    {
        dA = MethodA;   // dA 儲存方法A
        dA();           // 呼叫 dA

        dB = MethodB;
        dB();

        /*
        dC = MethodC;   // 不同簽名無法儲存
        dC();
        */
        d2C = MethodC;    // 儲存 方法C
        d2C("我是委派");


        d = MethodA;
        d += MethodB;
        d += MethodB;
        d();


       


    }

}
