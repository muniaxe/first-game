using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool isGrounded = true;
    public float thrust = 1f;
    public float jump = 10f;
    public Rigidbody Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionStay(Collision CollisionInfo)
        {
            if ( CollisionInfo.gameObject.name == ("Floor") )
            {

                Debug.Log ( "Hola terre2" );
                isGrounded = true;
            }
        }

        if (Input.GetKey ( "w" )){
            Rb.AddForce ( thrust  * Time.deltaTime, 0, 0, ForceMode.Impulse );
        }

        if ( Input.GetKey ( "s" ) )
        {
            Rb.AddForce ( -thrust  * Time.deltaTime, 0, 0, ForceMode.Impulse );
        }

        if ( Input.GetKey ( "a" ) )
        {
            Rb.AddForce ( 0, 0, thrust  * Time.deltaTime, ForceMode.Impulse );
        }

        if ( Input.GetKey ( "d" ) )
        {
            Rb.AddForce ( 0, 0, -thrust  * Time.deltaTime, ForceMode.Impulse );
        }

        if ( Input.GetKeyDown ( KeyCode.Space ) && isGrounded == true)
        {
            Rb.AddForce ( 0, jump  * Time.deltaTime, 0, ForceMode.Impulse );
            isGrounded = false;
            Debug.Log ( "Hola terre" );
        }


    }
}
