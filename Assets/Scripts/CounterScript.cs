using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{

    private const int Limit = 5 * 60;
    private Text counterText;

    public float seconds, minutes;

    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        int remaining = Limit - (int)Time.time;
        minutes = remaining / 60;
        seconds = remaining % 60;
        counterText.text = string.Format("{0}:{1}", minutes.ToString("00"), seconds.ToString("00"));
    }
}
