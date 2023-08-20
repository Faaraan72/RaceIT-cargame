using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carselect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject stages;
    public GameObject carpannel;
    void Start()
    {
        carpannel.SetActive(true);
        stages.SetActive(false);
    }
    public void carselected()
    {
        stages.SetActive(true);
        carpannel.SetActive(false);

    }


}
