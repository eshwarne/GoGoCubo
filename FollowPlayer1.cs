using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player1;
    public Vector3 stayBackCameraOffset;
    
    // Update is called once per frame
    void Update()
    {
        transform.position=player1.position+stayBackCameraOffset;
    }
}
