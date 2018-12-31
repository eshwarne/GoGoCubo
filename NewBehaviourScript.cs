using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce=5000f;
    public float sideForce=5000f;
    public float mobileSideForce = 1f;
    void Start()
    {   
     Debug.Log("HELLO");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch T = Input.GetTouch(0);
            if (T.phase == TouchPhase.Moved || T.phase == TouchPhase.Began)
            {
                Vector3 tPos = (T.position);
               if(tPos.x > (Screen.width/ 2f))
                {
                    rb.AddForce(mobileSideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
                if (tPos.x < (Screen.width / 2f))
                {
                    rb.AddForce(-mobileSideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
            }
        }
        //Time.deltaTime normalizes the speed of the movement of the object in the environment
        if(Input.GetKey("d")){
            rb.AddForce(sideForce* Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
            rb.AddForce(0,0,forwardForce * Time.deltaTime);
        if(Input.GetKey("a")){
            rb.AddForce(-sideForce* Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("s")){
            rb.AddForce(0,0,-forwardForce * Time.deltaTime);
        }
        if (rb.position.y <= -1f)
        {
            FindObjectOfType<GameHub>().EndGame();
        }
    }
}
