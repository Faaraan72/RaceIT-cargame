using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class careffects : MonoBehaviour
{
    private movement m;
    public TrailRenderer[] tr;
    private bool marks;
    public GameObject sp;
   public  AudioSource ad;
    public AudioClip drifting;
    public ParticleSystem[] smoke;
    Speedometer s;
    private void Start()
    {
        m = gameObject.GetComponent<movement>();
        //  ad = gameObject.GetComponent<AudioSource>();
       s = sp.GetComponent<Speedometer>();
        
        foreach (ParticleSystem g in smoke)
        {
            g.Stop();
        }
    }

    private void FixedUpdate()
    {
        checkdrift();
       
    }
    void checkdrift()
    {
        if(m.breakinp)
        {
            startemit();
        }
        else
        {
            stopemit();
        }
    }
    public void startemit()
    {

       if( s.speed>30f)
        {
            ad.PlayOneShot(drifting);
            foreach (TrailRenderer t in tr)
            {
                t.emitting = true;
            }
            foreach (ParticleSystem g in smoke)
            {
                g.Play();
            }
        }
       
        marks = true;
    }
    void stopemit()
    {
      
        ad.Stop();
        foreach (TrailRenderer t in tr)
        {
            t.emitting = false;
        }
        foreach (ParticleSystem g in smoke)
        {
            g.Stop();
        }
        marks = false;
    }

}
