using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class HowtoPlay : MonoBehaviour,IPointerClickHandler
{
    public Canvas tutorialCanvas;
    public void OnPointerClick(PointerEventData eventData)
    {
        
        tutorialCanvas.GetComponent<Canvas>().enabled = true;
        tutorialCanvas.gameObject.SetActive(true);
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
