using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reset : MonoBehaviour
{
    public Text text1, text2, text3, text4;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        text1.text = "";
        text2.text = "";
        text3.text = "0";
        text4.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
