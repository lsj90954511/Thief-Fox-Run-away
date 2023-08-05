using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //씬 변경 (다시하기, 처음으로)

public class OverScript : MonoBehaviour
{
    public GameObject GOPanel;

    void Update()   // Gameover
    {
        if (DataManager.Instance.PlayerDie == true)   // 캐릭터 죽음
        {
            GOPanel.SetActive(true);  // 팝업창 열기
        }
    }

    public void RetryClick()    // 다시하기
    {
        DataManager.Instance.PlayerDie = false;
        SceneManager.LoadScene(0);
        GOPanel.SetActive(false);
    }

    public void FirstClick()    // 처음으로
    {
        DataManager.Instance.PlayerDie = false;
        SceneManager.LoadScene(2);
        GOPanel.SetActive(false);
    }
}
