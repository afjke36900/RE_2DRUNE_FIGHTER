using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        if( col.tag=="Bullet"||col.tag=="Penetrate_Bullet")
            Destroy(col.gameObject);
        
    }
}
