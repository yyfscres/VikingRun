using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ExitGame : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData eventData)
    {
        Application.Quit();
    }
}
