using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    Vector3 GiantPlayer = new Vector3(10.0f, 10.0f, 8.0f);             // 커진 크기
    Vector3 OriginPlayer = new Vector3(6.0f, 6.0f, 6.0f);            // 원래 크기

    float waitTime = 5.0f;
    float tickTime = 0.0f;
    GameObject Player = null;
    bool isSuper = false;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        
            tickTime += Time.deltaTime;

            if (tickTime >= waitTime && isSuper)
            {
                Debug.Log("시간이 되었다.");
                PlayerBack();
                tickTime = 0.0f;
            }
        
        


    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // 캐릭터가 죽지 않았다고 임의로 지정함

        if (col.gameObject.tag == "Item1" && isSuper == false)
        {
            MakeSuper();
            tickTime = 0.0f;
            // Item과 접촉했을 경우, 캐릭터의 크기 증가
        }

        Destroy(col.gameObject);    // 기능 발동 후 아이템 삭제
    }

    void PlayerBack()
    {
        // 커졌는지 체크하는 Bool 변수 false로 변경, 플레이어의 크기 변경
        Player.transform.localScale = OriginPlayer;
        // 다시 태그와 레이어를 Player로 변경
        Player.gameObject.tag = "Player";
        Player.layer = LayerMask.NameToLayer("Player");
        isSuper = false;
        Debug.Log("다시 돌아와");
    }

    void MakeSuper()
    {
        Player.transform.localScale = GiantPlayer;
        Player.gameObject.tag = "SuperPlayer";
        Player.layer = LayerMask.NameToLayer("SuperPlayer");
        isSuper = true;
        Debug.Log("아이템 발동!");
    }
   
}
