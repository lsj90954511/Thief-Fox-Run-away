using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //씬 변경 (다시하기, 처음으로)

public class Success : MonoBehaviour
{
    public GameObject SuccessPanel;
    //public Collider2D collision;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("End"))
        {
            Time.timeScale = 0.0f;  // 게임 내 시간 정지
            GameObject.Find("Canvas").transform.Find("SuccessPanel").gameObject.SetActive(true);
            //SuccessPanel.SetActive(true);  // 팝업창 열기
        }
    }

    public void Retry2Click()    // 다시하기
    {
        Time.timeScale = 1.0f;  // 시간다시 재생
        DataManager.Instance.PlayerDie = false;
        SceneManager.LoadScene(0);
        //SuccessPanel.SetActive(false);
        GameObject.Find("Canvas").transform.Find("SuccessPanel").gameObject.SetActive(false);
    }

    public void First2Click()    // 처음으로
    {
        DataManager.Instance.PlayerDie = false;
        SceneManager.LoadScene(2);
        //SuccessPanel.SetActive(false);
        GameObject.Find("Canvas").transform.Find("SuccessPanel").gameObject.SetActive(false);
    }
}
