using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Detects when the ball touches the goal, and then wins the level.
/// </summary>
public class Goal : MonoBehaviour
{
    public GameObject winText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched trigger.");
        if (collision.tag == "Player")
        {
            winText.SetActive(true);
            Debug.Log("The Player has entered the goal!");
        }
    }

}
