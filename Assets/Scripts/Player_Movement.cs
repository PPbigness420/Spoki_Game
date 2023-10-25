using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{
    


    private Rigidbody2D rb;
    private bool respawned;
    private void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
       
    }
    void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        rb.position = mousePos;
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.name.Contains("boarder"))
        {
            
            SceneManager.LoadScene("Menu");

            print("ded");
        }
        
        
    }

}
