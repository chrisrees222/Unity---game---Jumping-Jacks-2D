using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Share_Script : MonoBehaviour
{
	public void ClickToShare()
	{
		//for screen shot image to share
		//StartCoroutine(TakeScreenshotAndShare());

		//for image from the Resources file in assets
		StartCoroutine(ShareaImage());
	}

	//take screen shot.
	private IEnumerator TakeScreenshotAndShare()
	{
		yield return new WaitForEndOfFrame();

		Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
		ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
		ss.Apply();

		string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
		File.WriteAllBytes(filePath, ss.EncodeToPNG());

		// To avoid memory leaks
		Destroy(ss);

		new NativeShare().AddFile(filePath)
			.SetSubject("Jumping Jacks").SetText("The game is coming soon")
			.SetCallback((result, shareTarget) => Debug.Log("Share result: " + result + ", selected app: " + shareTarget))
			.Share();

	}

	//for sharing a image.
	//dont forget to set image to read/write and set compression to none.
	private IEnumerator ShareaImage()
    {
		Texture2D image = Resources.Load("Jumping_Jacks", typeof(Texture2D)) as Texture2D;

		yield return null;

		string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
		File.WriteAllBytes(filePath, image.EncodeToPNG());

		new NativeShare().AddFile(filePath).SetText("https://play.google.com/apps/internaltest/4699104614889146199").Share();
	}
}
