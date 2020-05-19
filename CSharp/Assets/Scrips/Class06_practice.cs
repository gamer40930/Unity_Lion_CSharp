using UnityEngine;

public class Class06_practice : MonoBehaviour
{
    public SpriteRenderer kid;
    public Rigidbody ball;

    // Start is called before the first frame update
    void Start()
    {
        // 練習 1 :靜態屬性
        Time.timeScale = 2;
        print("遊戲速度" + Time.timeScale);

        // 練習 2 : 非靜態屬性
        kid.flipX = true;

        // 練習 3 : 靜態方法
        print("刪除小數點" + Mathf.Floor(1.23456f));

        // 練習 4 : 非靜態方法
        ball.AddForce(0, 500,1000);


    }

    

}
