using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveleft : MonoBehaviour
{
    private float speed = 10;
    private Playercontroller playercontrollerScript;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        playercontrollerScript = GameObject.Find("player").GetComponent<Playercontroller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playercontrollerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacles"))
        {
            Destroy(gameObject);
        }
    }
}
