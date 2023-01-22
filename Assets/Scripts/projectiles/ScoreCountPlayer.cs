using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCountPlayer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("doggo"))
        {
            Score.scoreValue += 10;
        }
        if (collision.gameObject.CompareTag("drug"))
        {
            Score.scoreValue -= 1;
        }
    }

}
