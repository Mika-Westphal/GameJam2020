using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinemaschineConfig : MonoBehaviour
{
    public GameObject vcam;
    public float OrthographicSize = 10f;

    // Configures the vcam
    void Start()
    {
        //Get "CinemachineVirtualCamera"
        var camera = vcam.GetComponent<CinemachineVirtualCamera>();

        //Set Player as target
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        camera.Follow = player.transform;

        //Set OrthographicSize
        camera.m_Lens.OrthographicSize = OrthographicSize;


        //Configure the body of the vcam
        var composer = vcam.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineFramingTransposer>();

        //Damping
        composer.m_XDamping = 0.5f;
        composer.m_YDamping = 0.5f;
        composer.m_ZDamping = 0.5f;

        //Deadzone
        composer.m_DeadZoneWidth = 0.1f;
        composer.m_DeadZoneHeight = 0.1f;


    }
}
