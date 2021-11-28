using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6.0f;

    public float rotationSpeed = 1.0f;

    public GameObject cam;

    public bool invertMouse;

    private float invertedMouse = 1.0f;

    private bool isGrounded = true;

    private Rigidbody rigidbody;
    // Start is called before the first frame update
    [SerializeField] AudioSource ziplamaSesi;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (invertMouse)
        {
            invertedMouse = -1.0f;
        }

        //Oyuncu hareketi
        float yatayHareket = Input.GetAxis("Horizontal");
        float dikeyHareket = Input.GetAxis("Vertical");

        Vector3 hareketVektoru = new Vector3(yatayHareket, 0, dikeyHareket);
        transform.position += hareketVektoru.normalized * speed * Time.deltaTime;

        //Kamera hareketi
        float rotX = Input.GetAxis("Mouse X") * rotationSpeed;
        float rotY = Input.GetAxis("Mouse Y") * rotationSpeed * -1.0f * invertedMouse;
        transform.rotation = transform.rotation * Quaternion.Euler(0, rotX, 0);

        cam.transform.rotation = cam.transform.rotation * Quaternion.Euler(rotY, 0, 0);

        Debug.Log("Velocity: " + rigidbody.velocity);
    }
    void FixedUpdate()
    {
        //ZIPLAMA
        if (rigidbody.velocity.magnitude == 0.0f)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        if (Input.GetAxis("Jump") > 0.0f && isGrounded)
        {
            rigidbody.AddForce(new Vector3(0, 360.0f, 0), ForceMode.Force);
            ziplamaSesi.Play();
        }
    }

}
