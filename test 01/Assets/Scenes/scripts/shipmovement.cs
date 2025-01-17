using UnityEngine;

public class shipmovement : MonoBehaviour
{
    public float maxspeed = 1f;
    float acceleration = 0.075f;
    float speed = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(speed < maxspeed)
        {
            speed += acceleration * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * speed * 2);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(Vector3.forward * speed * 2);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 0.02f);
            transform.Translate(Vector3.forward * 0.02f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 0.02f);
            transform.Translate(Vector3.forward * 0.02f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.left * 0.02f);
            transform.Translate(Vector3.forward *  0.02f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.right * 0.02f);
            transform.Translate(Vector3.forward * 0.02f);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, speed), Space.Self);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, -speed), Space.Self);
        }

    }
}