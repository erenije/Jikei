using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Hero"))
        {
            Invoke("FallPlatform", 1f);
            Destroy(gameObject, 1.3f);
        }
    }
    void FallPlatform()
    {
        rb.isKinematic = false;
    }
}
