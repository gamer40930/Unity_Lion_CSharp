﻿using UnityEngine;
using System.Collections; // 引用 系統 集合 API(協同程序)

namespace Kid.Class8
{
    public class Prop : MonoBehaviour,IcanUse
    {
        public Data data;

        public void Use()
        {
            print("使用道具" + data .name );
            // 啟動偕同程序(協同方法)
            StartCoroutine(Big());
        }

        /// <summary>
        /// 協同程序方法 : 傳回類型為 Ienumverator
        /// 必須傳回時間
        /// yield return new WaitForSeconds(秒數)
        /// </summary>
        /// <returns></returns>
        private IEnumerator Big()
        {
            Transform player = FindObjectOfType<Player>().transform;

            while (player .lossyScale .x <3)
            {
                player.localScale += Vector3.one * 0.1f;
                yield return new WaitForSeconds(0.05f);
            }

            Destroy(gameObject);
        }

    }

}


