using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class AdPlay : MonoBehaviour
{

	public void Ad_Show(){

		Debug.Log ("a1-" + Advertisement.isInitialized);
		Debug.Log ("a2-" + Advertisement.isSupported);
		Debug.Log ("a3-" + Advertisement.IsReady ());
		Debug.Log ("a3-" + Advertisement.IsReady ("rewardedVideo"));
		if (Advertisement.IsReady ("rewardedVideo")) {
			Advertisement.Show ("rewardedVideo", new ShowOptions (){ resultCallback = HandleAdResult });
		}

	}

	private void HandleAdResult(ShowResult Rslt){

		switch (Rslt) {
		case ShowResult.Failed:
			Debug.Log ("ya failed brah");
			break;
		case ShowResult.Skipped:
			Debug.Log ("Why did u skip bro?");
			break;
		case ShowResult.Finished:
			Debug.Log ("gratz!");
			break;

		}

	}

}

