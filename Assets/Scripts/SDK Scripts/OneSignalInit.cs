using OneSignalSDK;
using UnityEngine;

public class OneSignalInit : MonoBehaviour
{
    [SerializeField] private string oneSignalAppId;
    void Start () =>
        OneSignal.Default.Initialize(oneSignalAppId);
}
