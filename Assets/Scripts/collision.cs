using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacles")
        {
            SceneManager.LoadScene("gameOver");
        }
    }
}
