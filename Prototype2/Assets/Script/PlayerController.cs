using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalAxis;
    private float speed = 20f;
    private float xRange = 18f;

    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    //tells the bound and allows player movement in particular direction only
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //tells the bound and allows player movement in particular direction only
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //input from the player 
        horizontalAxis = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalAxis * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, transform.position, projectile.transform.rotation);
        }
    }
}
