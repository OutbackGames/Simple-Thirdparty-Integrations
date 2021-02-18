using UnityEngine;
using Com.LuisPedroFonseca.ProCamera2D;

namespace OutbackGames.IntegrationTools.ProCamera2D{
	
public class InitializeObjectAsProCam2DTarget : MonoBehaviour
{
	//Set The Attached Game Object To The Target For ProCamera2D.
	void Start()
	{
		ProCamera2D.Instance?.AddCameraTarget(gameObject.transform);
		ProCamera2D.Instance?.CenterOnTargets();

//Section only for Editor use
#if UNITY_EDITOR
		if(ProCamera2D.Instance == null)
		{
			Debug.LogError("There Is No ProCamera2D Instance To Reference!");
		}
#endif

	}

}
}
