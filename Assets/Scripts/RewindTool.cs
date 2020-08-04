using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewindTool : MonoBehaviour
{
    private GameObject gameobj;

    // Start is called before the first frame update
    void Start()
    {
        gameobj = this.gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        gameobj.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


        Debug.Log(gameobj.transform.rotation.eulerAngles.z);
        if(gameobj.transform.rotation.eulerAngles.z >= 90 && gameobj.transform.rotation.eulerAngles.z <= 270)
        {
            gameobj.GetComponent<SpriteRenderer>().flipY = true;
        }else
        {
            gameobj.GetComponent<SpriteRenderer>().flipY = false;
        }
    }
}
