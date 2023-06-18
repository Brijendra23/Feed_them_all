
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float TopBound = 30f;
    private float LowerBound = -10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { //destroys the gameobject when goes out of player game view
        if (transform.position.z > TopBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < LowerBound)
        {
            Destroy(gameObject);
        }
    }
}
