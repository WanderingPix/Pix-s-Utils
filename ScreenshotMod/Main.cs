using System;
using System.IO;
using UnityEngine;

namespace ScreenshotMod
{
  public class Main
  {
    public void FixedUpdate()
    {
      if (Input.GetKeyDown(KeyCode.F2))
      {
        ScreenCapture.CaptureScreenshot(Application.dataPath + "/screenshots/" + "screenshot_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png", 4);
      }
    }
  }
}
