using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour
{
    private float offsetX;
    public GameObject player;

    public void Start()
    {
        this.offsetX = this.transform.position.x
            - this.player.transform.position.x;
    }


    public void Update()
    {
        var position = this.transform.position;

        position.x = this.player.transform.position.x;
        this.transform.position = position;
    }
}