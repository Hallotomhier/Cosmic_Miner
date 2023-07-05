using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class OnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool mouse_over = false;
    public string dataPointer;
    // public GameObject buildingInfoObject;
    public TMP_Text buildingInfo;

    void Update()
    {
        if (mouse_over)
        {
            // buildingInfoObject.SetActive(true);
            buildingInfo.text = dataPointer;
            Debug.Log("Mouse Over");
        }
        else
        {
            // buildingInfoObject.SetActive(false);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        if(eventData.pointerCurrentRaycast.gameObject.GetComponent<ScriptButton>())
        {
            dataPointer = eventData.pointerCurrentRaycast.gameObject.name;
        }
        

        Debug.Log("Mouse enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        Debug.Log("Mouse exit");
    }
}