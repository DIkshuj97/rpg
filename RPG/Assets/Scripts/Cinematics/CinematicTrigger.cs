using UnityEngine.Playables;
using UnityEngine;

namespace RPG.Cinematic {
    public class CinematicTrigger : MonoBehaviour
    {
        bool alreadyTriggered = false;
        private void OnTriggerEnter(Collider other)
        {
            if (!alreadyTriggered && other.gameObject.tag=="Player")
            {
                GetComponent<PlayableDirector>().Play();
                alreadyTriggered = true;
            }
        }
    }
}
