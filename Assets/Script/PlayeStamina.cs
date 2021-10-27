using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayeStamina : MonoBehaviour
{
    // Start is called before the first frame update

    public float Stamina = 100;

    [SerializeField] Image m_StaminaBar;
    void Update()
    {
        if(Stamina < 100)
        {
            Stamina += Time.deltaTime * 10;
        }

        if(Stamina > 100)
        {
            Stamina = 100;
        }

        m_StaminaBar.fillAmount = Stamina / 100;
    }
}
