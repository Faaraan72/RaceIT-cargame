using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackmanager : MonoBehaviour
{
    public GameObject track1;
    public GameObject track2;
    public GameObject track3;

    private void Start()
    {
        if (PlayerPrefs.GetInt("citytrack") == 1)
        {
            track1.SetActive(true);
            track2.SetActive(false);
            track3.SetActive(false);

        }
        if (PlayerPrefs.GetInt("citytrack") == 2)
        {
            track1.SetActive(false);
            track2.SetActive(true);
            track3.SetActive(false);

        }
if (PlayerPrefs.GetInt("citytrack") == 3)
        {
            track1.SetActive(false);
            track2.SetActive(false);
            track3.SetActive(true);
        }
    }
}
