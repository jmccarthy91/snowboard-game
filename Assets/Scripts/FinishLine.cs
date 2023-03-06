using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField] float reloadTime = 1.5f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("You Finished!!");
            Invoke("ReloadScene", reloadTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
