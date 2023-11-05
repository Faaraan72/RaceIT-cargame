using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageselect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject stages;
    public GameObject level;
   
    public void mapselected()
    {
        stages.SetActive(false);
        level.SetActive(true);

    }
}
