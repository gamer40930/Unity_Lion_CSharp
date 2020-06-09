using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度"), Range(0, 100)]
    public float Speed;
    [Header("傷害值"), Range(0, 500)]
    public float damge;
    [Header ("爆炸效果")]
    public GameObject explosion;

    private void Awake()
    {
        // 物理2D 忽略圖層碰撞(圖層1 ,圖層2)
        Physics2D.IgnoreLayerCollision(8,8);
    }
    /// <summary>
    /// 移動
    /// </summary>
    protected void Move()
    {
        // Tiem.deltaTime
        transform.Translate(Speed * Time.deltaTime, 0, 0);
    }

    /// <summary>
    /// 爆炸
    /// </summary>
    protected  void Explosion()
    {
        // 生成爆炸效果
        GameObject exp = Instantiate(explosion ,transform .position ,Quaternion.identity);
        Destroy(gameObject);  // 刪除怪物
        Destroy(exp,1);    // 1 秒後刪除爆炸效果
    }

    protected virtual void Update()
    {
        Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name =="房子")
        {
            collision.gameObject.GetComponent<House>().Damage(damge); 
            Explosion();
        }
    }

}
