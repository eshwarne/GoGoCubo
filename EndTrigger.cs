using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameHub g;
    //on trigger enter is like collision but it is different, and also, if u have it enabled u cannot use collision
     void OnTriggerEnter()
    {
        g.CompleteLevel();
    }
}
