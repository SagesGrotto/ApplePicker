/****
* Created by: Sage
* Date Created: Jan 31, 2022
* 
* Last Edited by: NA
* Last Edited: Jan 31, 2022
* 
* Description: Controls tree movement and apple spawning
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject applePrefab;

    public float speed = 1f;

    public float leftAndrightEdge = 10f;

    public float chanceToChangeDirections = 0.1f;

    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }//end Start()

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position; // Move apple to tree pos
        Invoke("DropApple", secondsBetweenAppleDrops);
    }
    // Update is called once per frame
    void Update()
    {
        //Move every frame
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        /*
        if(pos.x < -leftAndrightEdge)
        {
            speed = Mathf.Abs(speed); // Move right
        }
        else if(pos.x > leftAndrightEdge)
        {
            speed = -Mathf.Abs(speed); // Move left
        }
            */
        if(pos.x < -leftAndrightEdge || pos.x > leftAndrightEdge)
        {
            speed *= -1;
        }

    }//end Update()

    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
