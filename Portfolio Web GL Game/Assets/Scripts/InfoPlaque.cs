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

    private GameObject Player;

    private bool checkForPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        TitleText.text = Title;
        MediumText.text = Medium;
        DescriptionText.text = Description;
        StartCoroutine(playerCheckWait());
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.transform.position) < 3.5f && checkForPlayer == true)
        {
            Debug.Log("This is " + this.name + " you're close enough pal");
        }
        
        if(Player == null)
        {
            Debug.Log("No player?");
        }
    }

    private IEnumerator playerCheckWait()
    {
        yield return new WaitForSeconds(.1f);
        Player = GameObject.FindGameObjectWithTag("Player");
        checkForPlayer = true;
    }
}
