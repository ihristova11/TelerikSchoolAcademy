using UnityEngine;
using System.Collections;

public class PlayerDead : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "Spike": Destroy(this.gameObject);
                Application.LoadLevel("GameOver");
                break;
        }
    }
}
