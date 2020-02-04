using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofCollide : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "House_Roof")
        {
            Destroy(coll.gameObject);

            
            
        }
    }
}
