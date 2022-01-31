using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private int damage = 3;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<Health>() != null)
        {
            Health h = collider.GetComponent<Health>();
            h.Damage(damage);
        }
    }

    private void Update()
    { 

        Vector3 CharacterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            CharacterScale.x = -1;
        }
        else
        {
            CharacterScale.x = 1;
        }

        transform.localScale = CharacterScale;
    }
}
