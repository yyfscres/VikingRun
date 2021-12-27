using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    public int initialScore;
    public int addScorePerSecond;
    private int currentScore;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = initialScore;
        InvokeRepeating("AddScoreAndDisplay", 1f, 1f);
    }
    void AddScoreAndDisplay()
    {
        currentScore += addScorePerSecond;
        GetComponent<Text>().text = currentScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
