using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Text : MonoBehaviour
{
    [SerializeField]
    private string[] thingToSay;
    [SerializeField]
    bool repeat = false;
    private int currentSpokenStrings = 0;
    private Text someTextPanel;

    void Awake()
    {
        someTextPanel = GetComponentInChildren<Text>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (currentSpokenStrings < thingToSay.Length)
        {
            
            Speak(thingToSay[currentSpokenStrings]);
            currentSpokenStrings++;
        }
        else
        {
            if (repeat)
                currentSpokenStrings = 0;
        }
    }

    void Speak(string whatToSay)
    {
        
        someTextPanel.text = whatToSay;
    }
}
