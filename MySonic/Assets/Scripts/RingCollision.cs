using UnityEngine;
using System.Collections;

public class RingCollision : MonoBehaviour
{
    private float randomX;
    private float randomY;
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Ring"))
        {

            var go = collider.gameObject;
            var originalPosition = go.transform.position;

            

            randomX = Random.Range(originalPosition.x, originalPosition.x * 1.4f);
            randomY = Random.Range(0.5f, 0.75f);


            originalPosition.x = randomX;
            originalPosition.y = randomY;

            go.transform.position = originalPosition;
        }
    }
}
