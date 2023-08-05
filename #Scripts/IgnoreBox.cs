using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreBox : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {

    }

    // 태그를 이용해 무적상태의 캐릭터는 장애물태그의 콜라이더를 무시하게끔 할 예정.

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SuperPlayer")
        {
            Physics2D.IgnoreLayerCollision(9, 10);
        }
    }
}
