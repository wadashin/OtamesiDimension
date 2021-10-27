using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    [SerializeField] GameObject m_sword;
    float time;
    bool plustime;

    private void Start()
    {
        m_sword.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            plustime = true;
        }

        if(plustime == true)
        {
            m_sword.SetActive(true);

            time += Time.deltaTime;
            if (time >= 1)
            {
                plustime = false;
                time = 0;
            }
        }
        else
        {
            m_sword.SetActive(false);
        }

    }
}
