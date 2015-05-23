using UnityEngine;
using System.Collections;

public class PlayerWon : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "END": Destroy(this.gameObject);
                Application.LoadLevel("End");
                break;
        }
    }
}