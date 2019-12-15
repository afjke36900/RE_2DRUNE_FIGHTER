using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_attack : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) { GetComponent<bullet_shoot>().AttackType = 1; }
        if (Input.GetKey(KeyCode.Alpha2)) { GetComponent<bullet_shoot>().AttackType = 2; }
        if (Input.GetKey(KeyCode.Alpha3)) { GetComponent<bullet_shoot>().OnHitType = 1; }
        if (Input.GetKey(KeyCode.Alpha4)) { GetComponent<bullet_shoot>().OnHitType = 3; }
    }
}
