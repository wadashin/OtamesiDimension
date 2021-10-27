using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    HP hp;
    [SerializeField] float m_Damage = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<HP>() != null)
        {
            hp = other.gameObject.GetComponent<HP>();
            if (hp.invincible == false)
            {
                hp.m_HP -= m_Damage;
            }
        }
    }
}
