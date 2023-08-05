using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject ExitPanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))   // 키보드 ESC
        {
            Time.timeScale = 0.0f;  // 게임 내 시간 정지
            ExitPanel.SetActive(true);  // 팝업창 열기
        }
    }

    public void ExitNo()    // 팝업창 닫기
    {
        Time.timeScale = 1.0f;     // 시간 다시 재생
        ExitPanel.SetActive(false); // 팝업창 지움

    }

    public void ExitYes()   // 게임 종료
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}