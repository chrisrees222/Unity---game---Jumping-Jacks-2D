using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
public class Ad_Unity : MonoBehaviour, IUnityAdsListener
{
    
    string myPlacementId = "Rewarded_Android";

    
    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize("4255431", false);
    }

    public void showAd(string p)
    {
        Advertisement.Show(p);
    }
    

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            Frog_Move.frogLives = 10;
            SceneManager.LoadScene(Frog_Move.level);
        }
        else if(showResult == ShowResult.Failed)
        {
            Debug.Log("Failed to finish");
        }
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        Debug.Log("Advert did start");
    }

    public void OnUnityAdsReady(string placementId)
    {
        Debug.Log("Advert ready");
    }

    public void OnUnityAdsDidError(string message)
    {
        Debug.Log("Advert created error?");
    }


}
