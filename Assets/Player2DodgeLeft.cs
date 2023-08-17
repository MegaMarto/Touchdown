using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2DodgeLeft : MonoBehaviour
{
    public float dashSpeed;

    bool isDashing;





    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
            isDashing = true;


    }

    private void FixedUpdate()
    {
        if (isDashing)
            Dashing();
    }

    private void Dashing()
    {
        transform.position += -transform.right * dashSpeed * Time.deltaTime;
        isDashing = false;



    }
}
