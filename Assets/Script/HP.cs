using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HP : MonoBehaviour
{
    // Start is called before the first frame update
    public float m_HP;

    public bool invincible;

    float time;

    [SerializeField] GameObject m_Text;

    float interval;

    //[SerializeField] Image HPBar;
    void Start()
    {
        m_Text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (invincible)
        {
            time += Time.deltaTime;
            if (time >= interval)
            {
                invincible = false;
                m_Text.SetActive(false);
                time = 0;
            }
        }

        //HPBar.fillAmount = m_HP / 10;
    }

    public void Mutekinisimasu(float invincibleTime)
    {
        interval = invincibleTime;
        invincible = true;
        m_Text.SetActive(true);
    }
}
