using UnityEngine;
using System.Collections;

public class RingController : MonoBehaviour
{
    private float randomX;
    private float randomY;

   // public GameObject obj;
    
    public AudioClip impact;
    AudioSource audio;
    public void Start()
    {
        this.audio = this.GetComponent<AudioSource>();
       // this.obj = this.GetComponent<GameObject>();
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.name == "Sonic")
        {
            ScoreChange();

            //var go = collider.gameObject;
            //var originalPosition = go.transform.position;

            //float randomX;
            //float randomY;

            //randomX = Random.Range(1.5f, 2.5f);
            //randomY = Random.Range(2.5f, 2.8f);

            //originalPosition.x = randomX;
            //originalPosition.y = randomY;

            //go.transform.position = originalPosition;

            //Destroy(this.gameObject);
           audio.PlayOneShot(impact);
        }
        //switch (collider.gameObject.name)
        //{

        //    case "Sonic": Destroy(this.gameObject);
                
        //        break;
        //}
    }
    
    public void ScoreChange()
    {
        var point = ScoreController.score;
        point++;
        ScoreController.score = point;
    }







    //private Vector2 originPosition;

    //public int maxPlatforms = 20;
    //public GameObject obj;
    //public float horizontalMin = 7.5f;
    //public float horizontalMax = 14f;
    //public float verticalMin = -6f;
    //public float verticalMax = 6;
    //public void Start()
    //{
    //    originPosition = transform.position;
    //    RandomizeRings();
    //}

    //void Update()
    //{
    //}

    //public void RandomizeRings()
    //{
    //    for (int i = 0; i < maxPlatforms; i++)
    //    {
    //        Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
    //        Instantiate(obj, randomPosition, Quaternion.identity);
    //        originPosition = randomPosition;
    //    }


    //}
}
