
using UnityEngine;
using UnityEngine.SceneManagement;

public class tp2to3 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("3level");
    }
}
