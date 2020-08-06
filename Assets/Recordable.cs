using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recordable : MonoBehaviour
{
    public bool idfc = false;
    public bool wasRecorded = false;
    public List<Vector3> locRot;
    public bool rewind;

    public void SetWasRecored(bool value)
    {
        wasRecorded = value;

        if(value == true && this.GetComponent<Rigidbody2D>() != null)
        {
            this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
        else if(this.GetComponent<Rigidbody2D>() != null)
        {

        }
    }

    private void FixedUpdate()
    {
        if(rewind == true && locRot.Count >= 1)
        {
            this.transform.position = new Vector3(locRot[0].x, locRot[0].y, this.transform.position.z);
            this.transform.eulerAngles = new Vector3(0,0, locRot[0].z);
            locRot.RemoveAt(0);
        }else if(rewind)
        {
            rewind = false;
            if (this.GetComponent<Rigidbody2D>() != null)
            {
                this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            }
        }
    }

    public void Rewind()
    {
        rewind = true;
    }

}
