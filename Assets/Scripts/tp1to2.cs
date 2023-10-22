using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tp1to2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (SceneManager.GetActiveScene().name == "1level")
        {
            print("lvl2");
            SceneManager.LoadScene("2level");
        }
        else if (SceneManager.GetActiveScene().name == "2level")
        {
            print("lvl3");
            SceneManager.LoadScene("3level");
        }
        else
        {
            print("boo");
        }

        
    }
}
