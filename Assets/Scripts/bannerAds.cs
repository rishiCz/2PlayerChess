using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class bannerAds : MonoBehaviour
{
    // Start is called before the first frame update
    string gameId = "4941785";
    string placementId = "Banner_Android";
    bool testMode = false;
    
     void Start () {
        // Initialize the SDK if you haven't already done so:
        Advertisement.Initialize (gameId, testMode);
        StartCoroutine (ShowBannerWhenReady ());
    }

    IEnumerator ShowBannerWhenReady () {
        while (!Advertisement.IsReady (placementId)) {
            yield return new WaitForSeconds (0.5f);
        }
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show (placementId);
    }

}

