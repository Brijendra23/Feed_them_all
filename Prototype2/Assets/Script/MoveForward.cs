
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    //moves forward
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
