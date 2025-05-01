using System;
using System.IO;
using UnityEngine;

namespace SayCheese
{
  public class ScreenshotComp : MonoBehaviour
  {
    public void FixedUpdate()
    {
      if (Input.GetKeyDown(KeyCode.F2))
      {
        ScreenCapture.CaptureScreenshot(Application.dataPath + "/screenshots/" + "screenshot_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png", 4);
        var popper = HudManager.Instance.Notifier;
        var newMessage = Object.Instantiate(popper.notificationMessageOrigin, Vector3.zero, Quaternion.identity, popper.transform);
        newMessage.transform.localPosition = localPos;
    }
  }
}
