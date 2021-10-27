using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    // Start is called before the first frame update
    SwordAttack sAttack;
    [SerializeField] int m_eHP = 10;
    void Start()
    {
        m_eHP = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(m_eHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<SwordAttack>() != null)
        {
            Debug.Log(1);
            sAttack = other.gameObject.GetComponent<SwordAttack>();
            m_eHP -= sAttack.m_Damage;
        }
    }
}
