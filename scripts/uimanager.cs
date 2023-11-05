using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class uimanager : MonoBehaviour
{
   // [SerializeField] private GameObject optionspannel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void exit()
    {
        Application.Quit();
    }
   
   public void play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
  
    public void mountains()
    {
        SceneManager.LoadScene("simple");
    }
    public void town()
    {
        SceneManager.LoadScene("town");
    }
    public void town2day()
    {
        SceneManager.LoadScene("town2day");
    }

    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
   public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
   public void tohome()
    {
        SceneManager.LoadScene("start");
        Time.timeScale = 1f;
    } 

}
