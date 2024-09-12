using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    
    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void ReturnPlay()
    {
        SceneManager.LoadScene(0);
    }

}
