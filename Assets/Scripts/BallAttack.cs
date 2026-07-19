using UnityEngine;

public class BallAttack : MonoBehaviour
{
    public float force;
    public AudioSource impact;
    public PlayerData player;
    //int hit = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<ConstantForce>().force = new Vector3(-0f, 0f, -force);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CannonBall")
        {
            impact.Play();
            this.GetComponent<Collider>().enabled = false;
            //this.GetComponent<MeshRenderer>().enabled = false;
            player.Kills++;
            Destroy(this.gameObject, 1);

        }


    }
    private void OnTriggerEnter(Collider other)
    {
              
        if (other.gameObject.tag == "BackSensor")
        {
            player.health = player.health - 5;
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        float x = this.transform.position.x;
        float z = this.transform.position.z;
        float y = this.transform.position.y;

        if (this.transform.position.y < -100)
        {
            Destroy(this.gameObject);
        }

    }
}
