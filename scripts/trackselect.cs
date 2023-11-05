using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackselect : MonoBehaviour
{
    public GameObject level;
    public GameObject track;

    public void trackselected()
    {
        level.SetActive(false);
        track.SetActive(true);

    }
}
