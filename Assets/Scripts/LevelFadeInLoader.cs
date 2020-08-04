using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFadeInLoader : MonoBehaviour
{
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;

    // Start is called before the first frame update
    void Start()
    {
        Image1.SetActive(true);
        Image2.SetActive(true);
        Image3.SetActive(true);
        Image4.SetActive(true);
    }
}
