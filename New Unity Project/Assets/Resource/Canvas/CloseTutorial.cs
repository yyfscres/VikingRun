using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class CloseTutorial : MonoBehaviour,IPointerClickHandler
{
    public Canvas tutorialCanvas;
    public void OnPointerClick(PointerEventData eventData)
    {
        tutorialCanvas.gameObject.SetActive(false);
        tutorialCanvas.GetComponent<Canvas>().enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
