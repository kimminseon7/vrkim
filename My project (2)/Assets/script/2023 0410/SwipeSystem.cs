using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeSystem : MonoBehaviour
{

    private Vector2 initialPos;
    public GameObject Character;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) initialPos = Input.mousePosition;
        if (Input.GetMouseButtonUp(0)) Caloulate(Input.mousePosition);

    }

    void Caloulate(Vector3 finalPos)
    {
        float disx = Mathf.Abs(initialPos.x - finalPos.x);
        float disy = Mathf.Abs(initialPos.y - finalPos.y);

        if (disx > 0  || disy > 0)
        {
            if (disx > disy)
            {
                if (initialPos.x > finalPos.x)
                {
                    Character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
                }
                else
                {
                    Character.transform.position += new Vector3(1.0f, 0.0f, 0.0f);
                }
            }
            else
            {
                if (initialPos.y > finalPos.y)
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, -1.0f);
                }
                else
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, 1.0f);
                }
            }
        }
    }
}
