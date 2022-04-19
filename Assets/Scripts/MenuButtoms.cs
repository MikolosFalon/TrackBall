using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtoms : MonoBehaviour
{
    
    public void Track()
    {
        SceneManager.LoadScene("Track");
    }
    public void Result()
    {
        SceneManager.LoadScene("Result");
    }
}
