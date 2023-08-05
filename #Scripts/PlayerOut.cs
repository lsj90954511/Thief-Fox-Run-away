using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;

public class PlayerOut : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // (버전2)플레이어가 장애물과 부딪칠 때 바로 게임오버(이 코드는 장애물의 C#스크립트에 넣기)
        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
            DataManager.Instance.PlayerDie = true;
        }
    }
}
