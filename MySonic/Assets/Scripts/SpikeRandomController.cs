using UnityEngine;
using System.Collections;

public class SpikeRandomController : MonoBehaviour
{
    private float randomX;
    public GameObject spike;

    public void Start()
    {
        this.spike = this.GetComponent<GameObject>();
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("SpikeColliders"))
        {

            var noriginalPosition = this.spike.transform.position;


            randomX = Random.Range(noriginalPosition.x, noriginalPosition.x * 1.4f);

            noriginalPosition.x = randomX;

            this.spike.transform.position = noriginalPosition;
        }
    }
}
