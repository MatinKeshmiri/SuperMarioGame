using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 10f;
    public float height = 20f;
    public bool grounded = false;
    bool jumped = false;
    private Rigidbody2D rb;
    public static int PlayerState;
    public static int GarbageNum;
    public bool CanControl = true;
    public static PlayerController PlayerInstance = null;


    [SerializeField] SoundFxManager sfx;
    [SerializeField] AudioClip defaultJumpSfx;
    [SerializeField] AudioClip bigJumpSfx;
    [SerializeField] AudioClip coinSfx;
    [SerializeField] AudioClip powerupSfx;

    [SerializeField]
    private static float _Health = 100f;

    public static float Health
    {
        get
        {
            return _Health;
        }
        set
        {
            _Health = value;
            //If we are dead, then end game
            if (_Health <= 0)
            {

                Die();
            }
            else GameData.EndScene = "You Won!";
            
        }
    }
    


    //Animator anim;
    
    void Awake()
    {
        PlayerInstance = this;
    }
    void Start()
    {
        //Baseline State for the player
        PlayerState = 0;
        GarbageNum = 0;
       
        rb = GetComponent<Rigidbody2D>();
       
    }

    void Update()
    {
        State();
        if (Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.Space))))
        {
            jumped = true;
        }
    }
    

    void FixedUpdate ()
    {
        //If we cannot control character, then exit
        if (!CanControl || Health <= 0f)
        {
            return;
        }
        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
        {
            transform.Translate(Vector3.right * speed * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
            transform.Translate(Vector3.left * speed * Time.fixedDeltaTime);
        }

        
        if (jumped)
        {
            jumped = false;
            if(grounded == true)
            {
                //rb.velocity = new Vector2(0f, height);
                rb.velocity = new Vector2(rb.velocity.x, height);

                if (PlayerState == 0)
                    sfx.PlaySoundFX(defaultJumpSfx);
                else
                    sfx.PlaySoundFX(bigJumpSfx);
            }
        }


    }

    void State()
    {
        if(PlayerState == 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if(PlayerState == 1)
        {
            transform.localScale = new Vector3(1f, 1.5f, 1f);
            
        }
                       
    }
        
    void OnTriggerEnter2D( Collider2D other)
    {
        if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Enemy")
            grounded = true;

        if (other.gameObject.tag == "garbage")
            sfx.PlaySoundFX(coinSfx);
        if (other.gameObject.tag == "mushroom")
            sfx.PlaySoundFX(powerupSfx);

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Enemy")
            grounded = false;

    }
   
    void OnDestroy()
    {
        PlayerInstance = null;
    }
    //--------------------------------
    //Function to kill player
    static void Die()
    {
        Destroy(PlayerController.PlayerInstance.gameObject);
        
        GameData.EndScene = "You Lost!";
       
        SceneManager.LoadScene(4);
    }
   

    //--------------------------------
    //Resets player back to defaults
    public static void Reset()
    {
        Health = 100f;
    }
}
