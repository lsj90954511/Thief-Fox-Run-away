using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapmove : MonoBehaviour
{
    public float mapSpeed = 2.0f;
    
    private void Update()
    {
        if (!DataManager.Instance.PlayerDie)
        {
            transform.Translate(-mapSpeed * Time.deltaTime, 0, 0);
        }
        
    }
}
