using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timer;
    public float t = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        float min = Mathf.RoundToInt(t / 60);
        float sec = Mathf.RoundToInt(t % 60);
        timer.text = string.Format("{0,00}:{1,00}", min, sec);
    }
}