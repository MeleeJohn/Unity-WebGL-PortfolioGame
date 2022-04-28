using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoPlaque : MonoBehaviour
{
    public TextMeshProUGUI TitleText;
    public TextMeshProUGUI MediumText;
    public TextMeshProUGUI DescriptionText;

    public string Title;
    public string Medium;
    public string Description;
    // Start is called before the first frame update
    void Start()
    {
        TitleText.text = Title;
        MediumText.text = Medium;
        DescriptionText.text = Description;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
