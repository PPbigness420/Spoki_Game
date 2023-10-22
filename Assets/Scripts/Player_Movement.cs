using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{
    public Transform spawnPoint;


    private Rigidbody2D rb;
    private bool respawned;
    private void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        respawned = true;
    }
    void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        rb.position = mousePos;
        if (respawned)
        {
            mousePos = spawnPoint.position;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.name.Contains("boarder"))
        {
            rb.position = spawnPoint.position;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            print("ded");
        }
        
        
    }

}
