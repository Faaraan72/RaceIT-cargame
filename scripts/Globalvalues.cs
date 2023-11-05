using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globalvalues : MonoBehaviour
{
    public static int citytrack ;
   
    public void track1()
    {
        PlayerPrefs.SetInt("citytrack", 1);
    }
    public void track2()
    {
        PlayerPrefs.SetInt("citytrack", 2);
    }
    public void track3()
    {
        PlayerPrefs.SetInt("citytrack", 3);
    }

}
