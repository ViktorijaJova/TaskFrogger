using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;
    public Text Scoretext;
    private void Start()
    {
        Scoretext.text = CurrentScore.ToString();
    }
}
