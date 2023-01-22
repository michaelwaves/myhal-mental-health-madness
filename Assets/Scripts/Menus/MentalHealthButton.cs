using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalHealthButton : MonoBehaviour
{
    private string[][] mentalHealthLinks = new string[17][];
    void Start()
    {
        mentalHealthLinks[0] = new string[2] {"good2talk", "https://good2talk.ca"};
        mentalHealthLinks[1] = new string[2] { "Navi", "https://prod.virtualagent.utoronto.ca/" };
        mentalHealthLinks[2] = new string[2] { "UTSG Supports", "https://studentlife.utoronto.ca/task/support-when-you-feel-distressed/" };
        mentalHealthLinks[3] = new string[2] { "CAMH", "https://www.camh.ca/en/health-info/crisis-resources" };
        mentalHealthLinks[4] = new string[2] { "MySSP App", "https://play.google.com/store/apps/details?id=com.onetapsolutions.morneau.myissp&hl=en&pli=1" };
        mentalHealthLinks[5] = new string[2] { "Clinical Care", "https://studentlife.utoronto.ca/task/book-appointments-and-view-lab-results-online/" };
        mentalHealthLinks[6] = new string[2] { "Counselling Appointments", "https://studentlife.utoronto.ca/service/same-day-counselling-appointment/" };
        mentalHealthLinks[7] = new string[2] { "CMHO Youth", "https://cmho.org/youth-resources/" };
        mentalHealthLinks[8] = new string[2] { "Ontario Government", "https://www.ontario.ca/page/mental-health-services-children-and-youth" };
        mentalHealthLinks[9] = new string[2] { "Youth Zone", "https://toronto.cmha.ca/youth-zone/" };
        mentalHealthLinks[10] = new string[2] { "H&W numbers", "https://safety.utoronto.ca/mental-health/" };
        mentalHealthLinks[11] = new string[2] { "reddit uoft experiences", "https://www.reddit.com/r/UofT/comments/jp8w2i/my_experience_with_uoft_and_mental_health/" };
        mentalHealthLinks[12] = new string[2] { "reddit resources", "https://www.reddit.com/r/UofT/comments/qnpoc6/help_me_make_a_list_of_mental_health_resources/" };
        mentalHealthLinks[13] = new string[2] { "vines to cure depression", "https://www.youtube.com/watch?v=zezAcM7s0ns" };
        mentalHealthLinks[14] = new string[2] { "surgery robot", "https://www.youtube.com/watch?v=A_BlNA7bBxo" };
        mentalHealthLinks[15] = new string[2] { "mental health fix", "https://www.youtube.com/watch?v=dQw4w9WgXcQ" };
        mentalHealthLinks[16] = new string[2] { "let it go", "https://www.youtube.com/watch?v=uapUwZuVnOU" };
        mentalHealthLinks[17] = new string[2] { "chopin", "https://www.youtube.com/watch?v=gUN5ioqlh5U" };


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
