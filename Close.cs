using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // 씬 매니저

public class Close : MonoBehaviour
{
    public void CloseClick()
    {
        SceneManager.LoadScene(2);  // 씬2(Title)로 변경
    }
}
