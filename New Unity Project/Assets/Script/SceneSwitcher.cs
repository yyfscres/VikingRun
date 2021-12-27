using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class SceneSwitcher : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public int SceneIndexDestination = 1;

    public void OnPointerClick(PointerEventData eventData)
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Current Scene name= " + scene.name + "and scene index" + scene.buildIndex);
        SceneManager.LoadScene(SceneIndexDestination);

    }
}
