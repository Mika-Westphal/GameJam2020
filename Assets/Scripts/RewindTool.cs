using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class RewindTool : MonoBehaviour
{
    private GameObject gameobj;
    private Light2D light;
    private PolygonCollider2D hitbox;
    private List<Recordable> recored = new List<Recordable>();

    public bool isRecording = false;

    // Start is called before the first frame update
    void Start()
    {
        gameobj = this.gameObject;
        light = gameobj.GetComponentInChildren<Light2D>();
        hitbox = light.GetComponentInChildren<PolygonCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            light.intensity = 3;
            isRecording = true;
        } else {
            light.intensity = 0;
            isRecording = false;
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            foreach(Recordable recAble in recored)
            {
                recAble.Rewind();
            }
        }




        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        gameobj.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


        //Debug.Log(gameobj.transform.rotation.eulerAngles.z);
        if(gameobj.transform.rotation.eulerAngles.z >= 90 && gameobj.transform.rotation.eulerAngles.z <= 270)
        {
            gameobj.GetComponent<SpriteRenderer>().flipY = true;
        }else
        {
            gameobj.GetComponent<SpriteRenderer>().flipY = false;
        }
    }


    public List<Vector3> locRot = new List<Vector3>();
    void OnTriggerStay2D(Collider2D collision)
    {
        if (isRecording)
        {
            if (collision.tag != "rewindable") return;

            Debug.Log(collision.name);
            Vector3 vec = new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.eulerAngles.z);
            locRot.Insert(0, vec);
            collision.GetComponent<Recordable>().idfc = true;


        } else if (collision.GetComponent<Recordable>() != null && collision.GetComponent<Recordable>().idfc == true)
        {
            collision.GetComponent<Recordable>().SetWasRecored(true);
            collision.GetComponent<Recordable>().locRot = locRot;
            recored.Add(collision.GetComponent<Recordable>());
            collision.GetComponent<Recordable>().idfc = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(isRecording)
        {
            collision.GetComponent<Recordable>().SetWasRecored(true);
            collision.GetComponent<Recordable>().locRot = locRot;
            recored.Add(collision.GetComponent<Recordable>());
        }
    }
}
