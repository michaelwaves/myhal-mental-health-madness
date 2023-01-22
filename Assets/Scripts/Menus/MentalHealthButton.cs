using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalHealthButton : MonoBehaviour
{
    private string[][] mentalHealthLinks = new string[3][];
    void Start()
    {
        mentalHealthLinks[0] = new string[2]{"good2talk", "https://good2talk.ca"};
        mentalHealthLinks[1] = new string[2] { "Navi", "https://prod.virtualagent.utoronto.ca/" };
        mentalHealthLinks[2] = new string[2] { "UTSG Supports", "https://studentlife.utoronto.ca/task/support-when-you-feel-distressed/" };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MentalHealthTime()
    {
        string url = mentalHealthLinks[Random.Range(0, mentalHealthLinks.Length)][1];
        Application.OpenURL(url);
    }
}
