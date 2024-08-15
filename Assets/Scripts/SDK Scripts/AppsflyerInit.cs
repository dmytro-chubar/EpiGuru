using AppsFlyerSDK;
using UnityEngine;

public class AppsflyerInit : MonoBehaviour
{
    [SerializeField] private string devKey;
    [SerializeField] private string appId;

    private void Start () {
        AppsFlyer.initSDK(devKey, appId, this);
        AppsFlyer.startSDK();
    }
}
