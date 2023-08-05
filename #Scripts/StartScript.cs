using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // 씬 매니저

public class StartScript : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]  // Title씬 가장 먼저 시작
    static void FirstLoad()
    {

        if (SceneManager.GetActiveScene().name.CompareTo("Title") != 0)
        {
            SceneManager.LoadScene("Title");
        }
    }
    public void StartClick()
    {
        SceneManager.LoadScene(0);  // 씬0(SampleScene)으로 변경
    }
}