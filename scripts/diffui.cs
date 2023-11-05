using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class diffui : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public Image fillImage;
    public Text diff;
    private void Start()
    {
        diff.text = "EASY";
        diff.color = Color.green;
        slider.value = 0.3f;
        fillImage.color = Color.green;
    }
    public void racealone()
    {
        diff.text = "EASY";
        diff.color = Color.green;
        slider.value = 0.25f;
        fillImage.color = Color.green;
    }
    public void racevscmp()
    {
       
        diff.text = "MEDIUM";
        diff.color = Color.magenta;
        slider.value = 0.5f;
        fillImage.color = Color.magenta;
    }
    public void breakfail()
    {
        diff.text = "HARD";
        diff.color = Color.red;
        slider.value = 0.85f;
        fillImage.color = Color.red;
    }

}
