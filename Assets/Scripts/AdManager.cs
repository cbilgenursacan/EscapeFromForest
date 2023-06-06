using HmsPlugin;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdManager : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {
        HMSAdsKitManager.Instance.LoadAllAds();
        HMSAdsKitManager.Instance.LoadBannerAd();
        HMSAdsKitManager.Instance.ShowBannerAd();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
