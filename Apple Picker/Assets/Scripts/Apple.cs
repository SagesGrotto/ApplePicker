/****
* Created by: Sage
* Date Created: Jan 31, 2022
* 
* Last Edited by: NA
* Last Edited: Jan 31, 2022
* 
* Description: Apple despawn logic
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{

    public static float bottomY = -20f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < bottomY)
        {
            Destroy(this.gameObject);

            GameObject gm = GameObject.Find("GameManager");
            ApplePicker aScript = Camera.main.GetComponent<ApplePicker>();
            Destroy(aScript);
        }
    }//end Update()
}
