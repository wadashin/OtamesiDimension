using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    HP hp;

    float x;
    float z;

    [SerializeField] float m_Speed = 1;
    [SerializeField] float m_MaxSpeed = 5;

    Vector3 latePosition;

    [SerializeField] float m_InvisibleTime = 2;
    [SerializeField] float m_InvisibleLong = 30;

    bool sousa = true;

    float time;

    PlayeStamina playeStamina;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        hp = gameObject.GetComponent<HP>();
    }

    // Update is called once per frame
    void Update()
    {
        Kaihi();
        if (sousa)
        {
            Sousa();
        }
        else
        {
            time += Time.deltaTime;
            if (time >= m_InvisibleTime)
            {
                sousa = true;
                time = 0;
            }
        }
    }

    private void Sousa()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        if (rb.velocity.magnitude < m_MaxSpeed)
        {
            rb.AddForce(x, 0f, z);
        }

        Vector3 direction = transform.position - latePosition;
        latePosition = transform.position;

        if (direction.magnitude > 0.001f)
        {
            direction.y = 0;
            transform.rotation = Quaternion.LookRotation(direction.normalized);
        }
    }

    private void Kaihi()
    {
        var a = new Vector3(x, 0, z);

        //if (Input.GetKey(KeyCode.LeftShift))
        if (Input.GetButtonDown("Fire1"))
        {
            playeStamina = gameObject.GetComponent<PlayeStamina>();

            if (playeStamina.Stamina >= 15)
            {
                playeStamina.Stamina -= 15;

                rb.velocity = Vector3.zero;

                rb.AddForce(a.normalized * m_InvisibleLong);
                sousa = false;


                Muteki();
            }
        }
    }

    void Muteki()
    {
        hp.Mutekinisimasu(m_InvisibleTime);
    }
}
