using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class checkpointmanager : MonoBehaviour
{
    public GameObject start;
    public GameObject winpanel;
    public GameObject loosepanel;
    public camerafollow camera;
    public GameObject player;
    private AudioSource playeraud;
    public float count = 3f;
    public Text countdown;
    public GameObject startpannel;
    public AudioSource bgm;
    public GameObject[] checkpoints;
    public GameObject end;
    public bool reached= false;
    private int i=-1;
    private AudioSource ad;
    public AudioClip winaudio;
    public AudioClip looseaudio;

    public Text timetext;
    private float timeleft =10f;
    private bool timestart = false;
    private bool isRed = false;
    private bool win = false;
    
    private void Start()
    {
       
        count = 3f;
        Time.timeScale = 1f;
        camera.enabled = true;
        player.SetActive(true);
        startpannel.SetActive(true);
      ad=GetComponent<AudioSource>();
        foreach(GameObject g in checkpoints)
        {
            g.SetActive(false);
        }
        end.SetActive(false);
        StartCoroutine(startcount());
       
    }
    private IEnumerator startcount()
    {
        while (count >=0)
        {
            startpannel.GetComponent<Image>().color = Color.red;
            countdown.text = count+"";
           
            if (count == 0)
            {
                startpannel.GetComponent<Image>().color = Color.green;
                countdown.text = " GO!";
                countdown.color = Color.green;
            }
            yield return new WaitForSeconds(0.8f);
            count -= 1f;
        }
        StartCoroutine(Countdown());
        bgm.Play();
    }
    private IEnumerator Countdown()
    {
        
        while (timeleft > 0)
        {
            // Update the timer text
            timetext.text = timeleft.ToString("");

            // Check if the time is less than 3 seconds and change color
            if (timeleft <=3f && !isRed)
            {
                timetext.color = Color.red;
                isRed = true;
            }

            yield return new WaitForSeconds(1f); // Wait for 1 second
            timeleft -= 1f; // Decrement the timer
        }

        timetext.text = "0.0";
        timetext.color = Color.red;
       // Ensure it's red when the timer reaches 0
    }

 //  private IEnumerator C0untdown2()
 //  {
 //      while (timeleft > 0)
 //      {
 //          Debug.Log(timeleft);
 //          if(timeleft <= 3f)
 //          {
 //              Debug.Log("Hurry");
 //          }
 //          yield return new WaitForSeconds(1f);
 //
 //
 //      }
 //  }
private void Update()
    {
        if (count < 0)
        {
            startpannel.SetActive(false);
           
        }
        if (timeleft <= 0 && !win)
        {

            Invoke(nameof(losing), 1f);
            camera.enabled = false;
        }

        


        if (reached== true)
        {
            timeleft = 10f;
            timetext.text = timeleft.ToString("F1");
            timetext.color = Color.green;
            isRed = false;
            ad.Play();
            i++;
           
            if (i == 0)
            {
                start.SetActive(false);
                checkpoints[i].SetActive(true);
             

            }
            if(i>0 && i<=13)
            {
                checkpoints[i].SetActive(true);
                checkpoints[i - 1].SetActive(false); //Debug.Log(i + "  ------------>");
             
            }
            if(i >= 13)
            {
                end.SetActive(true);
                Debug.Log(i);
                

            }
            if (i == 14)
            {
                // winpanel.SetActive(true);
                Invoke(nameof(wining), 1f);
               
                camera.enabled = false;
                win = true;
               // player.SetActive(false);
            }

            reached = false;

        }
    }
    void wining()
    {
        winpanel.SetActive(true);
        Time.timeScale = 0f;
        ad.PlayOneShot(winaudio);
        bgm.Stop();
        player.GetComponent<AudioSource>().enabled = false;
    }
    void losing()
    {
        loosepanel.SetActive(true);
        Time.timeScale = 0f;
        bgm.Stop();
        ad.PlayOneShot(looseaudio);
        player.GetComponent<AudioSource>().enabled = false;
    }


}
