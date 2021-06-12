using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelExiter : MonoBehaviour
{
    [SerializeField] Door _doorA, _doorB;
    [SerializeField] string _sceneToLoad;
    private void Update()
    {
        if (_doorA.playerIsOverDoor && _doorB.playerIsOverDoor)
            SceneManager.LoadScene(_sceneToLoad, LoadSceneMode.Single);
    }
}