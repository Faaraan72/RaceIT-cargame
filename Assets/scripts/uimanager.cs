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
    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
   

}
