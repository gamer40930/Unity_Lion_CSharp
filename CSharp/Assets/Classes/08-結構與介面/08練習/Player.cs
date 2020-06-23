using UnityEngine;

namespace Kid.Class8
{
public class Player : MonoBehaviour
   {
        public Transform hand;

        private void OnTriggerEnter(Collider other)
    {
        // 不使用介面的寫法
        if (other.name == "道具" || other.name == "武器") Hit(other.GetComponent<IcanUse>());

        // 使用介面的寫法
        if (other.gameObject.GetComponent<IcanUse>() != null) Hit(other .GetComponent<IcanUse>());
    }

        private void Hit(IcanUse use)
    {
        print("你碰到東西了");
        use.Use();
    }

    }

}
