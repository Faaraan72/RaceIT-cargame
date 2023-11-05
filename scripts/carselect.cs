using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carselect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject stages;
    public GameObject carpannel;
    public GameObject[] cars;
    void Start()
    {
        carpannel.SetActive(true);
        stages.SetActive(false);
        cars[0].SetActive(true);
        for (int i = 1; i < cars.Length; i++)
        {
            cars[i].SetActive(false);
        }
    }
    public void carselected()
    {
        stages.SetActive(true);
        carpannel.SetActive(false);

    }
    public void yellow()
    {
        cars[0].SetActive(true);
       for(int i = 1; i < cars.Length; i++)
        {
            cars[i].SetActive(false);
        }
    }
    public void monster()
    {
        cars[1].SetActive(true);
        for (int i = 0; i < cars.Length; i++)
        {
            if (i != 1) { cars[i].SetActive(false); }
           
        }
    }
    public void grey()
    {
        cars[2].SetActive(true);
        for (int i = 0; i < cars.Length; i++)
        {
            if (i != 2) { cars[i].SetActive(false); }

        }
    }
    public void by()
    {
        cars[3].SetActive(true);
        for (int i = 0; i < cars.Length; i++)
        {
            if (i != 3) { cars[i].SetActive(false); }

        }
    }
    public void police()
    {
        cars[4].SetActive(true);
        for (int i = 0; i < cars.Length; i++)
        {
            if (i != 4) { cars[i].SetActive(false); }

        }
    }


}
