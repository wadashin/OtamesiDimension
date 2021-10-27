using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject player;

    [SerializeField] bool m_Switch;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = player.transform.position.x;
        var y = player.transform.position.y;
        var z = player.transform.position.z;

        if (!m_Switch)
        {
            transform.position = new Vector3(x, y + 20, z);
        }
        else
        {
            transform.position = new Vector3(x + 516.8292f, y + 161.85f, z + -81.52935f);
        }
        
    }
}
