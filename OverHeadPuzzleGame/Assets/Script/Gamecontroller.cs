using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamecontroller : MonoBehaviour
{
    int count = 0;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            WinCheck();
        }
    }
    void WinCheck()
    {

        if (count == 4)
        {
            SceneManager.LoadScene("Win Menu");
        }
    }
}
