using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] AudioSource olumSesi;
    bool vefat = false;
    private void Update()
    {
        if(transform.position.y < -1f && !vefat)
        {
            Die();
        }
    }

    void Die()
    {
        vefat = true;
        olumSesi.Play();
        Invoke(nameof(Respawn), 1f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("EnemyBody"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false;
            Die();
        }
    }

    void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
