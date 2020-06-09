using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class House : MonoBehaviour
{
    [Header("房子血量"),Range (100,10000)]
    public float hp;
    [Header("房子血條")]
    public Image hpBar;

    private float hpMax;

    private void Awake()
    {
        hpMax = hp;
    }

    public void Damage(float damage)
    {
        hp -= damage;
        hpBar.fillAmount = hp / hpMax;
    }





}
