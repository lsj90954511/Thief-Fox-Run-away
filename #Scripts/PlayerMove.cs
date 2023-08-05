using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float jumpPower;
    public float jumpPower2;
    
    Animator anim;
    int jumpCount = 0;

    void Awake()
    {
        
        anim = GetComponent<Animator>();
        
    }

    void Update()
    {   
        if (!DataManager.Instance.PlayerDie)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SoundManager2.Instance.PlaySound("Jump");
                if (jumpCount == 0)
                {
                    gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumpPower, 0);
                    jumpCount += 1;

                }
                else if (jumpCount == 1)
                {
                    gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumpPower2, 0);
                    jumpCount += 1;

                }
                anim.SetBool("isJumping", true);
            }
        }

        Vector3 view = Camera.main.WorldToScreenPoint(transform.position);
        if (view.y < -50 || view.x < -50)
        {
            DataManager.Instance.PlayerDie = true;
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Land") == 0)
        {
            jumpCount = 0;
            anim.SetBool("isJumping", false);
        }
    }
}
