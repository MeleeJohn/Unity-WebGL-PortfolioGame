using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Player, PlayerSpawn.transform.position, PlayerSpawn.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
