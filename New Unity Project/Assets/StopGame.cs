using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class StopGame : MonoBehaviour,IPointerClickHandler
{
    private bool stop = false;
    // Start is called before the first frame update
  
        
   public void OnPointerClick(PointerEventData eventData)
    {
        if (stop ==false)
        {
            Time.timeScale = 0f;
            stop = true;
        }
        else if(stop ==true)
        {
            Time.timeScale = 1f;
            stop = false;
        }

    }
}
