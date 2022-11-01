using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{
    public TextMeshProUGUI playerScore;
    public int number = 0;
    public static score instance; //create instance of class to use in movement script

    private void Awake()
    {
        instance = this; //putting the instance to this class
    }

    private void Update()
    {
        playerScore.text = number.ToString(); //updates the score on UI
    }

    public void GainPoints()
    {
        number++;
    }
}
