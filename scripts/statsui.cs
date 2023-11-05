using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class statsui : MonoBehaviour
{
    public Text name, power, acc, steer,nitro, cost;
    public GameObject buce;
    private void Start()
    {
        
        name.text = "BucePhalus";
        power.text = "78";
        acc.text = "65";
        steer.text = "81";
        nitro.text = "NA";
        cost.text = "FREE";
    }
    public void bucep()
    {
        name.text = "BucePhalus";
        power.text = "78";
        acc.text = "65";
        steer.text = "81";
        nitro.text = "NA";
        cost.text = "FREE";
    }
    public void accord()
    {
        name.text = "Monster Accord 118";
        power.text = "87";
        acc.text = "85";
        steer.text = "71";
        nitro.text = "NA";
        cost.text = "$2000";
    }
    public void Satiner()
    {
        name.text = "Stainer V3";
        power.text = "80";
        acc.text = "78";
        steer.text = "81";
        nitro.text = "NA";
        cost.text = "$6000";
    }
    public void Kiamen()
    {
        name.text = "Kiamen 2000";
        power.text = "84";
        acc.text = "82";
        steer.text = "85";
        nitro.text = "Installed";
        cost.text = "$10000";
    }
    public void Kiamen2()
    {
        name.text = "Cop-V5 Cruse";
        power.text = "81";
        acc.text = "84";
        steer.text = "85";
        nitro.text = "Installed";
        cost.text = "$13500";
    }
}
