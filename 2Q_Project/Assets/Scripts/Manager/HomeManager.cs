using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeManager : MonoBehaviour
{
    public void OnClickSearchByCamera()
    {
        PopupUIManager.Instance.GetPopup<PopupCameraCapture>().ShowPopup();
    }
}
