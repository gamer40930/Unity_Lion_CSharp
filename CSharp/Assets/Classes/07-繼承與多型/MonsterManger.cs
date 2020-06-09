using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManger : MonoBehaviour
{
    [Header("怪物陣列 0:狐狸 1:老鷹 2:老鼠 3:青蛙")]
    public GameObject[] monsters;

    public void CreatMonster(int index)
    {
        Instantiate(monsters[index], new Vector3(-7, 1.5f, 0), Quaternion.identity);
    }


}
