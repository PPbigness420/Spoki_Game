using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoarderCheck : MonoBehaviour
{

    public Transform spawnPoint;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (!collision.gameObject.name.Contains("boarder"))
        {
            transform.position = spawnPoint.position;
        }
    }
}
