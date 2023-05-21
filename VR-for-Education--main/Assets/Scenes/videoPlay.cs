using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoPlay : MonoBehaviour
{

    public VideoPlayer vid;
    public VideoClip myclip;

    public void skull()
    {
        vid.clip = myclip;
    }
}
