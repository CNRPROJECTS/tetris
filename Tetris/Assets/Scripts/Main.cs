using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Switch to 640 x 480 full-screen
        Screen.SetResolution(720, 1280, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void StartGame() {
        SceneManager.LoadScene("Game");
    }
}
