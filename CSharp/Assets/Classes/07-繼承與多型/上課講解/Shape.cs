using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [Header ("長寬高")]
    public float length;
    public float width;
    public float height;

    /// <summary>
    /// 體積
    /// public    公開 : 允許子類別存取，但是能被外部存取，會顯示在外部面板
    /// protected 保護 : 允許子類別存取，禁止外部存取
    /// </summary>
    protected float volume; 


    /// <summary>
    /// 取得體積
    /// virtual 虛擬 : 允許子類別複寫
    /// 沒有加上 virtual 只能繼承，不能覆寫
    /// </summary>
    /// <returns>體積</returns>
    public virtual float GetVolume()
    {
        volume= length * width * height;
        return volume;
    }

}
