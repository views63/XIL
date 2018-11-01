
using System.Collections.Generic;
using UnityEngine;


public class Bootstrap : MonoBehaviour
{
    private void Awake()
    {
#if USE_HOT
        wxb.hotMgr.Init();
#endif
        var canvas = Resources.Load("Canvas");
        Instantiate(canvas);
    }
}
