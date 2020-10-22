using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.sharedInstance.grassNb += 1;

        gameObject.transform.parent = TileManager.sharedInstance.transform;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("Grass Eaten");

            TileManager.sharedInstance.EatGrassTile(Vector3Int.FloorToInt(transform.position));

            GameManager.sharedInstance.grassNb += -1;

            SoundManager.sharedInstance.FootSteps();

            Destroy(gameObject);
        }
    }
}
