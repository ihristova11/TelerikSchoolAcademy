using UnityEngine;
using System.Collections;

public class AnotherBackgroundCollideController : MonoBehaviour
{
    private int numBG;
    private float distanceBG;
    public void Start()
    {
        var backgrounds = GameObject.FindGameObjectsWithTag("Background");

        this.numBG = backgrounds.Length;

        this.distanceBG = 2.45f;

        Debug.Log(distanceBG);
    }


    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Background"))
        {
            Debug.Log(numBG);
            Debug.Log(distanceBG);

            var background = collider.gameObject;
            var backgroundPosition = background.transform.position;
            backgroundPosition.x -= 3 * this.distanceBG;
            background.transform.position = backgroundPosition;
        }

    }
}
