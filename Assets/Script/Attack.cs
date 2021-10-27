using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Attack : MonoBehaviour
{
    HP hp;
    [SerializeField] float _Damage = 1;
    [SerializeField] Image HPBar;
    [SerializeField] float _chengeVI = 0.2f;
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
                hp.m_HP -= _Damage;

                ChengeV(hp.m_HP / 10);
            }
        }
    }
    void ChengeV(float value)
    {
        DOTween.To(() => HPBar.fillAmount, x => HPBar.fillAmount = x, value, _chengeVI).OnComplete(() => Debug.Log("ダメージ"));
    }
}
