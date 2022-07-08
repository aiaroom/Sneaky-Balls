using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField]
    KeyCode KeyRestart;

    void Update()
    {
        if (Input.GetKey(KeyRestart))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
