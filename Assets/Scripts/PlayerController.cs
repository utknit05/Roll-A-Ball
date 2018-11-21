using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    private float count;
    public Text score;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        score.text = count.ToString();
    }

    void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        rb.AddForce(movement, ForceMode.VelocityChange);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp")){
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            count++;
            score.text = count.ToString();
        }
    }
}
