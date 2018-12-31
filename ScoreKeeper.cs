using UnityEngine;

//This contains the text namespace!
using UnityEngine.UI;
public class ScoreKeeper : MonoBehaviour
{
    public Transform player1;
    public Text t;

    // Update is called once per frame
    void FixedUpdate()
    {
        t.text = player1.position.z.ToString("0"); // "0" means, zero precision
    }
}
