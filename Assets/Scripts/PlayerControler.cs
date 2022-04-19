using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private float speed;
    private void Update()
    {
        //из тз передвигать по треку клавишами WASD
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * speed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * speed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed, ForceMode.Impulse);
        }
        //back to menu
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
    }
    //game ower
    private void OnCollisionExit(Collision collision)
    {
        //need set for != null 
        PlayerPrefs.SetString("Result","lose");
        SceneManager.LoadScene("Result");
    }
    //win
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Finish")
        {
            PlayerPrefs.SetString("Result", "win");
            PlayerPrefs.SetInt("time",timer.indexScore);
            SceneManager.LoadScene("Result");
        }
    }

}
