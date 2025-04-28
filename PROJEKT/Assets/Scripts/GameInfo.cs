using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour
{
    public static int collectibleCount = 0;
    [SerializeField] GameObject collectibleDisplay;
    [SerializeField] GameObject collectibleDisplayEnd;

    void Start()
    {
        collectibleCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        collectibleDisplay.GetComponent<TMPro.TMP_Text>().text = "SCORE: " + collectibleCount;
        collectibleDisplayEnd.GetComponent<TMPro.TMP_Text>().text = "Your score: " + collectibleCount;
    }
}
