using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class EnemyDetectCollisions : MonoBehaviour
{

    //public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        GameObject GOT = GameObject.Find("game_over_text");
        GOT.GetComponent<TextMeshProUGUI>().text = "Game Over!! >:)";
        //GOT.SetActive(true);
    }

}
