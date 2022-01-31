
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{

    private void Update()
    {
        // Move the character
        transform.Translate(Input.GetAxis("Horizontal") * 10f * Time.deltaTime, 0f, 0f);

        // flip the character
        Vector3 CharacterScale = transform.localScale;
        if(Input.GetAxis("Horizontal") < 0)
        {
            CharacterScale.x = 3;
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            CharacterScale.x = -3;
        }

        transform.localScale = CharacterScale;
    }
}
