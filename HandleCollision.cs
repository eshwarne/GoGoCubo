using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public NewBehaviourScript sc;
    void OnCollisionEnter(Collision c){
        if (c.collider.tag == "Obstacle")
        {
            sc.enabled = false;
            //Using GameHub g variable restricts it and does not allow it to be found in other players!
            //So use built in function GetComponent
            FindObjectOfType<GameHub>().EndGame();
        }
    }
}
