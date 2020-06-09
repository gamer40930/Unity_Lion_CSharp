using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 形狀 : 基底類別
/// </summary>
public class Triangle : Shape
{
    /// <summary>
    /// ovveride 複寫 : 覆寫父類別
    /// </summary>
    /// <returns>體積</returns>
    public override float GetVolume()
    {
        volume = length * width * height / 2; // 三角形體積
        return volume;
    }

    private void Start()
    {
        print(gameObject + "體積" + GetVolume());
    }
}
