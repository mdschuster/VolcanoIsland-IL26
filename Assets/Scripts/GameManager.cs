using UnityEditorInternal;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance=null;

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
    }

    public static GameManager Instance()
    {
        return _instance;
    }

    public Player player;
    public Spawner spawner;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //reset the game
        //call player reset and the spawner reset
        player.reset();
        spawner.reset();

    }

    void restart()
    {
        player.reset();
        spawner.reset();
    }

}
