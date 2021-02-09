using UnityEngine;
using DarkTonic.MasterAudio;
namespace OutbackGames.IntegrationTools
{
    public class AnimSoundTrigger : MonoBehaviour
    {
        //default values from DarkTonic's MasterAudio API guide.
        const float pitchLevel = 1f; 
        const float clipDelay = 0f; 

        [SerializeField, SoundGroup]
        string soundGroupName;
        [SerializeField, Tooltip("The Clip Name or 'Variation Name' from the Sound Group Playlist")]
        string clipName;
        [SerializeField, Tooltip("Overrides Sound Group Volume Playback For This Call")]
        float clipVolume = 0.3f;
        Vector3 objPosition;
		
		//Initializes the Object's Position for TriggerSoundAtObject()
        private void Start()
        {
            objPosition = transform.position;
        }
		
		//Plays Sound at Listener Position
        public void TriggerSound()
        {
            MasterAudio.PlaySound(soundGroupName, clipVolume, pitchLevel, clipDelay, clipName);
        }

		//Plays Sound At Attached Object's Location
        public void TriggerSoundAtObject()
        {
            MasterAudio.PlaySound3DAtVector3AndForget(soundGroupName, objPosition, clipVolume, pitchLevel, clipDelay, clipName);
        }
    }

}
