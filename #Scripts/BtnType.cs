using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems; // IPointerEnterHandler, IPointerExitHandler을 쓰기 위함

public class BtnType : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public BTNType currentType;
    public Transform buttonScale;
    Vector3 defaultScale;   // 버튼 원래 크기

    private void Start()
    {
        defaultScale = buttonScale.localScale; // 버튼 크기 초기화
    }

    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType.Start:
                break;
            case BTNType.Rule:
                break;
        }
    }

    public void OnPointerEnter(PointerEventData eventData) // 마우스가 버튼 위에
    {
        buttonScale.localScale = defaultScale * 1.1f;   // 버튼 크기 1.1배
    }

    public void OnPointerExit(PointerEventData eventData) // 마우스가 버튼 밖에
    {
        buttonScale.localScale = defaultScale;
    }
}
